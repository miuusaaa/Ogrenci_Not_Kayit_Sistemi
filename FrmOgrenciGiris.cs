using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // MemoryStream için
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Öğrenci_Not_Kayıt_Sistemi
{
    public partial class FrmOgrenciGiris : Form
    {

        public FrmOgrenciGiris()
        {
            InitializeComponent();
        }

        public static string con = "Server=AKALI;Database=OgrenciNotKayitSistemi;Trusted_Connection=True;TrustServerCertificate=True;";
        private bool girisTamamlandi = false;
        private int denemeSayisigiris = 0;
        private int denemeSayisiresim = 0;
        private System.Windows.Forms.Timer kilitTimer = new System.Windows.Forms.Timer();
        private int kilitSayac = 0;
        private string tc;

        // Seçilen resmin doğru/yanlış bilgisini tutmak için
        private Dictionary<RadioButton, bool> secenekler = new Dictionary<RadioButton, bool>();

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

        private void btnGiris_Click(object sender, EventArgs e)
        {
            tc = txtTC.Text;
            string okulno = txtOkulNo.Text;


            if (string.IsNullOrWhiteSpace(tc) || string.IsNullOrWhiteSpace(okulno))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun !");
                return;
            }

            if (!okulno.All(char.IsDigit))
            {
                MessageBox.Show("Öğrenci numarası sadece rakamlardan oluşmalı !");
                return;
            }

            //if (!ValidateTCKimlik(tc))
            //{
            //    MessageBox.Show("Geçersiz T.C. Kimlik Numarası!");
            //    return;
            //}

            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                string query = "SELECT * from OGRGIRISBILGILERI WHERE OGRNO =@okulno and tckimlikno =@tc";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@okulno", okulno);
                cmd.Parameters.AddWithValue("@tc", tc);

                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.Read())
                {
                    bool aktifMi = dr["Aktiflik"] != DBNull.Value && Convert.ToBoolean(dr["Aktiflik"]);

                    if (!aktifMi)
                    {
                        MessageBox.Show(
                            "Bu hesap pasif durumda olduğu için şu anda sisteme giriş yapılamıyor.\nLütfen yönetici ile iletişime geçin."
                        );
                        return;
                    }

                    girisTamamlandi = true;

                    btnDevam.Visible = true;

                    btnGiris.Enabled = false;
                    txtTC.Enabled = false;
                    txtOkulNo.Enabled = false;

                    lblResimSec.Visible = true;
                    panel1.Visible = true;
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    radioButton3.Visible = true;
                    radioButton4.Visible = true;


                    this.Width = 1116;
                    this.Height = 850;
                    ResimleriGetir(tc);
                }

                else
                {
                    denemeSayisigiris++;

                    if (denemeSayisigiris >= 3)
                    {
                        MessageBox.Show("3 kez yanlış giriş yaptınız. 10 saniye bekleyiniz.");

                        btnGiris.Enabled = false;
                        btnGeri.Enabled = false;
                        txtTC.Enabled = false;
                        txtOkulNo.Enabled = false;

                        kilitSayac = 10;
                        kilitTimer.Start();

                        denemeSayisigiris = 0;
                        return;
                    }
                    MessageBox.Show("Böyle bir öğrenci bulunamadı.");
                }
            }
        }

        private void FrmOgrenciGiris_Load(object sender, EventArgs e)
        {
            kilitTimer.Interval = 1000; // 1 saniye
            kilitTimer.Tick += KilitTimer_Tick;

            this.FormBorderStyle = FormBorderStyle.FixedSingle; //formu kullanıcı büyütmesin istiyorsan kullan.

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.TabStop = true;
                else
                    c.TabStop = false;
            }

            lblResimSec.Visible = false;
            panel1.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            btnDevam.Visible = false;

            this.Width = 816;
            this.Height = 489;

        }

        private void ResimleriGetir(string tc)
        {
            List<(byte[] Resim, bool DogruMu)> resimler = new List<(byte[], bool)>();

            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();

                string query = @"
SELECT *
FROM
(
    SELECT FotoData AS Resim, 1 AS DogruMu
    FROM FOTOGRAFLAR
    WHERE TC = @tc

    UNION ALL

    SELECT TOP 3 Resim, 0 AS DogruMu
    FROM YANLIS_RESIMLER
ORDER BY NEWID()
) AS X
ORDER BY NEWID();
";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            byte[] resim = (byte[])dr["Resim"];
                            bool dogruMu = Convert.ToBoolean(dr["DogruMu"]);

                            resimler.Add((resim, dogruMu));
                        }
                    }
                }
            }

            if (resimler.Count != 4)
            {
                MessageBox.Show("Resimler yüklenemedi. Yeterli veri yok.");
                return;
            }

            Random rnd = new Random();
            var karisik = resimler.OrderBy(x => rnd.Next()).ToList();

            PictureBox[] boxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };
            RadioButton[] radios = { radioButton1, radioButton2, radioButton3, radioButton4 };

            secenekler.Clear();

            for (int i = 0; i < 4; i++)
            {
                using (MemoryStream ms = new MemoryStream(karisik[i].Resim))
                {
                    boxes[i].Image = Image.FromStream(ms);
                }

                secenekler[radios[i]] = karisik[i].DogruMu;
            }
        }
        private void btnDevam_Click(object sender, EventArgs e)
        {
            tc = txtTC.Text;

            RadioButton[] radios = { radioButton1, radioButton2, radioButton3, radioButton4 };
            RadioButton secilen = radios.FirstOrDefault(r => r.Checked);

            if (secilen == null)
            {
                MessageBox.Show("Lütfen bir resim seçiniz!");
                return;
            }

            bool dogruMu = secenekler[secilen];

            if (dogruMu)
            {
                MessageBox.Show("Giriş Başarılı!");
                FrmOgrenci frm = new FrmOgrenci(tc);
                frm.Show();
                this.Hide();

            }
            else
            {
                denemeSayisiresim++;

                if (denemeSayisiresim >= 3)
                {
                    MessageBox.Show("3 kez yanlış resim seçtiniz. 10 saniye kilitlendi.");

                    txtTC.Enabled = false;
                    txtOkulNo.Enabled = false;
                    btnDevam.Enabled = false;
                    btnGeri.Enabled = false;
                    btnGiris.Enabled = false;

                    girisTamamlandi = false;

                    lblResimSec.Visible = false;
                    panel1.Visible = false;
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    radioButton1.Visible = false;
                    radioButton2.Visible = false;
                    radioButton3.Visible = false;
                    radioButton4.Visible = false;


                    this.Width = 816;
                    this.Height = 489;

                    txtTC.Clear();
                    txtOkulNo.Clear();
                    kilitSayac = 10;
                    kilitTimer.Start();

                    denemeSayisiresim = 0;
                    denemeSayisigiris = 0;
                    return;
                }


                MessageBox.Show("Yanlış seçim,Resimler yenileniyor.Tekrar deneyiniz.");

                // Seçimleri sıfırla
                foreach (var r in radios)
                    r.Checked = false;

                // Resimleri yeniden yükle
                ResimleriGetir(txtTC.Text);
            }
        }


        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (!girisTamamlandi)
            {
                Anasayfa frm = new Anasayfa();
                this.Hide();
                frm.Show();
            }
            else
            {
                girisTamamlandi = false;

                lblResimSec.Visible = false;
                panel1.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                btnDevam.Visible = false;

                btnGiris.Enabled = true;
                txtOkulNo.Enabled = true;
                txtTC.Enabled = true;

                this.Width = 816;
                this.Height = 489;

                txtTC.Clear();
                txtOkulNo.Clear();
            }
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }


            if (char.IsDigit(e.KeyChar) && txtTC.Text.Length >= 11)
            {
                e.Handled = true;
            }
        }

        private void txtOkulNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }


            if (char.IsDigit(e.KeyChar) && txtOkulNo.Text.Length >= 4)
            {
                e.Handled = true;
            }
        }

        private void KilitTimer_Tick(object sender, EventArgs e)
        {
            kilitSayac--;

            if (kilitSayac <= 0)
            {
                kilitTimer.Stop();

                btnGiris.Enabled = true;
                btnDevam.Enabled = true;
                btnGeri.Enabled = true;
                txtTC.Enabled = true;
                txtOkulNo.Enabled = true;

                MessageBox.Show("Giriş tekrar aktif edildi.");
            }
        }

    }
}
