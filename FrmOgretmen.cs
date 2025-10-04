using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Öğrenci_Not_Kayıt_Sistemi
{
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        string conn = "Server=AKALI;Database=OgrenciNotKayitSistemi;Trusted_Connection=True;TrustServerCertificate=True;";
        private void FrmOgretmen_Load(object sender, EventArgs e)
        {
            List();
        }

        private bool ValidateTCKimlik(string tck)
        {
            if (tck.Length != 11 || !tck.All(char.IsDigit))
                return false;

            int[] digits = tck.Select(c => int.Parse(c.ToString())).ToArray();

            // İlk hane 0 olamaz
            if (digits[0] == 0)
                return false;

            // 10. hane kontrolü
            int oddSum = digits[0] + digits[2] + digits[4] + digits[6] + digits[8];
            int evenSum = digits[1] + digits[3] + digits[5] + digits[7];
            int h10 = ((oddSum * 7) - evenSum) % 10;
            if (digits[9] != h10)
                return false;

            // 11. hane kontrolü
            int total = digits.Take(10).Sum();
            if (digits[10] != total % 10)
                return false;

            return true;
        }

        private void List()
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                string query = "select * from OGRBILGILERI";
                SqlCommand cmd = new SqlCommand(query, connection);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                string queryOrt = "select avg(Ortalama) from OGRBILGILERI";
                SqlCommand cmd2 = new SqlCommand(queryOrt, connection);
                object o = cmd2.ExecuteScalar();
                lblSinifOrt.Text = o.ToString();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtTC.Text = row.Cells["OGRNO"].Value.ToString();
                txtS1.Text = row.Cells["S1"].Value.ToString();
                txtS2.Text = row.Cells["S2"].Value.ToString();
                txtS3.Text = row.Cells["S3"].Value.ToString();

                lblOgrOrt.Text = row.Cells["Ortalama"].Value.ToString();
                lblOgrSonuc.Text = row.Cells["Sonuç"].Value.ToString();
            }

        }

        private void btnOgrEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOgrOkulNo.Text) || string.IsNullOrWhiteSpace(txtOgrAd.Text) || string.IsNullOrWhiteSpace(txtOgrSoyad.Text) || string.IsNullOrWhiteSpace(txtTC.Text))
            {
                MessageBox.Show("Lütfen eklenecek öğrencinin bilgilerini eksiksiz doldurun !");
                return;
            }

            if ((txtOgrOkulNo.Text.Length == 0))
            {
                MessageBox.Show("Öğrenci no 0 olamaz.");
                return;
            }

            if (!ValidateTCKimlik(txtTC.Text))
            {
                MessageBox.Show("Geçersiz T.C. Kimlik Numarası!");
                return;
            }

            DialogResult result = MessageBox.Show(
            "Öğrenciyi eklemek istediğinize emin misiniz ?",
            "Onay",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    // Önce OGRNO'nun OGRGIRISBILGILERI'de var mı diye kontrol et
                    string checkQuery = "SELECT COUNT(*) FROM OGRGIRISBILGILERI WHERE OGRNO=@no or tckimlikno=@tc";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@no", Convert.ToInt32(txtOgrOkulNo.Text));
                    checkCmd.Parameters.AddWithValue("@tc", txtTC.Text);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        
                        string queryPKEkle = "insert into OGRGIRISBILGILERI (OGRNO,tckimlikno) VALUES (@no1,@tc1)";
                        SqlCommand cmd = new SqlCommand(queryPKEkle, connection);
                        cmd.Parameters.AddWithValue("@no1", Convert.ToInt32(txtOgrOkulNo.Text));
                        cmd.Parameters.AddWithValue("@tc1", txtTC.Text);
                        cmd.ExecuteNonQuery();

                        string queryFKEkle = "insert into OGRBILGILERI (OGRNO,OGRAD,OGRSOYAD) VALUES (@no1,@ad,@soyad)";
                        SqlCommand cmd2 = new SqlCommand(queryFKEkle, connection);
                        cmd2.Parameters.AddWithValue("@no1", Convert.ToInt32(txtOgrOkulNo.Text));
                        cmd2.Parameters.AddWithValue("@ad", txtOgrAd.Text);
                        cmd2.Parameters.AddWithValue("@soyad", txtOgrSoyad.Text);
                        cmd2.ExecuteNonQuery();

                       
                    }
                    else
                    {
                        MessageBox.Show("Bu öğrenci zaten kayıtlı!");
                        return;
                    }
                }
                MessageBox.Show("Öğrenci Ekleme işlemi başarılı.");
                List();
            }
        }

        private void txtOgrOkulNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }


            if (char.IsDigit(e.KeyChar) && txtOgrOkulNo.Text.Length >= 4)
            {
                e.Handled = true;
            }
        }

        private void txtOgrAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtOgrSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNotOkulNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar) && txtTC.Text.Length >= 4)
            {
                e.Handled = true;
            }
        }

        private void txtS1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar) && txtS1.Text.Length >= 5)
            {
                e.Handled = true;
            }
        }

        private void txtS2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar) && txtS2.Text.Length >= 5)
            {
                e.Handled = true;
            }
        }

        private void txtS3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar) && txtS3.Text.Length >= 5)
            {
                e.Handled = true;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTC.Text))
            {
                MessageBox.Show("Lütfen güncellenecek öğrencinin okul numarasını girin.");
                return;
            }

            decimal s1 = 0, s2 = 0, s3 = 0;

            if (!string.IsNullOrWhiteSpace(txtS1.Text))
                s1 = Convert.ToDecimal(txtS1.Text);

            if (!string.IsNullOrWhiteSpace(txtS2.Text))
                s2 = Convert.ToDecimal(txtS2.Text);

            if (!string.IsNullOrWhiteSpace(txtS3.Text))
                s3 = Convert.ToDecimal(txtS3.Text);

            // Kontrol
            if (s1 > 100 || s2 > 100 || s3 > 100)
            {
                MessageBox.Show("Not değeri 100'den büyük olamaz.");
                return;
            }

            DialogResult result = MessageBox.Show(
            "Değişiklikler kaydedilsin mi?",
            "Onay",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    string queryGuncelle = "update OGRBILGILERI SET  S1 = @s1 , S2 = @s2 , S3 = @s3 WHERE OGRNO = @no";
                    SqlCommand cmd = new SqlCommand(queryGuncelle,connection);


                    cmd.Parameters.AddWithValue("@no", Convert.ToInt32(txtTC.Text));

                    if (string.IsNullOrWhiteSpace(txtS1.Text))
                        cmd.Parameters.AddWithValue("@s1", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@s1", decimal.Parse(txtS1.Text));
                        
                    if (string.IsNullOrWhiteSpace(txtS2.Text))
                        cmd.Parameters.AddWithValue("@s2", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@s2", decimal.Parse(txtS2.Text));

                    if (string.IsNullOrWhiteSpace(txtS3.Text))
                        cmd.Parameters.AddWithValue("@s3", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@s3", decimal.Parse(txtS3.Text));
                   
                    cmd.ExecuteNonQuery();
                    
                }
                MessageBox.Show("Güncelleme İşlemi tamamlandı.");
                List();
            }
           
        }

        private void btnOgrSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOgrOkulNo.Text) || string.IsNullOrWhiteSpace(txtOgrAd.Text) || string.IsNullOrWhiteSpace(txtOgrSoyad.Text))
            {
                MessageBox.Show("Lütfen silinecek öğrencinin bilgilerini eksiksiz girin.");
                return;
            }

            DialogResult result = MessageBox.Show(
            "Öğrenciyi silmek istediğinize emin misiniz ?",
            "Onay",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {

                    connection.Open();
                    
                    string querySil1 = "delete from OGRGIRISBILGILERI where OGRNO = @no and TcKimlikNo = @tc";
                    SqlCommand cmd1 = new SqlCommand(querySil1, connection);
                    cmd1.Parameters.AddWithValue("@no", Convert.ToInt32(txtOgrOkulNo.Text));
                    cmd1.Parameters.AddWithValue("@tc", txtTC.Text);
                    int affected = cmd1.ExecuteNonQuery();

                    if (affected == 0)
                    {
                        MessageBox.Show("Böyle bir öğrenci bulunamadı.");
                        return;
                    }

                    else
                    {
                        string querySil2 = "delete from OGRBILGILERI where OGRNO = @no1 and TcKimlikNo = @tc1 and OGRAD = @ad and OGRSOYAD = @soyad";
                        SqlCommand cmd2 = new SqlCommand(querySil2, connection);
                        cmd2.Parameters.AddWithValue("@no1", Convert.ToInt32(txtOgrOkulNo.Text));
                        cmd2.Parameters.AddWithValue("@ad", txtOgrAd.Text);
                        cmd2.Parameters.AddWithValue("@soyad", txtOgrSoyad.Text);
                        cmd2.Parameters.AddWithValue("@tc1",txtTC.Text);

                        MessageBox.Show("Öğrenci başarılı bir şekilde silindi.");
                        List();
                    }
                }
                
            }
        }
    }
}
