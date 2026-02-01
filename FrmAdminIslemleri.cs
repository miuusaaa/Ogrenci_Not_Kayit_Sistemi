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
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //formu kullanıcı büyütmesin istiyorsan kullan.
            dgvAdminler.ReadOnly = false;

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.TabStop = true;
                else
                    c.TabStop = false;
            }

            LoadAdminler();
            AktiflikRenkleriniUygula();
            dgvAdminler.ClearSelection();
            txtTelefon.MaxLength = 13;


            dgvAdminler.CurrentCellDirtyStateChanged += dgvAdminler_CurrentCellDirtyStateChanged;

            foreach (DataGridViewRow row in dgvAdminler.Rows)
            {
                bool aktif = row.Cells["Aktiflik"].Value != DBNull.Value && Convert.ToBoolean(row.Cells["Aktiflik"].Value);
            }
        }

        private void dgvAdminler_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvAdminler.IsCurrentCellDirty)
                dgvAdminler.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void LoadAdminler()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string sql = @"SELECT AdminID, Email, Telefon, Aktiflik FROM ADMINGIRISBILGILERI";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                dtAdminler = new DataTable();
                da.Fill(dtAdminler);

                dgvAdminler.DataSource = dtAdminler;

                if (!(dgvAdminler.Columns["Aktiflik"] is DataGridViewCheckBoxColumn))
                {
                    DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                    chk.Name = "Aktiflik";
                    chk.HeaderText = "Aktiflik";
                    chk.DataPropertyName = "Aktiflik";
                    chk.TrueValue = true;
                    chk.FalseValue = false;

                    dgvAdminler.Columns.Remove("Aktiflik");
                    dgvAdminler.Columns.Add(chk);
                }
            }

            dgvAdminler.Columns["Aktiflik"].DisplayIndex = 3;

            foreach (DataGridViewRow row in dgvAdminler.Rows)
            {
                row.Cells["Aktiflik"].Tag = row.Cells["Aktiflik"].Value;
            }

            foreach (DataGridViewColumn col in dgvAdminler.Columns) //sadece aktiflik editable olması için bunu koy yeter başka bişeye gerek yok.
            {
                col.ReadOnly = true;
            }

            dgvAdminler.Columns["Aktiflik"].ReadOnly = false;
        }

        private void btnAdminSil_Click(object sender, EventArgs e)
        {
            if (dgvAdminler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek admini seçin.");
                return;
            }

            string adminID = dgvAdminler.CurrentRow.Cells["AdminID"].Value.ToString();
            bool secilenAdminAktif = Convert.ToBoolean(dgvAdminler.CurrentRow.Cells["Aktiflik"].Value);

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                // Aktif admin sayısını al
                string sqlAktifSayisi = "SELECT COUNT(*) FROM ADMINGIRISBILGILERI WHERE Aktiflik = 1";

                using (SqlCommand cmd = new SqlCommand(sqlAktifSayisi, con))
                {
                    int aktifAdminSayisi = (int)cmd.ExecuteScalar();

                    // Eğer silinmek istenen admin aktifse ve sistemde sadece 1 aktif admin varsa
                    if (secilenAdminAktif && aktifAdminSayisi == 1)
                    {
                        MessageBox.Show("Sistemde en az 1 aktif admin bulunmak zorundadır. Bu admin silinemez.");
                        return;
                    }
                }
            }


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
            AktiflikRenkleriniUygula();
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
                           (AdminID, SifreHash, Email, Telefon,IlkGiris,Aktiflik)
                           VALUES (@id, @hash, @mail, @tel, 1,1)";

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
                    MailHelper.maileIlkGirisBilgileriGonder(email, kullaniciAdi, plainPassword);
                    await SmsHelper.smseIlkGirisBilgileriGonder(telefon, kullaniciAdi, plainPassword);

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
                AktiflikRenkleriniUygula();
            }
        }

        private void dgvAdminler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtKullaniciAdi.Text = dgvAdminler.Rows[e.RowIndex].Cells["AdminID"].Value.ToString();
            txtEmail.Text = dgvAdminler.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            txtTelefon.Text = dgvAdminler.Rows[e.RowIndex].Cells["Telefon"].Value.ToString();
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
                
            }
        }

        private void btnAktiflikKaydet_Click(object sender, EventArgs e)
        {
            using SqlConnection con = new SqlConnection(conString);

            DialogResult onay = MessageBox.Show(
                   "Aktif/Pasif değişiklikleri kaydedilsin mi?",
                   "Onay",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);

            if (onay != DialogResult.Yes)
            {
                return;
            }

            con.Open();
            SqlTransaction tr = con.BeginTransaction();

            try
            {
                bool degisiklikVar = false;

                // 🔴 En az 1 admin aktif kalmalı kontrolü
                int aktifAdminSayisiDB = 0;

                using (SqlCommand cmdCount = new SqlCommand(
                    "SELECT COUNT(*) FROM ADMINGIRISBILGILERI WHERE Aktiflik = 1", con, tr))
                {
                    aktifAdminSayisiDB = (int)cmdCount.ExecuteScalar();
                }

                int pasifeCekilecek = 0;
                int aktifeCekilecek = 0;

                foreach (DataGridViewRow row in dgvAdminler.Rows)
                {
                    bool eski = row.Cells["Aktiflik"].Tag != DBNull.Value
                                && Convert.ToBoolean(row.Cells["Aktiflik"].Tag);

                    bool yeni = row.Cells["Aktiflik"].Value != DBNull.Value
                                && Convert.ToBoolean(row.Cells["Aktiflik"].Value);

                    if (eski == true && yeni == false)
                        pasifeCekilecek++;

                    if (eski == false && yeni == true)
                        aktifeCekilecek++;
                }

                int sonAktifSayisi = aktifAdminSayisiDB - pasifeCekilecek + aktifeCekilecek;

                if (sonAktifSayisi <= 0)
                {
                    MessageBox.Show("Sistemde en az 1 aktif admin bulunmak zorundadır. Bu işlem yapılamaz.");
                    LoadAdminler();
                    AktiflikRenkleriniUygula();
                    return;
                }

                foreach (DataGridViewRow row in dgvAdminler.Rows)
                {
                    bool eski = row.Cells["Aktiflik"].Tag != DBNull.Value && Convert.ToBoolean(row.Cells["Aktiflik"].Tag);
                    bool yeni = row.Cells["Aktiflik"].Value != DBNull.Value && Convert.ToBoolean(row.Cells["Aktiflik"].Value);


                    if (eski != yeni)
                    {
                        degisiklikVar = true;

                        SqlCommand cmd = new SqlCommand(
                            "UPDATE ADMINGIRISBILGILERI SET Aktiflik=@a WHERE AdminID =@adminid",
                            con, tr);

                        cmd.Parameters.AddWithValue("@a", yeni);
                        cmd.Parameters.AddWithValue("@adminid", row.Cells["AdminID"].Value);
                        cmd.ExecuteNonQuery();
                    }
                }

                if (!degisiklikVar)
                {
                    MessageBox.Show("Herhangi bir aktiflik değişimi yapılmadı.");
                    tr.Rollback();
                    return;
                }

               

                tr.Commit();
                MessageBox.Show("Aktif/Pasif değişiklikleri kaydedildi.");
                LoadAdminler();
                AktiflikRenkleriniUygula();
            }
            catch
            {
                tr.Rollback();
                MessageBox.Show("Aktiflik kaydedilirken hata oluştu.");
            }
        }

        private void AktiflikRenkleriniUygula()
        {
            foreach (DataGridViewRow row in dgvAdminler.Rows)
            {
                bool aktif = Convert.ToBoolean(row.Cells["Aktiflik"].Value);

                row.DefaultCellStyle.BackColor =
                    aktif ? Color.White : Color.LightGray;

                // Kalıcı durumu Tag'e kilitle
                row.Cells["Aktiflik"].Tag = aktif;
            }
        }

        private bool EmailGecerliMi(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }

       
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!EmailGecerliMi(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Geçerli bir e-posta adresi giriniz.");
                
            }
        }
    }
}
