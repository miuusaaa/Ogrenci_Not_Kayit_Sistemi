using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Öğrenci_Not_Kayıt_Sistemi
{
    public partial class FrmOgretmen : Form
    {
        // Connection
        private string conString = "Server=AKALI;Database=OgrenciNotKayitSistemi;Trusted_Connection=True;TrustServerCertificate=True;";

        // Login bilgileri
        private int ogretmenID;   // giriş yapan öğretmen
        private int okulID;       // öğretmenin çalıştığı okul
        private int dersID;       // öğretmenin branşı (tek)

        // Grid datası
        private DataTable dtNotlar;

        // Genel ortalama kontrolü
        private bool tumOgrencilerSonuclandi = false;

        // seçili öğrenci bilgileri (istersen kullanırsın)
        private string seciliOgrenciTC = "";
        private bool genelOrtalamayaHazir = false;

        public FrmOgretmen(int ogretmenID)
        {
            InitializeComponent();
            this.ogretmenID = ogretmenID; // KRİTİK
        }

        private void FrmOgretmen_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            LoadOgretmenBilgileri();
            SetupComboBox();
            SetupDataGridView();
            LoadOgrenciler();
            pbResim.Image = Properties.Resources.no_photo;

        }

        private void LoadOgretmenBilgileri()
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                string sql = @"SELECT CalistigiOkul, Brans, Ad + ' ' + Soyad 
                       FROM OGRETMENLER WHERE OgretmenID=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", ogretmenID);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    okulID = dr.GetInt32(0);
                    dersID = dr.GetInt32(1);
                    lblOgretmen.Text = "Hoş geldiniz - " + dr.GetString(2);
                }
            }
        }

        private void LoadOgrenciler(string filtreText = "", string durumFiltre = "Tüm Öğrenciler")
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();

                string sql = @"
SELECT 
    o.TC AS OgrenciTC,
    o.Ad + ' ' + o.Soyad AS AdSoyad,
    s.SinifAd,
    n.Sinav1,
    n.Sinav2,
    n.Sozlu,
    n.Sinav3,
    n.DersOrtalamasi,
    n.Sonuclandirildi
FROM OGRENCILER o
JOIN SINIFLAR s ON o.Sinif = s.SinifID
JOIN OKULLAR_SINIFLAR_DERSLER_OGRETMENLER osd
    ON osd.SinifID = o.Sinif
    AND osd.OkulID = o.OkulID
    AND osd.OgretmenID = @ogretmenID
    AND osd.DersID = @dersID
LEFT JOIN NOTLAR n
    ON n.OgrenciTC = o.TC
    AND n.DersID = @dersID
    AND n.OgretmenID = @ogretmenID
WHERE o.OkulID = @okulID
";

                // 🔹 Textbox filtresi
                if (!string.IsNullOrWhiteSpace(filtreText))
                {
                    sql += @"
AND (
    o.Ad LIKE @filtre
    OR o.Soyad LIKE @filtre
    OR s.SinifAd LIKE @filtre
    OR CAST(n.Sinav1 AS NVARCHAR) LIKE @filtre
    OR CAST(n.Sinav2 AS NVARCHAR) LIKE @filtre
    OR CAST(n.Sozlu AS NVARCHAR) LIKE @filtre
    OR CAST(n.Sinav3 AS NVARCHAR) LIKE @filtre
    OR CAST(n.DersOrtalamasi AS NVARCHAR) LIKE @filtre
)";
                }

                // 🔹 ComboBox filtresi
                if (durumFiltre == "Sonuçlandırılmış Öğrenciler")
                {
                    sql += " AND n.Sonuclandirildi = 1";
                }
                else if (durumFiltre == "Sonuçlandırılmamış Öğrenciler")
                {
                    sql += " AND (n.Sonuclandirildi = 0 OR n.Sonuclandirildi IS NULL)";
                }


                sql += " ORDER BY s.SinifAd, o.Ad, o.Soyad";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ogretmenID", ogretmenID);
                    cmd.Parameters.AddWithValue("@dersID", dersID);
                    cmd.Parameters.AddWithValue("@okulID", okulID);

                    if (!string.IsNullOrWhiteSpace(filtreText))
                        cmd.Parameters.AddWithValue("@filtre", "%" + filtreText + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dtNotlar = new DataTable();
                    da.Fill(dtNotlar);
                    dgvNotlar.DataSource = dtNotlar;
                }
            }
            dgvNotlar.ClearSelection();
        }


        private void SetupComboBox()
        {
            cmbDurum.Items.Clear();
            cmbDurum.Items.Add("Tüm Öğrenciler");
            cmbDurum.Items.Add("Sonuçlandırılmış Öğrenciler");
            cmbDurum.Items.Add("Sonuçlandırılmamış Öğrenciler");

            cmbDurum.SelectedIndex = 0; // varsayılan
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
                Name = "Sinav1",
                HeaderText = "Sınav 1",
                DataPropertyName = "Sinav1"
            });

            dgvNotlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Sinav2",
                HeaderText = "Sınav 2",
                DataPropertyName = "Sinav2"
            });

            dgvNotlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Sozlu",
                HeaderText = "Sözlü",
                DataPropertyName = "Sozlu"
            });

            dgvNotlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Sinav3",
                HeaderText = "Sınav 3",
                DataPropertyName = "Sinav3"
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
                Name = "Sonuclandirildi",
                HeaderText = "Durum",
                DataPropertyName = "Sonuclandirildi",
                ReadOnly = true
            });


            dgvNotlar.CellValidating += dgvNotlar_CellValidating;
            dgvNotlar.CellFormatting += dgvNotlar_CellFormatting;
        }

        private void dgvNotlar_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string col = dgvNotlar.Columns[e.ColumnIndex].Name;

            if (col == "Sinav1" || col == "Sinav2" || col == "Sozlu" || col == "Sinav3")
            {
                if (!string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    if (!int.TryParse(e.FormattedValue.ToString(), out int puan) || puan < 0 || puan > 100)
                    {
                        e.Cancel = true;
                        MessageBox.Show("Not 0-100 arası olmalıdır.");
                    }
                }
            }
        }

        private void btnNotlariKaydet_Click(object sender, EventArgs e)
        {
            dgvNotlar.EndEdit();

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                SqlTransaction tr = conn.BeginTransaction();

                try
                {
                    foreach (DataRow row in dtNotlar.Rows)
                    {
                        int? s1 = row["Sinav1"] == DBNull.Value ? null : Convert.ToInt32(row["Sinav1"]);
                        int? s2 = row["Sinav2"] == DBNull.Value ? null : Convert.ToInt32(row["Sinav2"]);
                        int? sozlu = row["Sozlu"] == DBNull.Value ? null : Convert.ToInt32(row["Sozlu"]);
                        int? s3 = row["Sinav3"] == DBNull.Value ? null : Convert.ToInt32(row["Sinav3"]);

                        string sql = @"
IF EXISTS (SELECT 1 FROM NOTLAR 
           WHERE OgrenciTC=@tc AND DersID=@dersID AND OgretmenID=@ogretmenID)
BEGIN
    UPDATE NOTLAR SET 
        Sinav1=@s1,
        Sinav2=@s2,
        Sozlu=@sozlu,
        Sinav3=@s3
    WHERE OgrenciTC=@tc AND DersID=@dersID AND OgretmenID=@ogretmenID
END
ELSE
BEGIN
    INSERT INTO NOTLAR (OgrenciTC, DersID, OgretmenID, Sinav1, Sinav2, Sozlu, Sinav3)
    VALUES (@tc, @dersID, @ogretmenID, @s1, @s2, @sozlu, @s3)
END
";

                        using (SqlCommand cmd = new SqlCommand(sql, conn, tr))
                        {
                            cmd.Parameters.AddWithValue("@tc", row["OgrenciTC"]);
                            cmd.Parameters.AddWithValue("@dersID", dersID);
                            cmd.Parameters.AddWithValue("@ogretmenID", ogretmenID);

                            cmd.Parameters.AddWithValue("@s1", (object)s1 ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@s2", (object)s2 ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@sozlu", (object)sozlu ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@s3", (object)s3 ?? DBNull.Value);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    tr.Commit();
                    MessageBox.Show("Notlar başarıyla kaydedildi.");
                    LoadOgrenciler();
                }
                catch (Exception ex)
                {
                    tr.Rollback();
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }




        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            LoadOgrenciler(txtAra.Text.Trim(), cmbDurum.SelectedItem.ToString());
        }

        private void cmbDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOgrenciler(txtAra.Text.Trim(), cmbDurum.SelectedItem.ToString());
        }

        private void dgvNotlar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Sadece "Sonuclandirildi" (Durum) kolonu için işlem yap
            if (dgvNotlar.Columns[e.ColumnIndex].Name == "Sonuclandirildi")
            {
                // DataTable'daki asıl satıra ulaşalım
                var row = (dgvNotlar.Rows[e.RowIndex].DataBoundItem as DataRowView)?.Row;

                if (row != null)
                {
                    // Ortalama ve Sonuclandirildi değerlerini çekelim
                    object ortValue = row["DersOrtalamasi"];
                    object sonucValue = row["Sonuclandirildi"];

                    // Eğer veritabanında Sonuclandirildi (bit) 1/True ise
                    if (sonucValue != DBNull.Value && Convert.ToBoolean(sonucValue))
                    {
                        if (ortValue != DBNull.Value)
                        {
                            decimal ortalama = Convert.ToDecimal(ortValue);
                            e.Value = ortalama >= 50 ? "GEÇTİ" : "KALDI";
                        }
                    }
                    else
                    {
                        // Notlar eksikse veya bit 0 ise
                        e.Value = "Sonuçlandırılmadı";
                    }

                    // Grid'in kendi içindeki otomatik dönüştürmeyi durduruyoruz
                    e.FormattingApplied = true;
                }
            }

            // Ortalama kolonunda sayısal format (0.00 gibi) göstermek isterseniz
            if (dgvNotlar.Columns[e.ColumnIndex].Name == "DersOrtalamasi")
            {
                if (e.Value == null || e.Value == DBNull.Value)
                {
                    e.Value = "---";
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvNotlar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNotlar.SelectedRows.Count == 0)
            {
                pbResim.Image = Properties.Resources.no_photo;
                return;
            }

            string tc = dgvNotlar.SelectedRows[0].Cells["OgrenciTC"].Value?.ToString();

            if (string.IsNullOrEmpty(tc))
            {
                pbResim.Image = Properties.Resources.no_photo;
                return;
            }

            FotoGetir(tc);
        }

        private void FotoGetir(string tc)
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();

                string sql = "SELECT FotoData FROM FOTOGRAFLAR WHERE TC=@tc";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tc", tc);

                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    byte[] bytes = (byte[])result;
                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        pbResim.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pbResim.Image = Properties.Resources.no_photo;
                }
            }
        }

    }
}
