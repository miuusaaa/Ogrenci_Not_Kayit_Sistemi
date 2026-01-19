using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Öğrenci_Not_Kayıt_Sistemi
{
    public partial class FrmAdminIslemleri : Form
    {
        public FrmAdminIslemleri()
        {
            InitializeComponent();
        }

        private string conString = "Server=AKALI;Database=OgrenciNotKayitSistemi;Trusted_Connection=True;TrustServerCertificate=True;";
        private DataTable dtAdminler;

        private void FrmAdminIslemleri_Load(object sender, EventArgs e)
        {
            LoadAdminler();
            dgvAdminler.ClearSelection();
            txtTelefon.MaxLength = 13;
        }

        private void LoadAdminler()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string sql = @"SELECT AdminID, Email, Telefon FROM ADMINGIRISBILGILERI";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                dtAdminler = new DataTable();
                da.Fill(dtAdminler);

                dgvAdminler.DataSource = dtAdminler;
            }
        }

        private void btnAdminSil_Click(object sender, EventArgs e)
        {
            if (dgvAdminler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek admini seçin.");
                return;
            }

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                string sqlonly = "SELECT COUNT(*) FROM ADMINGIRISBILGILERI";

                using (SqlCommand cmd = new SqlCommand(sqlonly, con))
                {
                    int result = (int)cmd.ExecuteScalar();
                    
                    if(result == 1)
                    {
                        MessageBox.Show("Sistemdeki ilk admin silinemez!");
                        return;
                    }
                }
            }

            string adminID = dgvAdminler.CurrentRow.Cells["AdminID"].Value.ToString();

            var confirm = MessageBox.Show(
                $"{adminID} adlı admin silinsin mi?",
                "Onay",
                MessageBoxButtons.YesNo
            );

            if (confirm != DialogResult.Yes) return;

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string sql = "DELETE FROM ADMINGIRISBILGILERI WHERE AdminID=@id";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", adminID);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Admin sistemden başarıyla silindi.");

            LoadAdminler();
        }

        private async void btnAdminEkle_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string email = txtEmail.Text.Trim();
            string telefon = txtTelefon.Text.Trim();

            if (string.IsNullOrWhiteSpace(kullaniciAdi)
                || string.IsNullOrWhiteSpace(email)
                  || string.IsNullOrWhiteSpace(telefon))
            {
                MessageBox.Show("Kullanıcı adı , email ve telefon girişi zorunludur.");
                return;
            }

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                // 🔴 1. ÇAKIŞMA KONTROLÜ
                string kontrolSql = @"
        SELECT 
            SUM(CASE WHEN AdminID = @id THEN 1 ELSE 0 END) AS KullaniciAdiVar,
            SUM(CASE WHEN Email = @mail THEN 1 ELSE 0 END) AS EmailVar,
            SUM(CASE WHEN Telefon = @tel THEN 1 ELSE 0 END) AS TelefonVar
        FROM ADMINGIRISBILGILERI";

                using (SqlCommand kontrolCmd = new SqlCommand(kontrolSql, con))
                {
                    kontrolCmd.Parameters.AddWithValue("@id", kullaniciAdi);
                    kontrolCmd.Parameters.AddWithValue("@mail", email);
                    kontrolCmd.Parameters.AddWithValue("@tel", telefon);

                    using (SqlDataReader dr = kontrolCmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            if (Convert.ToInt32(dr["KullaniciAdiVar"]) > 0)
                            {
                                MessageBox.Show("Bu kullanıcı adı zaten kayıtlı.");
                                return;
                            }
                            if (Convert.ToInt32(dr["EmailVar"]) > 0)
                            {
                                MessageBox.Show("Bu e-posta adresi zaten kayıtlı.");
                                return;
                            }
                            if (Convert.ToInt32(dr["TelefonVar"]) > 0)
                            {
                                MessageBox.Show("Bu telefon numarası zaten kayıtlı.");
                                return;
                            }
                        }
                    }
                }

            }

            string plainPassword = GeneratePassword();
            string hash = BCrypt.Net.BCrypt.HashPassword(plainPassword);
            bool dbBasarili = false;

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlTransaction tr = con.BeginTransaction();

                try
                {
                    string sql = @"INSERT INTO ADMINGIRISBILGILERI
                           (AdminID, SifreHash, Email, Telefon,IlkGiris)
                           VALUES (@id, @hash, @mail, @tel, 1)";

                    using (SqlCommand cmd = new SqlCommand(sql, con, tr))
                    {
                        cmd.Parameters.AddWithValue("@id", kullaniciAdi);
                        cmd.Parameters.AddWithValue("@hash", hash);
                        cmd.Parameters.AddWithValue("@mail", email);
                        cmd.Parameters.AddWithValue("@tel", telefon);
                        cmd.ExecuteNonQuery();
                    }

                    tr.Commit();
                    dbBasarili = true;
                }

                catch (Exception ex)
                {
                    try { tr.Rollback(); } catch { }
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                    return;
                }
            }

            // 🔹 BURASI ARTIK TRANSACTION DIŞI
            if (dbBasarili)
            {
                try
                {
                    MailHelper.SendPasswordMail(email, kullaniciAdi, plainPassword);
                    await SmsHelper.SendSmsAsync(telefon, kullaniciAdi, plainPassword);

                    MessageBox.Show("Admin eklendi ve bilgiler gönderildi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Admin eklendi fakat bildirim gönderilemedi:\n" + ex.Message
                    );
                }

                txtKullaniciAdi.Clear();
                txtEmail.Clear();
                txtTelefon.Clear();
                LoadAdminler();

            }
        }

        private void dgvAdminler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtKullaniciAdi.Text = dgvAdminler.Rows[e.RowIndex].Cells["AdminID"].Value.ToString();
            txtEmail.Text = dgvAdminler.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            txtTelefon.Text = dgvAdminler.Rows[e.RowIndex].Cells["Telefon"].Value.ToString();
        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefon.Text.Length > 13)
            {
                MessageBox.Show("Telefon numarası 13 karakterden fazla olamaz.");
                txtTelefon.Text = txtTelefon.Text.Substring(0, 13);
                txtTelefon.SelectionStart = txtTelefon.Text.Length;
            }
        }

        private string GeneratePassword()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 10);
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '+')
                e.Handled = true;

            if (txtTelefon.Text.Length >= 13 && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void txtTelefon_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtTelefon.Text, @"^\+90\d{10}$"))
            {
                MessageBox.Show("Telefon numarası +905XXXXXXXXX formatında olmalıdır.");
                txtTelefon.Focus();
            }
        }
    }
}
