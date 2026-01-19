using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Öğrenci_Not_Kayıt_Sistemi
{
    public partial class FrmOgretmen : Form
    {
        private string conString = "Server=AKALI;Database=OgrenciNotKayitSistemi;Trusted_Connection=True;TrustServerCertificate=True;";
        private int ogretmenID; // Giriş yapan öğretmen ID'si
        private int dersID;     // Öğretmenin dersi
        private int okulID;     // Öğretmenin okulu
        private DataTable dtNotlar;

        public FrmOgretmen(int ogretmenID)
        {
            InitializeComponent();
            this.ogretmenID = ogretmenID;
            LoadOgretmenBilgileri();
            SetupDataGridView();
            LoadOgrenciler();
        }

        private void LoadOgretmenBilgileri()
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                string sql = @"SELECT CalistigiOkul,Brans,Ad + ' ' + Soyad AS AdSoyad FROM OGRETMENLER WHERE OgretmenID=@id"
;
using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", ogretmenID);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            okulID = dr.GetInt32(0);
                            dersID = dr.GetInt32(1);

                            string adSoyad = dr.GetString(2);
                            lblOgretmen.Text = "Hoş geldiniz - " + adSoyad;
                        }

                    }
                }
            }
        }

        private void SetupDataGridView()
        {
            dgvNotlar.AutoGenerateColumns = false;
            dgvNotlar.Columns.Clear();

            dgvNotlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "OgrenciTC",
                HeaderText = "TC",
                DataPropertyName = "OgrenciTC",
                ReadOnly = true
            });
            dgvNotlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AdSoyad",
                HeaderText = "Ad Soyad",
                DataPropertyName = "AdSoyad",
                ReadOnly = true
            });
            dgvNotlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SinifAd",
                HeaderText = "Sınıf",
                DataPropertyName = "SinifAd",
                ReadOnly = true
            });
            dgvNotlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Puan",
                HeaderText = "Puan",
                DataPropertyName = "Puan",
                ReadOnly = false
            });

            dgvNotlar.CellValidating += DgvNotlar_CellValidating;
        }

        private void LoadOgrenciler(string filtre = "")
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                string sql = @"
                    SELECT 
    o.TC AS OgrenciTC,
    o.Ad + ' ' + o.Soyad AS AdSoyad,
    s.SinifAd,
    ISNULL(n.Puan, 0) AS Puan
FROM OGRENCILER o
JOIN SINIFLAR s ON o.Sinif = s.SinifID
JOIN OKULLAR_SINIFLAR_DERSLER_OGRETMENLER osd
    ON osd.SinifID = o.Sinif
    AND osd.OkulID = o.OkulID
    AND osd.OgretmenID = @ogretmenID
    AND osd.DersID = @dersID
LEFT JOIN NOTLAR n
    ON o.TC = n.OgrenciTC
    AND n.DersID = @dersID
    AND n.OgretmenID = @ogretmenID
WHERE o.OkulID = @okulID

                    " + (string.IsNullOrWhiteSpace(filtre) ? "" : "AND (o.Ad LIKE @filtre OR o.Soyad LIKE @filtre OR o.TC LIKE @filtre or s.SinifAd LIKE @filtre OR n.Puan LIKE @filtre)") + @"
                    ORDER BY s.SinifAd, o.Ad, o.Soyad";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@dersID", dersID);
                    cmd.Parameters.AddWithValue("@ogretmenID", ogretmenID);
                    cmd.Parameters.AddWithValue("@okulID", okulID);
                    if (!string.IsNullOrWhiteSpace(filtre))
                        cmd.Parameters.AddWithValue("@filtre", "%" + filtre + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dtNotlar = new DataTable();
                    da.Fill(dtNotlar);
                    dgvNotlar.DataSource = dtNotlar;
                }
            }
        }

        private void DgvNotlar_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvNotlar.Columns[e.ColumnIndex].Name == "Puan")
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out int puan) || puan < 0 || puan > 100)
                {
                    e.Cancel = true;
                    MessageBox.Show("Puan 0 ile 100 arasında olmalıdır.");
                }
            }
        }

        private void txtOgrenciAra_TextChanged(object sender, EventArgs e)
        {
            LoadOgrenciler(txtOgrenciAra.Text.Trim());
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                SqlTransaction tr = conn.BeginTransaction();
                try
                {
                    foreach (DataRow row in dtNotlar.Rows)
                    {
                        int puan = Convert.ToInt32(row["Puan"]);
                        string ogrTC = row["OgrenciTC"].ToString();

                        string upsert = @"
IF EXISTS(SELECT 1 FROM NOTLAR WHERE OgrenciTC=@ogrTC AND DersID=@dersID AND OgretmenID=@ogretmenID)
    UPDATE NOTLAR SET Puan=@puan, KayitTarihi=GETDATE()
    WHERE OgrenciTC=@ogrTC AND DersID=@dersID AND OgretmenID=@ogretmenID
ELSE
    INSERT INTO NOTLAR (OgrenciTC, DersID, OgretmenID, SinavNo, Puan, KayitTarihi)
    VALUES (@ogrTC, @dersID, @ogretmenID, 1, @puan, GETDATE())";

                        using (SqlCommand cmd = new SqlCommand(upsert, conn, tr))
                        {
                            cmd.Parameters.AddWithValue("@ogrTC", ogrTC);
                            cmd.Parameters.AddWithValue("@dersID", dersID);
                            cmd.Parameters.AddWithValue("@ogretmenID", ogretmenID);
                            cmd.Parameters.AddWithValue("@puan", puan);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    tr.Commit();
                    MessageBox.Show("Notlar başarıyla kaydedildi.");
                    LoadOgrenciler(txtOgrenciAra.Text.Trim());
                }
                catch (Exception ex)
                {
                    tr.Rollback();
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }
    }
}
