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
            string tc = txtTC.Text;
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

            if (!ValidateTCKimlik(tc))
            {
                MessageBox.Show("Geçersiz T.C. Kimlik Numarası!");
                return;
            }

            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                string query = "SELECT * from OGRGIRISBILGILERI WHERE OGRNO =@okulno and tckimlikno =@tc";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@okulno", okulno);
                cmd.Parameters.AddWithValue("@tc", tc);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    girisTamamlandi = true;

                    txtTC.Enabled = false;
                    txtOkulNo.Enabled = false;
                    btnGiris.Enabled = false;

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
                    btnDevam.Visible = true;

                    this.Width = 872;
                    this.Height = 674;
                    ResimleriGetir(okulno);
                }
                else
                {
                    MessageBox.Show("Böyle bir öğrenci bulunamadı");
                    return;
                }
            }
        }

        private void FrmOgrenciGiris_Load(object sender, EventArgs e)
        {

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

        private void ResimleriGetir(string okulno)
        {
            List<(byte[] Resim, bool DogruMu)> resimler = new List<(byte[], bool)>();

            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                string query = "SELECT Resim, DogruMu FROM Resimler WHERE okulno=@okulno";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@okulno", okulno);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            byte[] resim = (byte[])dr["Resim"];
                            bool dogruMu = (bool)dr["DogruMu"];
                            resimler.Add((resim, dogruMu));
                        }
                    }
                }
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

                // Her RadioButton ile doğru/yanlış bilgisini eşleştir
                secenekler[radios[i]] = karisik[i].DogruMu;
            }
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            string okulno = txtOkulNo.Text;

            RadioButton[] radios = { radioButton1, radioButton2, radioButton3, radioButton4 };
            RadioButton secilen = radios.FirstOrDefault(r => r.Checked);

            if (secilen == null)
            {
                MessageBox.Show("Lütfen bir seçim yapınız!");
                return;
            }

            bool dogruMu = secenekler[secilen];

            if (dogruMu)
            {
                MessageBox.Show("Giriş Başarılı !");
                FrmOgrenci frm = new FrmOgrenci();
                frm.ogrno = okulno;

                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış seçim, tekrar deneyiniz!");
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

                txtTC.Enabled = true;
                txtOkulNo.Enabled = true;
                btnGiris.Enabled = true;



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
    }
}
