using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Öğrenci_Not_Kayıt_Sistemi
{
    public partial class FrmOkulIslemleri : Form
    {
        private string conString = "Server=AKALI;Database=OgrenciNotKayitSistemi;Trusted_Connection=True;TrustServerCertificate=True;";

        public FrmOkulIslemleri()
        {
            InitializeComponent();
        }

        private void LoadOkullar()
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();

                // SQL sorgusu filtrelemedeki gibi: sınıflar birleştirilmiş ve sütunlar düzenli
                string sql = @"select * from Okullar";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvOkullar.DataSource = dt;
                dgvOkullar.Columns["OkulID"].Visible = false;

            }

            dgvOkullar.ClearSelection();
            dgvOkullar.CurrentCell = null;
        }

        private void FrmOkulIslemleri_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.TabStop = true;
                else
                    c.TabStop = false;
            }

            LoadOkullar();

            dgvOkullar.ClearSelection();
            dgvOkullar.CurrentCell = null;
        }

        private void btnOkulEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOkulAd.Text))
            {
                MessageBox.Show("Lütfen bir okul adı girin!");
                return;
            }

            string okulAd = txtOkulAd.Text;
            string guncelOkulAd = txtGuncelOkulAd.Text;

            using (SqlConnection conn = new SqlConnection(conString))
            {
                string sqlokulvarmı = @"SELECT COUNT(*) FROM OKULLAR WHERE OkulAd=@okulad";
                string ekle = @"INSERT INTO OKULLAR VALUES (@okulad)";

                conn.Open();

                using (SqlCommand kontrol = new SqlCommand(sqlokulvarmı, conn))
                {
                    kontrol.Parameters.AddWithValue("@okulad", okulAd);

                    int doluMu = (int)kontrol.ExecuteScalar();

                    if (doluMu > 0)
                    {
                        DialogResult onay = MessageBox.Show(
                   $"Sistemde zaten {okulAd} adında bir okul bulundu.Yine de eklemek istiyor musunuz?",
                   "Onay",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (onay != DialogResult.Yes)
                            return;
                    }
                    else
                    {

                        DialogResult onay1 = MessageBox.Show(
                     $"{okulAd} adlı okulu sisteme eklemek istiyor musunuz?",
                     "Onay",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (onay1 != DialogResult.Yes)
                            return;
                    }
                }


                using (SqlCommand cmdInsert = new SqlCommand(ekle, conn))
                {
                    cmdInsert.Parameters.AddWithValue("@okulad", okulAd);
                    cmdInsert.ExecuteNonQuery();
                }

                MessageBox.Show("Okul sisteme başarıyla eklendi.");
                LoadOkullar();
            }
        }

        private void btnOkulSil_Click(object sender, EventArgs e)
        {
            if (dgvOkullar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen sistemden silmek istediğiniz okulu tablodan seçin!");
                return;
            }

            int okulID = 0;
            if (dgvOkullar.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvOkullar.SelectedRows[0];
                if (dgvOkullar.Columns.Contains("OkulID"))
                    okulID = Convert.ToInt32(row.Cells["OkulID"].Value);
                else
                    return; // ID yoksa işlemi durdur
            }

            DialogResult result = MessageBox.Show(
                "Seçtiğiniz okulu silmek istediğinize emin misiniz?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string deleteOSDO = "DELETE FROM OKULLAR_SINIFLAR_DERSLER_OGRETMENLER WHERE OkulID =@okulID";
                string deleteOSD = "DELETE FROM OKULLAR_SINIFLAR_DERSLER WHERE OkulID =@okulID";
                string deleteOS = "DELETE FROM OKULLAR_SINIFLAR WHERE OkulID =@okulID";
                string deleteOgretmen = "DELETE FROM OGRETMENLER WHERE CalistigiOkul =@okulID";
                string deleteOgrenci = "DELETE FROM OGRENCILER WHERE OkulID =@okulID";
                string deleteOkul = "DELETE FROM OKULLAR WHERE OkulID = @okulID";


                using (SqlCommand komut = new SqlCommand(deleteOSDO, connection))
                {
                    komut.Parameters.AddWithValue("@okulID", okulID);
                    komut.ExecuteNonQuery();
                }

                using (SqlCommand komut = new SqlCommand(deleteOSD, connection))
                {
                    komut.Parameters.AddWithValue("@okulID", okulID);
                    komut.ExecuteNonQuery();
                }

                using (SqlCommand komut = new SqlCommand(deleteOS, connection))
                {
                    komut.Parameters.AddWithValue("@okulID", okulID);
                    komut.ExecuteNonQuery();
                }

                using (SqlCommand komut = new SqlCommand(deleteOgretmen, connection))
                {
                    komut.Parameters.AddWithValue("@okulID", okulID);
                    komut.ExecuteNonQuery();
                }

                using (SqlCommand komut = new SqlCommand(deleteOgrenci, connection))
                {
                    komut.Parameters.AddWithValue("@okulID", okulID);
                    komut.ExecuteNonQuery();
                }

                using (SqlCommand komut = new SqlCommand(deleteOkul, connection))
                {
                    komut.Parameters.AddWithValue("@okulID", okulID);
                    komut.ExecuteNonQuery();
                }

            }

            MessageBox.Show("Okul sistemden başarıyla silindi.");
            LoadOkullar();
        }

        private void btnOkulGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvOkullar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen adını güncellemek istediğiniz okulu tablodan seçin!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGuncelOkulAd.Text))
            {
                MessageBox.Show("Lütfen yeni okul adını girin!");
                return;
            }

            int okulID = 0;
            string guncelOkulAd = txtGuncelOkulAd.Text;
            if (dgvOkullar.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvOkullar.SelectedRows[0];
                if (dgvOkullar.Columns.Contains("OkulID"))
                    okulID = Convert.ToInt32(row.Cells["OkulID"].Value);
                else
                    return; // ID yoksa işlemi durdur
            }

            DialogResult result = MessageBox.Show(
                "Seçtiğiniz okulun adını güncellemek istediğinize emin misiniz?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                string updateOkul = "UPDATE OKULLAR SET OkulAd = @ad WHERE OkulID = @okulID";

                using (SqlCommand komut = new SqlCommand(updateOkul, connection))
                {
                    komut.Parameters.AddWithValue("@okulID", okulID);
                    komut.Parameters.AddWithValue("@ad", guncelOkulAd);
                    komut.ExecuteNonQuery();
                }

            }

            MessageBox.Show("Okul adı başarıyla güncellendi.");
            LoadOkullar();
        }

        private void txtboxAra_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();

                string sql;

                if (string.IsNullOrWhiteSpace(txtboxAra.Text))
                {
                    sql = "SELECT * FROM OKULLAR";
                }
                else
                {
                    sql = "SELECT * FROM OKULLAR WHERE LOWER(OkulAd) LIKE LOWER(@arama)";
                }

                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    if (!string.IsNullOrWhiteSpace(txtboxAra.Text))
                    {
                        da.SelectCommand.Parameters.AddWithValue(
                            "@arama", "%" + txtboxAra.Text + "%"
                        );
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvOkullar.DataSource = dt;
                    dgvOkullar.Columns["OkulID"].Visible = false;
                }
            }
        }

        private void dgvOkullar_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvOkullar.ClearSelection();
            dgvOkullar.CurrentCell = null;
        }
    }
}
