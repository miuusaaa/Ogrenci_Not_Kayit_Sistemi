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
    public partial class FrmOgrenci : Form
    {
        // Connection string
        private string conString = "Server=AKALI;Database=OgrenciNotKayitSistemi;Trusted_Connection=True;TrustServerCertificate=True;";

        // Login olan öğrenci bilgileri
        private string ogrenciTC;   // giriş yapan öğrenci
        private int okulID;
        private int sinifID;

        // Grid datası
        private DataTable dtNotlar;

        // Fotoğraf kontrol
        private bool fotografVarMi = false;

        // AGNO & Belge
        private decimal agno = 0;
        private string belgeDurumu = "Sonuçlandırılmadı";

        private bool tumDerslerSonuclandi = false;
        private bool genelOrtalamayaKatilabilir = false;
        private bool kalanDersVar = false;

        decimal toplamOrtalama = 0;
        int dersSayisi = 0;
        decimal genelOrtalama = 0;


        public FrmOgrenci(string ogrenciTC)
        {
            InitializeComponent();
            this.ogrenciTC = ogrenciTC;
        }
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //formu kullanıcı büyütmesin istiyorsan kullan.

            LoadOgrenciBilgileri();
            LoadOgrenciFoto();
            SetupDataGridView();
            LoadNotlar();
            LoadAGNOveBelge();
        }
        private void dgvNotlar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvNotlar.Columns[e.ColumnIndex].Name == "Durum")
            {
                var row = (dgvNotlar.Rows[e.RowIndex].DataBoundItem as DataRowView)?.Row;

                if (row != null)
                {
                    if (row["Sonuclandirildi"] != DBNull.Value && Convert.ToBoolean(row["Sonuclandirildi"]))
                    {
                        if (row["DersOrtalamasi"] != DBNull.Value)
                        {
                            decimal ort = Convert.ToDecimal(row["DersOrtalamasi"]);
                            e.Value = ort >= 50 ? "GEÇTİ" : "KALDI";
                        }
                    }
                    else
                    {
                        e.Value = "Sonuçlandırılmadı";
                    }

                    e.FormattingApplied = true;
                }
            }

            if (dgvNotlar.Columns[e.ColumnIndex].Name == "DersOrtalamasi")
            {
                if (e.Value == DBNull.Value)
                {
                    e.Value = "---";
                    e.FormattingApplied = true;
                }
            }
        }
        private void LoadOgrenciBilgileri()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    conn.Open();

                    string sql = @"
SELECT 
    o.Ad AS Adı,
    o.Soyad AS Soyadı,
    o.OgrNO,
    o.Email,
    o.Telefon,
    ok.OkulAd,
    s.SinifAd
FROM OGRENCILER o
JOIN OKULLAR ok ON o.OkulID = ok.OkulID
JOIN SINIFLAR s ON o.Sinif = s.SinifID
WHERE o.TC = @tc";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@tc", ogrenciTC);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        if (dr.Read())
                        {
                            lblAd.Text = dr["Adı"].ToString();
                            lblSoyad.Text = dr["Soyadı"].ToString();
                            lblOkulu.Text = dr["OkulAd"].ToString();
                            lblSinifi.Text = dr["SinifAd"].ToString();
                            lblOkulNo.Text = dr["OgrNo"].ToString();
                            lblEmail.Text = dr["Email"].ToString();
                            lblTelefon.Text = dr["Telefon"].ToString();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Öğrenci bilgileri yüklenemedi: " + ex.Message);
            }
        }

        private void LoadOgrenciFoto()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    conn.Open();

                    string sql = "SELECT FotoData FROM FOTOGRAFLAR WHERE TC=@tc";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@tc", ogrenciTC);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        byte[] img = (byte[])result;
                        using (MemoryStream ms = new MemoryStream(img))
                            pbResim.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        pbResim.Image = Properties.Resources.no_photo;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fotoğraf yüklenemedi: " + ex.Message);
            }
        }

        private void SetupDataGridView()
        {
            dgvNotlar.AutoGenerateColumns = false;
            dgvNotlar.Columns.Clear();

            dgvNotlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DersAd",
                HeaderText = "Ders",
                DataPropertyName = "DersAd",
                ReadOnly = true
            });

            dgvNotlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Sinav1",
                HeaderText = "Sınav 1",
                DataPropertyName = "Sinav1",
                ReadOnly = true
            });

            dgvNotlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Sinav2",
                HeaderText = "Sınav 2",
                DataPropertyName = "Sinav2",
                ReadOnly = true
            });

            dgvNotlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Sozlu",
                HeaderText = "Sözlü",
                DataPropertyName = "Sozlu",
                ReadOnly = true
            });

            dgvNotlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Sinav3",
                HeaderText = "Sınav 3",
                DataPropertyName = "Sinav3",
                ReadOnly = true
            });

            dgvNotlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DersOrtalamasi",
                HeaderText = "Ortalama",
                DataPropertyName = "DersOrtalamasi",
                ReadOnly = true
            });

            dgvNotlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Durum",
                HeaderText = "Durum",
                DataPropertyName = "Sonuclandirildi",
                ReadOnly = true
            });

            dgvNotlar.CellFormatting += dgvNotlar_CellFormatting;
        }



        private void LoadNotlar()
        {
            try
            {
                using SqlConnection conn = new SqlConnection(conString);
                conn.Open();

                string sql = "SELECT * FROM vw_OgrenciDersNotlari WHERE OgrenciTC=@tc";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@tc", ogrenciTC);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvNotlar.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Notlar yüklenemedi : " + ex.Message);

            }
        }

        private void LoadAGNOveBelge()
        {
            try
            {
                using SqlConnection conn = new SqlConnection(conString);
                conn.Open();

                string sql = "SELECT AGNO, BelgeDurumu FROM vw_OgrenciGenelSonuc WHERE OgrenciTC=@tc";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tc", ogrenciTC);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        lblAGNO.Text = dr["AGNO"] == DBNull.Value ? "Hesaplanmadı" : dr["AGNO"].ToString();
                        lblBelge.Text = dr["BelgeDurumu"].ToString();
                    }
                    else
                    {
                        lblAGNO.Text = "Hesaplanmadı";
                        lblBelge.Text = "Sonuçlandırılmadı";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("AGNO VE BELGE yüklenemedi : " + ex.Message);
            }
        }

    }
}
