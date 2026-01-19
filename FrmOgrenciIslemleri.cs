using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Öğrenci_Not_Kayıt_Sistemi
{
    public partial class FrmOgrenciIslemleri : Form
    {
        private string conString = "Server=AKALI;Database=OgrenciNotKayitSistemi;Trusted_Connection=True;TrustServerCertificate=True;";

        public FrmOgrenciIslemleri()
        {
            InitializeComponent();
        }


        private void FrmOgrenciListe_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.TabStop = true;
                else
                    c.TabStop = false;
            }

            LoadOgrenciler();
            pbFotograf.Image = Properties.Resources.no_photo; // Resources içinde default resim
            dgvOgrenciler.ClearSelection();
        }

        private void LoadOgrenciler()
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                string sql = "SELECT OgrNo as 'Numarası',Ad as 'Adı',Soyad as 'Soyadı',DogumTarihi as 'Doğum Tarihi',Tc,o.OkulID,OkulAd as 'Okulu',Sinif,SinifAd as 'Sınıfı',Email as 'E-posta',Telefon " +
                               " FROM OGRENCILER o" +
                               " JOIN OKULLAR_SINIFLAR os on os.OkulID = o.OkulID and os.SinifID = o.Sinif" +
                               " JOIN OKULLAR ok on ok.OkulID = os.OkulID" +
                               " JOIN SINIFLAR s on s.SinifID = os.SinifID" +
                               " ORDER BY o.OgrNo";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOgrenciler.DataSource = dt;

                dgvOgrenciler.Columns["Sinif"].Visible = false;
                dgvOgrenciler.Columns["OkulID"].Visible = false;

                string okullar = @"SELECT OkulID,OkulAd from Okullar ORDER BY OkulAd";
                SqlDataAdapter daOkul = new SqlDataAdapter(okullar, conn);
                SqlDataAdapter daGuncelOkul = new SqlDataAdapter(okullar, conn);
                DataTable dtOkul = new DataTable();
                DataTable dtGuncelOkul = new DataTable();
                daOkul.Fill(dtOkul);
                daGuncelOkul.Fill(dtGuncelOkul);

                cmbOkulu.ValueMember = "OkulID";
                cmbOkulu.DisplayMember = "OkulAd";
                cmbOkulu.DataSource = dtOkul;

                cmbGuncelOkul.ValueMember = "OkulID";
                cmbGuncelOkul.DisplayMember = "OkulAd";
                cmbGuncelOkul.DataSource = dtGuncelOkul;

            }
        }

        private void LoadOkullar()
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                string sql = "SELECT OgrNo as 'Numarası',Ad as 'Adı',Soyad as 'Soyadı',DogumTarihi as 'Doğum Tarihi',Tc,o.OkulID,OkulAd as 'Okulu',Sinif,SinifAd as 'Sınıfı',Email as 'E-posta',Telefon " +
                               " FROM OGRENCILER o" +
                               " JOIN OKULLAR_SINIFLAR os on os.OkulID = o.OkulID and os.SinifID = o.Sinif" +
                               " JOIN OKULLAR ok on ok.OkulID = os.OkulID" +
                               " JOIN SINIFLAR s on s.SinifID = os.SinifID" +
                               " ORDER BY o.OgrNo";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOgrenciler.DataSource = dt;

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

            if (!cmbSinif.Enabled || cmbSinif.SelectedValue == null)
            {
                MessageBox.Show("Bu okulda sınıf bulunmadığı için öğrenci eklenemez.");
                return false;
            }


            return true; // tüm kontroller geçti
        }

        private bool benzerKayitKontrol()
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();

                // OgrNo benzersiz mi kontrol et
                string checkSql = "SELECT COUNT(*) FROM OGRENCILER WHERE OgrNo=@OgrNo AND OkulID = @o";
                using (SqlCommand cmdCheck = new SqlCommand(checkSql, conn))
                {
                    cmdCheck.Parameters.AddWithValue("@OgrNo", txtOgrNo.Text.Trim());
                    cmdCheck.Parameters.AddWithValue("@o", cmbOkulu.SelectedValue);

                    int count = (int)cmdCheck.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show($"{cmbOkulu.Text}'nde zaten {txtOgrNo.Text} numaralı öğrenci mevcut!");
                        return false;
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
                        return false;
                    }
                }

                string checkPhone = "SELECT COUNT(*) FROM OGRENCILER WHERE Telefon = @telefon";
                using (SqlCommand cmdPhone = new SqlCommand(checkPhone, conn))
                {
                    cmdPhone.Parameters.AddWithValue("@telefon", txtTelefon.Text.Trim());
                    int count = (int)cmdPhone.ExecuteScalar();
                    if (count > 0 && !string.IsNullOrWhiteSpace(txtTelefon.Text.Trim()))
                    {
                        MessageBox.Show("Bu telefon numarası zaten kayıtlı!");
                        return false;
                    }
                }


                string checkEmail = "SELECT COUNT(*) FROM OGRENCILER WHERE Email = @email";
                using (SqlCommand cmdEmail = new SqlCommand(checkEmail, conn))
                {
                    cmdEmail.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    int count = (int)cmdEmail.ExecuteScalar();
                    if (count > 0 && !string.IsNullOrWhiteSpace(txtEmail.Text.Trim()))
                    {
                        MessageBox.Show("Bu e-posta zaten kayıtlı!");
                        return false;
                    }
                }
            }
            return true;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!kontrol()) return;
            if (!ValidateTCKimlik(txtTC.Text))
            {
                MessageBox.Show("Geçersiz TC NO !");
                return;
            }
            if (!benzerKayitKontrol()) return;

            DialogResult result = MessageBox.Show(
           $"{txtOgrNo.Text} numaralı {txtOgrAd.Text} {txtOgrSoyad.Text} adlı öğrenciyi {cmbOkulu.Text}'ndaki {cmbSinif.Text} sınıfına eklemek istediğinize emin misiniz ?",
           "Onay",
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



                    komut.Parameters.AddWithValue("@p1", txtTC.Text);

                    komut.Parameters.AddWithValue("@p2", txtOgrNo.Text);


                    komut.Parameters.AddWithValue("@p3", txtOgrAd.Text);


                    komut.Parameters.AddWithValue("@p4", txtOgrSoyad.Text);



                    komut.Parameters.AddWithValue("@p5", DateTime.Parse(dtpDogumTarihi.Text));

                    komut.Parameters.AddWithValue("@p6", cmbOkulu.SelectedValue);

                    komut.Parameters.AddWithValue("@p7", cmbSinif.SelectedValue);



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

                foreach (DataGridViewRow row in dgvOgrenciler.Rows)
                {
                    if (row.Cells["Numarası"].Value.ToString() == txtOgrNo.Text)
                    {
                        dgvOgrenciler.ClearSelection();
                        row.Selected = true;
                        dgvOgrenciler.CurrentCell = row.Cells[0]; // odaklama
                        dgvOgrenciler_CellClick(dgvOgrenciler, new DataGridViewCellEventArgs(0, row.Index));
                        break;
                    }
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOgrenciler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğniniz öğrencyi tablodan seçin!");
                return;
            }

            int deletedRowIndex = dgvOgrenciler.SelectedRows[0].Index;

            string adsoyad = dgvOgrenciler.SelectedRows[0].Cells["Adı"].Value.ToString() + " " + dgvOgrenciler.SelectedRows[0].Cells["Soyadı"].Value.ToString();
            string okul = (dgvOgrenciler.SelectedRows[0].Cells["Okulu"].Value).ToString();
            string ogrno = (dgvOgrenciler.SelectedRows[0].Cells["Numarası"].Value).ToString();
            string tc = dgvOgrenciler.SelectedRows[0].Cells["Tc"].Value.ToString();

            DialogResult result = MessageBox.Show(
    $"{okul}'ndeki {ogrno} okul numaralı ve {adsoyad} isimli öğrenciyi silmek istediğinize emin misiniz ?",
    "Confirmation",
    MessageBoxButtons.YesNo,
     MessageBoxIcon.Question
);

            if (result != DialogResult.Yes)
                return; // kullanıcı Hayır dedi, işlem iptal

            string queryNotlar = "delete from NOTLAR where OgrenciTC = @ogrtc";
            string queryDelete = "delete from OGRENCILER where TC = @TC";
            string queryFotoDelete = "delete from FOTOGRAFLAR where TC = @TC";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                using (SqlCommand komut = new SqlCommand(queryNotlar, connection))
                {

                    komut.Parameters.AddWithValue("@ogrtc", tc);
                    komut.ExecuteNonQuery();
                }

                using (SqlCommand komut = new SqlCommand(queryFotoDelete, connection))
                {

                    komut.Parameters.AddWithValue("@TC", tc);
                    komut.ExecuteNonQuery();
                }

                using (SqlCommand komut = new SqlCommand(queryDelete, connection))
                {


                    komut.Parameters.AddWithValue("@TC", tc);
                    komut.ExecuteNonQuery();
                }
                MessageBox.Show("Öğrenci silme işlemi başarılı.");
                LoadOgrenciler();

                int rowCount = dgvOgrenciler.Rows.Count;
                if (rowCount > 0)
                {
                    int newIndex = deletedRowIndex < rowCount ? deletedRowIndex : rowCount - 1;
                    dgvOgrenciler.ClearSelection();
                    dgvOgrenciler.Rows[newIndex].Selected = true;
                    dgvOgrenciler.CurrentCell = dgvOgrenciler.Rows[newIndex].Cells[0];
                    dgvOgrenciler_CellClick(dgvOgrenciler, new DataGridViewCellEventArgs(0, newIndex));
                }
                else
                {
                    // Tablo boşsa textboxları temizle
                    txtGuncelOgrNo.Clear();
                    txtGuncelSifre.Clear();
                    txtGuncelEmail.Clear();
                    txtGuncelTelefon.Clear();
                    pbFotograf.Image = Properties.Resources.no_photo;
                }
            }

        }

        private void dgvOgrenciler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOgrenciler.Rows[e.RowIndex];

                cmbGuncelOkul.SelectedValue = row.Cells["OkulID"].Value;
                cmbGuncelSinif.SelectedValue = row.Cells["Sinif"].Value;

                txtGuncelOgrNo.Text = row.Cells["Numarası"].Value.ToString();

                txtGuncelEmail.Text = row.Cells["E-posta"].Value.ToString();
                txtGuncelTelefon.Text = row.Cells["Telefon"].Value.ToString();

                OgrenciResimGoster();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (dgvOgrenciler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz öğrencyi tablodan seçin!");
                return;
            }
            string adsoyad = dgvOgrenciler.SelectedRows[0].Cells["Adı"].Value.ToString().Trim() + " " + dgvOgrenciler.SelectedRows[0].Cells["Soyadı"].Value.ToString().Trim();
            string okul = dgvOgrenciler.SelectedRows[0].Cells["Okulu"].Value.ToString().Trim();
            string ogrno = dgvOgrenciler.SelectedRows[0].Cells["Numarası"].Value.ToString().Trim();
            string tc = dgvOgrenciler.SelectedRows[0].Cells["Tc"].Value.ToString().Trim();

            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                // OgrNo benzersiz mi kontrol et
                string checkSql = "SELECT COUNT(*) FROM OGRENCILER WHERE TC <> @TC AND OgrNo = @OgrNo AND OkulID = @o";
                using (SqlCommand cmdCheck = new SqlCommand(checkSql, connection))
                {
                    cmdCheck.Parameters.AddWithValue("@OgrNo", txtGuncelOgrNo.Text);
                    cmdCheck.Parameters.AddWithValue("@o", cmbGuncelOkul.SelectedValue);
                    cmdCheck.Parameters.AddWithValue("@TC", tc);

                    int count = (int)cmdCheck.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show($"{cmbGuncelOkul.Text}'nde zaten {txtGuncelOgrNo.Text} numaralı öğrenci mevcut!");
                        return;
                    }
                }

                string checkPhone = "SELECT COUNT(*) FROM OGRENCILER WHERE TC <> @TC AND Telefon = @telefon";
                using (SqlCommand cmdPhone = new SqlCommand(checkPhone, connection))
                {
                    cmdPhone.Parameters.AddWithValue("@telefon", txtGuncelTelefon.Text.Trim());
                    cmdPhone.Parameters.AddWithValue("@TC", tc);

                    int count = (int)cmdPhone.ExecuteScalar();
                    if (count > 0 && !string.IsNullOrWhiteSpace(txtTelefon.Text.Trim()))
                    {
                        MessageBox.Show("Bu telefon numarası sistemde zaten kayıtlı!");
                        return;
                    }
                }


                string checkEmail = "SELECT COUNT(*) FROM OGRENCILER WHERE TC <> @TC AND Email = @email";
                using (SqlCommand cmdEmail = new SqlCommand(checkEmail, connection))
                {
                    cmdEmail.Parameters.AddWithValue("@email", txtGuncelEmail.Text.Trim());
                    cmdEmail.Parameters.AddWithValue("@TC", tc);
                    int count = (int)cmdEmail.ExecuteScalar();
                    if (count > 0 && !string.IsNullOrWhiteSpace(txtEmail.Text.Trim()))
                    {
                        MessageBox.Show("Bu e-posta sistemde zaten kayıtlı!");
                        return;
                    }
                }
            }


            DialogResult result = MessageBox.Show(
                $"{okul}'ndeki {ogrno} okul numaralı {adsoyad} isimli öğrenciyi güncellemek istediğinize emin misiniz ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);


            if (result != DialogResult.Yes)
                return; // kullanıcı Hayır dedi, işlem iptal


            string queryUpdate = @"update OGRENCILER set OgrNo =  @ogrno , OkulID = @okul, Sinif = @sinif , Email = @email , Telefon = @telefon  where  TC = @TC";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                using (SqlCommand komut = new SqlCommand(queryUpdate, connection))
                {

                    komut.Parameters.AddWithValue("@TC", dgvOgrenciler.SelectedRows[0].Cells["Tc"].Value.ToString());

                    komut.Parameters.AddWithValue("@okul", cmbGuncelOkul.SelectedValue);

                    komut.Parameters.AddWithValue("@sinif", cmbGuncelSinif.SelectedValue);


                    if (string.IsNullOrWhiteSpace(txtGuncelTelefon.Text))
                        komut.Parameters.AddWithValue("@telefon", DBNull.Value);
                    else
                        komut.Parameters.AddWithValue("@telefon", txtGuncelTelefon.Text);


                    if (string.IsNullOrWhiteSpace(txtGuncelEmail.Text))
                        komut.Parameters.AddWithValue("@email", DBNull.Value);
                    else
                        komut.Parameters.AddWithValue("@email", txtGuncelEmail.Text);

                    if (string.IsNullOrWhiteSpace(txtGuncelOgrNo.Text))
                        komut.Parameters.AddWithValue("@ogrno", DBNull.Value);
                    else
                        komut.Parameters.AddWithValue("@ogrno", txtGuncelOgrNo.Text);

                    komut.ExecuteNonQuery();

                }

                MessageBox.Show("Öğrenci güncelleme başarılı.");
                LoadOkullar();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string query = "SELECT o.OkulID,Sinif,OgrNo as 'Numarası',Ad as 'Adı',Soyad as 'Soyadı',DogumTarihi as 'Doğum Tarihi',Tc,OkulAd as 'Okulu',SinifAd as 'Sınıfı',Email as 'E-posta',Telefon " +
                               "FROM OGRENCILER o JOIN OKULLAR_SINIFLAR os on os.SinifID = o.Sinif and os.OkulID = o.OkulID join SINIFLAR s on os.SinifID = s.SinifID join OKULLAR ok on ok.OkulID = os.OkulID WHERE OgrNo LIKE @p1 or Ad LIKE @p1 or Soyad LIKE @p1 or TC LIKE @p1 OR REPLACE(CONVERT(VARCHAR(10),DogumTarihi, 104), '.', '')  LIKE @p1 OR CONVERT(VARCHAR(10), DogumTarihi, 104) LIKE @p1 or SinifAd LIKE @p1 OR Email like @p1 or Telefon like @p1 or OkulAd like @p1";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@p1", "%" + txtFilter.Text + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvOgrenciler.DataSource = dt;

                    dgvOgrenciler.Columns["OkulID"].Visible = false;
                    dgvOgrenciler.Columns["Sinif"].Visible = false;

                }
            }
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
            string tc = dgvOgrenciler.SelectedRows[0].Cells["Tc"].Value.ToString().Trim();

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                string query = "SELECT FotoData FROM FOTOGRAFLAR WHERE TC = @TC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TC", tc);
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

            string tc = dgvOgrenciler.SelectedRows[0].Cells["Tc"].Value.ToString();

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

                        string checkResim = "SELECT COUNT(*) FROM FOTOGRAFLAR WHERE TC <> @TC AND FotoData = @resim";
                        using (SqlCommand cmdResim = new SqlCommand(checkResim, conn))
                        {
                            cmdResim.Parameters.AddWithValue("@resim", resimData);
                            cmdResim.Parameters.AddWithValue("@TC", tc);

                            int cnt = (int)cmdResim.ExecuteScalar();
                            if (cnt > 0)
                            {
                                MessageBox.Show("Bu fotoğraf başka bir öğrenciye ait!");
                                return;
                            }
                        }

                        // 1-1 ilişki kontrolü
                        string checkSql = "SELECT COUNT(*) FROM FOTOGRAFLAR WHERE TC = @TC";
                        int count;
                        using (SqlCommand cmd = new SqlCommand(checkSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@TC", tc);
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
                            if (result != DialogResult.Yes) return;

                            // Güncelle
                            string updateSql = "UPDATE FOTOGRAFLAR SET FotoData=@resim WHERE TC=@TC";
                            using (SqlCommand cmd = new SqlCommand(updateSql, conn))
                            {
                                cmd.Parameters.AddWithValue("@resim", resimData);
                                cmd.Parameters.AddWithValue("@TC", tc);
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
                            if (result != DialogResult.Yes) return;
                            // Ekle
                            string insertSql = "INSERT INTO FOTOGRAFLAR (TC, FotoData) VALUES (@TC, @resim)";
                            using (SqlCommand cmd = new SqlCommand(insertSql, conn))
                            {
                                cmd.Parameters.AddWithValue("@TC", tc);
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
            if (dgvOgrenciler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Önce bir öğrenci seçin!");
                return;
            }

            string tc = dgvOgrenciler.SelectedRows[0].Cells["Tc"].Value.ToString();

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();

                // 1-1 ilişki kontrolü
                string checkSql = "SELECT COUNT(*) FROM FOTOGRAFLAR WHERE TC = @TC";
                int count;
                using (SqlCommand cmd = new SqlCommand(checkSql, conn))
                {
                    cmd.Parameters.AddWithValue("@TC", tc);
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
                    if (result != DialogResult.Yes) return;
                    // Güncelle
                    string updateSql = "DELETE FROM FOTOGRAFLAR WHERE TC=@TC";
                    using (SqlCommand cmd = new SqlCommand(updateSql, conn))
                    {

                        cmd.Parameters.AddWithValue("@TC", tc);
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

        private void cmbOkulu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOkulu.SelectedValue == null || cmbOkulu.SelectedValue is DataRowView)
                return;

            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                string sql = @"SELECT OS.SinifID, SinifAd
                       FROM SINIFLAR S
                       JOIN OKULLAR_SINIFLAR OS ON OS.SinifID = S.SinifID
                       WHERE OS.OkulID = @o";

                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@o", cmbOkulu.SelectedValue);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbSinif.DataSource = null;   // 🔴 ÖNEMLİ
                cmbSinif.Items.Clear();       // 🔴 ÖNEMLİ

                if (dt.Rows.Count == 0)
                {
                    cmbSinif.Text = "Bu okulda sınıf yok";
                    cmbSinif.Enabled = false;
                }
                else
                {
                    cmbSinif.Enabled = true;
                    cmbSinif.ValueMember = "SinifID";
                    cmbSinif.DisplayMember = "SinifAd";
                    cmbSinif.DataSource = dt;
                    cmbSinif.SelectedIndex = -1; // 🔴 varsayılan seçimi iptal
                }
            }
        }


        private void cmbGuncelOkul_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbGuncelOkul.SelectedValue == null || cmbGuncelOkul.SelectedValue is DataRowView) return;

            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();


                string sql1 = @"SELECT OS.SinifID,SinifAd from SINIFLAR S JOIN OKULLAR_SINIFLAR OS ON OS.SinifID = S.SinifID where OkulID = @o";
                SqlCommand cmd1 = new SqlCommand(sql1, connection);
                cmd1.Parameters.AddWithValue("@o", Convert.ToInt32(cmbGuncelOkul.SelectedValue));
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);


                cmbGuncelSinif.ValueMember = "SinifID";
                cmbGuncelSinif.DisplayMember = "SinifAd";
                cmbGuncelSinif.DataSource = dt1;

                cmbGuncelSinif.DataSource = null;
                cmbGuncelSinif.Items.Clear();

                if (dt1.Rows.Count == 0)
                {
                    cmbGuncelSinif.Text = "Bu okulda sınıf yok";
                    cmbGuncelSinif.Enabled = false;
                }
                else
                {
                    cmbGuncelSinif.Enabled = true;
                    cmbGuncelSinif.ValueMember = "SinifID";
                    cmbGuncelSinif.DisplayMember = "SinifAd";
                    cmbGuncelSinif.DataSource = dt1;
                    cmbGuncelSinif.SelectedIndex = -1;
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
        private void txtGuncelTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsControl(e.KeyChar)) return;
            if (txtGuncelTelefon.Text.Length >= 13) e.Handled = true;

        }

        private void txtGuncelOgrNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (txtGuncelOgrNo.Text.Length >= 4) e.Handled = true;
        }

        private void btnAktiflikKaydet_Click(object sender, EventArgs e)
        {

        }
    }
}
    
