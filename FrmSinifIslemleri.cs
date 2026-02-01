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
    public partial class FrmSinifIslemleri : Form
    {
        DataTable dtOkullar;
        DataView dvOkullar;

        public FrmSinifIslemleri()
        {
            InitializeComponent();
        }

        private void FrmSinifIslemleri_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //formu kullanıcı büyütmesin istiyorsan kullan.

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.TabStop = true;
                else
                    c.TabStop = false;
            }

            OkullariYukle();
            txtYeniSinifAd.MaxLength = 4;

        }

        string conString = "Server=AKALI;Database=OgrenciNotKayitSistemi;Trusted_Connection=True;TrustServerCertificate=True;";

        private void OkullariYukle()
        {
            cmbOkullar.SelectedIndexChanged -= cmbOkullar_SelectedIndexChanged;

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT OkulID, OkulAd FROM OKULLAR ORDER BY OkulAd", conn);

                dtOkullar = new DataTable();
                da.Fill(dtOkullar);

                dtOkullar.CaseSensitive = false;

                dvOkullar = new DataView(dtOkullar);

                cmbOkullar.DisplayMember = "OkulAd";
                cmbOkullar.ValueMember = "OkulID";
                cmbOkullar.DataSource = dvOkullar;

            }

            cmbOkullar.SelectedIndexChanged += cmbOkullar_SelectedIndexChanged;
        }


        private void cmbOkullar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOkullar.SelectedValue == null || cmbOkullar.SelectedValue is DataRowView) return;

            clbSiniflar.Items.Clear();

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(@"
            SELECT 
                os.SinifID,
                s.SinifAd
            FROM OKULLAR_SINIFLAR os
            JOIN SINIFLAR s ON s.SinifID = os.SinifID
            WHERE os.OkulID = @okul
            ORDER BY s.SinifAd", conn);

                cmd.Parameters.AddWithValue("@okul", cmbOkullar.SelectedValue);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    clbSiniflar.Items.Add(
                        new KeyValuePair<int, string>(
                            (int)dr["SinifID"],
                            dr["SinifAd"].ToString()));
                }
            }

            clbSiniflar.DisplayMember = "Value";
            clbSiniflar.ValueMember = "Key";
        }

        private void btnSinifEkle_Click(object sender, EventArgs e)
        {
            if (cmbOkullar.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtYeniSinifAd.Text))
            {
                MessageBox.Show("Okul seçimi ve sınıf adı girişi zorunludur.");
                return;
            }

            string sinifAd = txtYeniSinifAd.Text.Trim();

            if (sinifAd.Length == 0 || sinifAd.Length > 4)
            {
                MessageBox.Show("Sınıf adı en fazla 4 karakter olabilir.");
                return;
            }


            DialogResult dr = MessageBox.Show(
        "Bu okula yeni bir sınıf eklemek istiyor musunuz?",
        "Sınıf Ekleme Onayı",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (dr != DialogResult.Yes)
            {
                MessageBox.Show("İşlem iptal edildi.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                SqlTransaction tr = conn.BeginTransaction();

                try
                {
                    // 1️⃣ Aynı okulda isim kontrolü
                    SqlCommand check = new SqlCommand(@"
                SELECT COUNT(*) 
                FROM OKULLAR_SINIFLAR os
                JOIN SINIFLAR s ON s.SinifID = os.SinifID
                WHERE os.OkulID=@okul AND s.SinifAd=@ad", conn, tr);

                    check.Parameters.AddWithValue("@okul", cmbOkullar.SelectedValue);
                    check.Parameters.AddWithValue("@ad", txtYeniSinifAd.Text.Trim());

                    if ((int)check.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Bu okulda aynı isimde sınıf zaten var.");
                        tr.Rollback();
                        return;
                    }

                    // 2️⃣ SINIF VAR MI?
                    int sinifID;
                    SqlCommand sinifCheck = new SqlCommand(
                        "SELECT SinifID FROM SINIFLAR WHERE SinifAd=@ad", conn, tr);

                    sinifCheck.Parameters.AddWithValue("@ad", txtYeniSinifAd.Text.Trim());
                    object result = sinifCheck.ExecuteScalar();

                    if (result == null)
                    {
                        SqlCommand insertSinif = new SqlCommand(
                            "INSERT INTO SINIFLAR (SinifAd) VALUES (@ad); SELECT SCOPE_IDENTITY();",
                            conn, tr);

                        insertSinif.Parameters.AddWithValue("@ad", txtYeniSinifAd.Text.Trim());
                        sinifID = Convert.ToInt32(insertSinif.ExecuteScalar());
                    }
                    else
                    {
                        sinifID = Convert.ToInt32(result);
                    }

                    // 3️⃣ OKULA BAĞLA
                    SqlCommand insertOS = new SqlCommand(
                        "INSERT INTO OKULLAR_SINIFLAR (OkulID, SinifID) VALUES (@okul, @sinif)",
                        conn, tr);

                    insertOS.Parameters.AddWithValue("@okul", cmbOkullar.SelectedValue);
                    insertOS.Parameters.AddWithValue("@sinif", sinifID);
                    insertOS.ExecuteNonQuery();

                    tr.Commit();
                    MessageBox.Show("Sınıf okula eklendi.");
                }
                catch (Exception ex)
                {
                    tr.Rollback();
                    MessageBox.Show("Hata:\n" + ex.Message);
                }
            }

            cmbOkullar_SelectedIndexChanged(null, null);
        }

        private void btnSinifSil_Click(object sender, EventArgs e)
        {
            if (clbSiniflar.CheckedItems.Count == 0)
            {
                MessageBox.Show("En az bir sınıf seçin.");
                return;
            }

            DialogResult dr = MessageBox.Show(
        "Seçilen sınıflar ve buna bağlı öğretmenler ve öğrenciler de silinecek.\n\n" +
        "Bu işlem geri alınamaz.\n\nDevam etmek istiyor musunuz?",
        "KRİTİK SİLME ONAYI",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

            if (dr != DialogResult.Yes)
            {
                MessageBox.Show("Silme işlemi iptal edildi.");
                return;
            }

            int okulID = Convert.ToInt32(cmbOkullar.SelectedValue);

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                SqlTransaction tr = conn.BeginTransaction();

                try
                {
                    List<int> silinecekOgretmenler = new List<int>();

                    foreach (KeyValuePair<int, string> item in clbSiniflar.CheckedItems)
                    {
                        int sinifID = item.Key;

                        // 🔹 1) Bu sınıfa bağlı öğretmenleri topla
                        SqlCommand ogretmenlerCmd = new SqlCommand(@"
                    SELECT DISTINCT OgretmenID
                    FROM OKULLAR_SINIFLAR_DERSLER_OGRETMENLER
                    WHERE OkulID=@okul AND SinifID=@sinif",
                            conn, tr);

                        ogretmenlerCmd.Parameters.AddWithValue("@okul", okulID);
                        ogretmenlerCmd.Parameters.AddWithValue("@sinif", sinifID);

                        using (SqlDataReader dr1 = ogretmenlerCmd.ExecuteReader())
                        {
                            while (dr1.Read())
                                silinecekOgretmenler.Add((int)dr1["OgretmenID"]);
                        }

                        // 🔹 2) Ders–Öğretmen
                        new SqlCommand(@"
                    DELETE FROM OKULLAR_SINIFLAR_DERSLER_OGRETMENLER
                    WHERE OkulID=@okul AND SinifID=@sinif",
                            conn, tr)
                        {
                            Parameters =
                    {
                        new SqlParameter("@okul", okulID),
                        new SqlParameter("@sinif", sinifID)
                    }
                        }.ExecuteNonQuery();

                        // 🔹 3) Dersler
                        new SqlCommand(@"
                    DELETE FROM OKULLAR_SINIFLAR_DERSLER
                    WHERE OkulID=@okul AND SinifID=@sinif",
                            conn, tr)
                        {
                            Parameters =
                    {
                        new SqlParameter("@okul", okulID),
                        new SqlParameter("@sinif", sinifID)
                    }
                        }.ExecuteNonQuery();

                        // 🔹 4) Öğrenciler
                        new SqlCommand(@"
                    DELETE FROM OGRENCILER 
                    WHERE OkulID=@okul AND Sinif=@sinif",
                            conn, tr)
                        {
                            Parameters =
                    {
                        new SqlParameter("@okul", okulID),
                        new SqlParameter("@sinif", sinifID)
                    }
                        }.ExecuteNonQuery();

                        // 🔹 5) Okul–Sınıf ilişkisi
                        new SqlCommand(@"
                    DELETE FROM OKULLAR_SINIFLAR
                    WHERE OkulID=@okul AND SinifID=@sinif",
                            conn, tr)
                        {
                            Parameters =
                    {
                        new SqlParameter("@okul", okulID),
                        new SqlParameter("@sinif", sinifID)
                    }
                        }.ExecuteNonQuery();
                    }

                    // 🔹 6) Öğretmenleri kontrol et ve gerekiyorsa sil
                    foreach (int ogretmenID in silinecekOgretmenler.Distinct())
                    {
                        SqlCommand kontrol = new SqlCommand(@"
                    SELECT COUNT(*)
                    FROM OKULLAR_SINIFLAR_DERSLER_OGRETMENLER
                    WHERE OgretmenID=@ogretmen AND OkulID=@okul",
                            conn, tr);

                        kontrol.Parameters.AddWithValue("@ogretmen", ogretmenID);
                        kontrol.Parameters.AddWithValue("@okul", okulID);

                        int kalan = (int)kontrol.ExecuteScalar();

                        if (kalan == 0)
                        {
                            new SqlCommand(
                               @"DELETE FROM OGRETMEN_GIRIS WHERE OgretmenID=@id",
                                conn, tr)
                            {
                                Parameters = { new SqlParameter("@id", ogretmenID) }
                            }.ExecuteNonQuery();
                        }
                    }

                    tr.Commit();
                    MessageBox.Show("Sınıflar başarıyla silindi.");
                }
                catch (Exception ex)
                {
                    tr.Rollback();
                    MessageBox.Show("Hata:\n" + ex.Message);
                }
            }

            cmbOkullar_SelectedIndexChanged(null, null);
        }

        private void txtOkulAra_TextChanged(object sender, EventArgs e)
        {
            if (dvOkullar == null) return;

            string filtre = txtOkulAra.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(filtre))
            {
                dvOkullar.RowFilter = "";
                cmbOkullar.SelectedIndex = -1;
                clbSiniflar.Items.Clear();
                return;
            }

            dvOkullar.RowFilter = $"OkulAd LIKE '%{filtre}%'";

            // 🔴 TEK EŞLEŞME VARSA OTOMATİK SEÇ
            if (dvOkullar.Count == 1)
            {
                cmbOkullar.SelectedValue = dvOkullar[0]["OkulID"];
            }
        }

        private void txtOkulAra_KeyUp(object sender, KeyEventArgs e)
        {
            if (!cmbOkullar.DroppedDown && dvOkullar?.Count > 1)
                cmbOkullar.DroppedDown = true;
        }
    }
}
