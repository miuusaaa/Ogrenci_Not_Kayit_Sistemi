using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Net;
using System.Windows.Forms;


namespace Öğrenci_Not_Kayıt_Sistemi
{
    public partial class FrmOgrenciListe : Form
    {
        private string conString = "Server=AKALI;Database=OgrenciNotKayitSistemi;Trusted_Connection=True;TrustServerCertificate=True;";

        public FrmOgrenciListe()
        {
            InitializeComponent();
        }

        private void FrmOgrenciListe_Load(object sender, EventArgs e)
        {
            LoadOgrenciler();
            pbFotograf.Image = Properties.Resources.no_photo; // Resources içinde default resim
            dgvOgrenciler.ClearSelection();

        }

        private void LoadOgrenciler()
        {


            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                string sql = @"SELECT OgrNo as 'Numarası',Ad as 'Adı',Soyad as 'Soyadı',DogumTarihi as 'Doğum Tarihi',Tc,Sinif,SinifAd as 'Sınıfı',SifreHash as 'Şifresi',Email as 'E-posta',Telefon
                               FROM OGRENCILER o
                               JOIN SINIFLAR s ON o.Sinif = s.SinifID
                               ORDER BY o.OgrNo";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOgrenciler.DataSource = dt;

                dgvOgrenciler.Columns["Sinif"].Visible = false;

                string sql1 = @"SELECT SinifID,SinifAd from SINIFLAR";
                SqlDataAdapter da1 = new SqlDataAdapter(sql1, conn);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);

                cmbSinif.ValueMember = "SinifID";
                cmbSinif.DisplayMember = "SinifAd";
                cmbSinif.DataSource = dt1;



            }
        }
        private bool kontrol()
        {
            if (string.IsNullOrWhiteSpace(txtOgrNo.Text))
            {
                MessageBox.Show("Öğrenci numarası boş olamaz.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtOgrAd.Text))
            {
                MessageBox.Show("Öğrenci adı boş olamaz.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtOgrSoyad.Text))
            {
                MessageBox.Show("Öğrenci soyadı boş olamaz.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTC.Text))
            {
                MessageBox.Show("Öğrenci TC'si boş olamaz.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbSinif.Text))
            {
                MessageBox.Show("Öğrenci sınıfı boş olamaz.");
                return false;
            }

            if (!txtOgrNo.Text.All(char.IsDigit))
            {
                MessageBox.Show("Öğrenci numarası sadece rakamlardan oluşmalı !");
                return false;
            }

            if (!txtTC.Text.All(char.IsDigit))
            {
                MessageBox.Show("TC numarası sadece rakamlardan oluşmalı !");
                return false;
            }

            return true; // tüm kontroller geçti
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!kontrol()) return;
            if (!ValidateTCKimlik(txtTC.Text))
            {
                MessageBox.Show("Geçersiz TC NO !");
                return;
            }

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();

                // OgrNo benzersiz mi kontrol et
                string checkSql = "SELECT COUNT(*) FROM OGRENCILER WHERE OgrNo=@OgrNo";
                using (SqlCommand cmdCheck = new SqlCommand(checkSql, conn))
                {
                    cmdCheck.Parameters.AddWithValue("@OgrNo", txtOgrNo.Text.Trim());
                    int count = (int)cmdCheck.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Bu öğrenci numarası zaten kayıtlı!");
                        return;
                    }
                }

                string checkPhone = "SELECT COUNT(*) FROM OGRENCILER WHERE Telefon = @telefon";
                using (SqlCommand cmdPhone = new SqlCommand(checkPhone, conn))
                {
                    cmdPhone.Parameters.AddWithValue("@telefon", txtTelefon.Text.Trim());
                    int count = (int)cmdPhone.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Bu telefon numarası zaten kayıtlı!");
                        return;
                    }
                }

                string checkTC = "SELECT COUNT(*) FROM OGRENCILER WHERE TC = @tc";
                using (SqlCommand cmdTC = new SqlCommand(checkTC, conn))
                {
                    cmdTC.Parameters.AddWithValue("@tc", txtTC.Text.Trim());
                    int count = (int)cmdTC.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Bu TC No zaten kayıtlı!");
                        return;
                    }
                }
            }

            DialogResult result = MessageBox.Show(
           $"{txtOgrNo.Text} numaralı {txtOgrAd.Text} {txtOgrSoyad.Text} adlı öğrenciyi sisteme eklemek istediğinize emin misiniz ?",
           "Confirmation",
           MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
  );

            if (result != DialogResult.Yes)
                return; // kullanıcı Hayır dedi, işlem iptal

            string queryAdd = "insert into OGRENCILER values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand komut = new SqlCommand(queryAdd, connection))
                {
                    connection.Open();



                    komut.Parameters.AddWithValue("@p1", txtOgrNo.Text);


                    komut.Parameters.AddWithValue("@p2", txtOgrAd.Text);


                    komut.Parameters.AddWithValue("@p3", txtOgrSoyad.Text);


                    komut.Parameters.AddWithValue("@p4", txtTC.Text);


                    komut.Parameters.AddWithValue("@p5", DateTime.Parse(dtpDogumTarihi.Text));


                    komut.Parameters.AddWithValue("@p6", cmbSinif.SelectedValue);

                    if (string.IsNullOrWhiteSpace(txtSifreHash.Text))
                        komut.Parameters.AddWithValue("@p7", DBNull.Value);
                    else
                        komut.Parameters.AddWithValue("@p7", txtSifreHash.Text);

                    if (string.IsNullOrWhiteSpace(txtEmail.Text))
                        komut.Parameters.AddWithValue("@p8", DBNull.Value);
                    else
                        komut.Parameters.AddWithValue("@p8", txtEmail.Text);

                    if (string.IsNullOrWhiteSpace(txtTelefon.Text))
                        komut.Parameters.AddWithValue("@p9", DBNull.Value);
                    else
                        komut.Parameters.AddWithValue("@p9", txtTelefon.Text);

                    komut.ExecuteNonQuery();
                }

                MessageBox.Show("Öğrenci ekleme başarılı.");
                LoadOgrenciler();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOgrNo.Text))
            {
                MessageBox.Show("Lütfen silinecek öğrencinin numarasını girin !");
                return;
            }

            if (!txtOgrNo.Text.All(char.IsDigit))
            {
                MessageBox.Show("Öğrenci numarası sadece rakamlardan oluşmalı !");
                return;
            }

            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                string checkSql = "SELECT COUNT(*) FROM OGRENCILER WHERE OgrNo=@OgrNo";

                using (SqlCommand cmdCheck = new SqlCommand(checkSql, connection))
                {
                    cmdCheck.Parameters.AddWithValue("@OgrNo", txtOgrNo.Text.Trim());
                    int count = (int)cmdCheck.ExecuteScalar();
                    if (count <= 0)
                    {
                        MessageBox.Show($"{txtOgrNo.Text} numaralı öğrenci sistemde kayıtlı değil. ");
                        return;
                    }
                }
            }



            DialogResult result = MessageBox.Show(
    $"{txtOgrNo.Text} numaralı öğrenciyi silmek istediğinize emin misiniz ?",
    "Confirmation",
    MessageBoxButtons.YesNo,
     MessageBoxIcon.Question
);

            if (result != DialogResult.Yes)
                return; // kullanıcı Hayır dedi, işlem iptal


            string queryDelete = "delete from OGRENCILER where OgrNo = @p1";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand komut = new SqlCommand(queryDelete, connection))
                {
                    connection.Open();
                    komut.Parameters.AddWithValue("@p1", txtOgrNo.Text);
                    komut.ExecuteNonQuery();
                }
                MessageBox.Show("Öğrenci silme işlemi başarılı.");
                LoadOgrenciler();
            }
        }

        private void dgvOgrenciler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOgrenciler.Rows[e.RowIndex];

                cmbSinif.SelectedValue = row.Cells["Sinif"].Value;

                txtOgrNo.Text = row.Cells["Numarası"].Value.ToString();
                txtOgrAd.Text = row.Cells["Adı"].Value.ToString();
                txtOgrSoyad.Text = row.Cells["Soyadı"].Value.ToString();
                txtTC.Text = row.Cells["TC"].Value.ToString();
                dtpDogumTarihi.Text = row.Cells["Doğum Tarihi"].Value.ToString();
                txtSifreHash.Text = row.Cells["Şifresi"].Value.ToString();
                txtEmail.Text = row.Cells["E-posta"].Value.ToString();
                txtTelefon.Text = row.Cells["Telefon"].Value.ToString();

                OgrenciResimGoster();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!kontrol()) return;
            if (!ValidateTCKimlik(txtTC.Text))
            {
                MessageBox.Show("Geçersiz TC NO !");
                return;
            }

            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                string checkSql = "SELECT COUNT(*) FROM OGRENCILER WHERE OgrNo=@OgrNo";

                using (SqlCommand cmdCheck = new SqlCommand(checkSql, connection))
                {
                    cmdCheck.Parameters.AddWithValue("@OgrNo", txtOgrNo.Text.Trim());
                    int count = (int)cmdCheck.ExecuteScalar();
                    if (count <= 0)
                    {
                        MessageBox.Show($"{txtOgrNo.Text} numaralı öğrenci sistemde kayıtlı değil. ");
                        return;
                    }
                }
            }

            DialogResult result = MessageBox.Show(
    "Öğrenciyi güncellemek istediğinize emin misiniz ?",
    "Confirmation",
    MessageBoxButtons.YesNo,
     MessageBoxIcon.Question
);

            if (result != DialogResult.Yes)
                return; // kullanıcı Hayır dedi, işlem iptal


            string queryUpdate = "update OGRENCILER set Ad = @p2 , Soyad = @p3 , TC = @p4 , DogumTarihi = @p5 , Sinif = @p6 , SifreHash = @p7 , Email = @p8 , Telefon = @p9 where OgrNo = @p1";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                // OgrNo benzersiz mi kontrol et
                string checkSql = "SELECT COUNT(*) FROM OGRENCILER WHERE OgrNo=@OgrNo";


                using (SqlCommand komut = new SqlCommand(queryUpdate, connection))
                {

                    komut.Parameters.AddWithValue("@p1", txtOgrNo.Text);


                    komut.Parameters.AddWithValue("@p2", txtOgrAd.Text);


                    komut.Parameters.AddWithValue("@p3", txtOgrSoyad.Text);


                    komut.Parameters.AddWithValue("@p4", txtTC.Text);


                    komut.Parameters.AddWithValue("@p5", DateTime.Parse(dtpDogumTarihi.Text));


                    komut.Parameters.AddWithValue("@p6", cmbSinif.SelectedValue);

                    if (string.IsNullOrWhiteSpace(txtSifreHash.Text))
                        komut.Parameters.AddWithValue("@p7", DBNull.Value);
                    else
                        komut.Parameters.AddWithValue("@p7", txtSifreHash.Text);

                    if (string.IsNullOrWhiteSpace(txtEmail.Text))
                        komut.Parameters.AddWithValue("@p8", DBNull.Value);
                    else
                        komut.Parameters.AddWithValue("@p8", txtEmail.Text);

                    if (string.IsNullOrWhiteSpace(txtTelefon.Text))
                        komut.Parameters.AddWithValue("@p9", DBNull.Value);
                    else
                        komut.Parameters.AddWithValue("@p9", txtTelefon.Text);

                    komut.ExecuteNonQuery();
                }

                MessageBox.Show("Öğrenci güncelleme başarılı.");
                LoadOgrenciler();

            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string query = "SELECT OgrNo as 'Numarası',Ad as 'Adı',Soyad as 'Soyadı',DogumTarihi as 'Doğum Tarihi',Tc,Sinif,SinifAd as 'Sınıfı',SifreHash as 'Şifresi',Email as 'E-posta',Telefon " +
                            "FROM OGRENCILER o JOIN SINIFLAR s ON o.Sinif = s.SinifID WHERE OgrNo LIKE @p1 or Ad LIKE @p1 or Soyad LIKE @p1 or TC LIKE @p1 OR REPLACE(CONVERT(VARCHAR(10),DogumTarihi, 104), '.', '')  LIKE @p1 OR CONVERT(VARCHAR(10), DogumTarihi, 104) LIKE @p1 or SinifAd LIKE @p1 OR SifreHash LIKE @p1 OR Email like @p1 or Telefon like @p1";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@p1", "%" + txtFilter.Text + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvOgrenciler.DataSource = dt;
                }
            }
        }

        private void txtOgrNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (txtOgrNo.Text.Length >= 4) e.Handled = true;

        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (txtTC.Text.Length >= 11) e.Handled = true;


        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (txtTelefon.Text.Length >= 13) e.Handled = true;

        }

        private bool ValidateTCKimlik(string tck)
        {
            // Uzunluk ve sadece rakam kontrolü
            if (tck.Length != 11 || !tck.All(char.IsDigit))
                return false;

            int[] digits = tck.Select(c => int.Parse(c.ToString())).ToArray();

            // İlk hane 0 olamaz
            if (digits[0] == 0)
                return false;

            // 10. hane kontrolü
            int oddSum = digits[0] + digits[2] + digits[4] + digits[6] + digits[8];  // 1.,3.,5.,7.,9.
            int evenSum = digits[1] + digits[3] + digits[5] + digits[7];             // 2.,4.,6.,8.

            int digit10 = ((oddSum * 7) - evenSum) % 10;
            if (digits[9] != digit10)
                return false;

            // 11. hane kontrolü
            int digit11 = digits.Take(10).Sum() % 10;
            if (digits[10] != digit11)
                return false;

            return true; // tüm kurallardan geçti
        }
        // Byte[] → Image
        private Image ByteToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        // Image → Byte[]
        private byte[] ImageToByte(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void OgrenciResimGoster()
        {
            byte[] resimData = null;

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                string query = "SELECT FotoData FROM FOTOGRAFLAR WHERE OgrNo = @ogrno";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ogrno", txtOgrNo.Text);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                        resimData = (byte[])result;
                }
            }

            if (resimData != null && resimData.Length > 0)
                pbFotograf.Image = ByteToImage(resimData);
            else
                pbFotograf.Image = Properties.Resources.no_photo; // Resources içinde default resim


        }


        private void btnFotoYukle_Click(object sender, EventArgs e)
        {
            if (dgvOgrenciler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Önce bir öğrenci seçin!");
                return;
            }

            string ogrNo = dgvOgrenciler.SelectedRows[0].Cells["Numarası"].Value.ToString();

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Öğrenci Resmi Seç";
                ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Image secilenResim = Image.FromFile(ofd.FileName);
                    
                    byte[] resimData = ImageToByte(secilenResim);



                    using (SqlConnection conn = new SqlConnection(conString))
                    {
                        conn.Open();

                        // 1-1 ilişki kontrolü
                        string checkSql = "SELECT COUNT(*) FROM FOTOGRAFLAR WHERE OgrNo = @ogrno";
                        int count;
                        using (SqlCommand cmd = new SqlCommand(checkSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@ogrno", ogrNo);
                            count = (int)cmd.ExecuteScalar();
                            
                        }

                        
                        if (count > 0)
                        {
                            DialogResult result = MessageBox.Show(
   "Öğrencinin fotoğrafını güncellemek istediğinize emin misiniz ?",
   "Confirmation",
   MessageBoxButtons.YesNo,
    MessageBoxIcon.Question
);

                            // Güncelle
                            string updateSql = "UPDATE FOTOGRAFLAR SET FotoData=@resim WHERE OgrNo=@ogrno";
                            using (SqlCommand cmd = new SqlCommand(updateSql, conn))
                            {
                                cmd.Parameters.AddWithValue("@resim", resimData);
                                cmd.Parameters.AddWithValue("@ogrno", ogrNo);
                                cmd.ExecuteNonQuery();

                            }
                            pbFotograf.Image = secilenResim;
                            MessageBox.Show("Resim başarıyla güncellendi.");
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show(
   "Seçtiğiniz fotoğrafı yüklemek istediğinize emin misiniz ?",
   "Confirmation",
   MessageBoxButtons.YesNo,
    MessageBoxIcon.Question
);

                            // Ekle
                            string insertSql = "INSERT INTO FOTOGRAFLAR (OgrNo, FotoData) VALUES (@ogrno, @resim)";
                            using (SqlCommand cmd = new SqlCommand(insertSql, conn))
                            {
                                cmd.Parameters.AddWithValue("@ogrno", ogrNo);
                                cmd.Parameters.AddWithValue("@resim", resimData);
                                cmd.ExecuteNonQuery();
                            }
                            pbFotograf.Image = secilenResim;
                            MessageBox.Show("Resim başarıyla yüklendi.");
                        }
                    }
                    
                }
            }
        }

        private void btnFotoSil_Click(object sender, EventArgs e)
        {
            string ogrNo = txtOgrNo.Text;

            if (dgvOgrenciler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Önce bir öğrenci seçin!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();

                // 1-1 ilişki kontrolü
                string checkSql = "SELECT COUNT(*) FROM FOTOGRAFLAR WHERE OgrNo = @ogrno";
                int count;
                using (SqlCommand cmd = new SqlCommand(checkSql, conn))
                {
                    cmd.Parameters.AddWithValue("@ogrno", ogrNo);
                    count = (int)cmd.ExecuteScalar();
                }

                if (count > 0)
                {
                    DialogResult result = MessageBox.Show(
"Fotoğrafı silmek istediğinize emin misiniz ?",
"Confirmation",
MessageBoxButtons.YesNo,
MessageBoxIcon.Question
);

                    // Güncelle
                    string updateSql = "DELETE FROM FOTOGRAFLAR WHERE OgrNo=@ogrno";
                    using (SqlCommand cmd = new SqlCommand(updateSql, conn))
                    {
                       
                        cmd.Parameters.AddWithValue("@ogrno", ogrNo);
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Seçtiğiniz öğrencinin zaten fotoğrafı yok !");
                    return;
                }
            }

            pbFotograf.Image = Properties.Resources.no_photo;
            MessageBox.Show("Öğrencinin fotoğrafı başarıyla silindi !");
           
        }
    }
}

