using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Öğrenci_Not_Kayıt_Sistemi
{
    public partial class FrmDersIslemleri : Form
    {
        string cs = @"Server=AKALI;Database=OgrenciNotKayitSistemi;Trusted_Connection=True;TrustServerCertificate=True;";
        private DataView dvOkullar;

        public FrmDersIslemleri()
        {
            InitializeComponent();
        }

        private void FrmDersIslemleri_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.TabStop = true;
                else
                    c.TabStop = false;
            }
            OkullariYukle();
        }

       
        

        // ================= OKULLAR =================
        private void OkullariYukle()
        {
            using (SqlConnection con = new SqlConnection(cs))
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT OkulID, OkulAd FROM OKULLAR ORDER BY OkulAd", con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Seçiniz satırını ekle
                DataRow dr = dt.NewRow();
                dr["OkulID"] = DBNull.Value;
                dr["OkulAd"] = "Seçiniz";
                dt.Rows.InsertAt(dr, 0);

                dvOkullar = new DataView(dt);

                cmbOkul.DataSource = dvOkullar;
                cmbOkul.DisplayMember = "OkulAd";
                cmbOkul.ValueMember = "OkulID";
                cmbOkul.SelectedIndex = 0;
            }

            cmbSinif.DataSource = null;
            cmbSinif.Items.Clear();
            cmbSinif.Items.Add("Seçiniz");
            cmbSinif.SelectedIndex = 0;

            cmbDers.DataSource = null;
            cmbDers.Items.Clear();
            cmbDers.Items.Add("Seçiniz");
            cmbDers.SelectedIndex = 0;
        }

        // ================= OKUL ARAMA =================

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (dvOkullar == null) return;

            string filtre = txtAra.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(filtre))
            {
                dvOkullar.RowFilter = "";
                if (cmbOkul.Items.Count > 0)
                    cmbOkul.SelectedIndex = 0; // "Seçiniz"
                return;
            }

            dvOkullar.RowFilter = $"OkulAd LIKE '%{filtre}%'";

            if (dvOkullar.Count == 0)
            {
                // Filtre sonucu eşleşme yok
                cmbOkul.SelectedIndex = -1;
                cmbSinif.SelectedIndex = 0;
                cmbDers.SelectedIndex = 0;
                return;
            }

            // Tek eşleşme varsa otomatik seç
            if (dvOkullar.Count == 1)
            {
                cmbOkul.SelectedValue = dvOkullar[0]["OkulID"];
            }
        }


        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            if (!cmbOkul.DroppedDown && dvOkullar?.Count > 1)
                cmbOkul.DroppedDown = true;
        }

        // ================= SINIFLAR =================
        private void cmbOkul_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOkul.SelectedValue == null || cmbOkul.SelectedValue is DataRowView) return;

            if (cmbOkul.SelectedValue == DBNull.Value)
            {
                cmbSinif.DataSource = null;
                cmbSinif.Items.Clear();
                cmbSinif.Items.Add("Seçiniz");
                cmbSinif.SelectedIndex = 0;

                cmbDers.DataSource = null;
                cmbDers.Items.Clear();
                cmbDers.Items.Add("Seçiniz");
                cmbDers.SelectedIndex = 0;
                return;
            }

            int okulId = Convert.ToInt32(cmbOkul.SelectedValue);

            using SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT S.SinifID, S.SinifAd
                  FROM OKULLAR_SINIFLAR OS
                  JOIN SINIFLAR S ON S.SinifID = OS.SinifID
                  WHERE OS.OkulID = @okulId", cs);

            da.SelectCommand.Parameters.Add("@okulId", SqlDbType.Int).Value = okulId;

            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow dr = dt.NewRow();
            dr["SinifID"] = DBNull.Value;
            dr["SinifAd"] = "Seçiniz";
            dt.Rows.InsertAt(dr, 0);

            cmbSinif.DisplayMember = "SinifAd";
            cmbSinif.ValueMember = "SinifID";
            cmbSinif.DataSource = dt;
            cmbSinif.SelectedIndex = 0;

            cmbDers.DataSource = null;
            cmbDers.Items.Clear();
            cmbDers.Items.Add("Seçiniz");
            cmbDers.SelectedIndex = 0;
        }

        // ================= DERSLER =================
        private void cmbSinif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSinif.SelectedValue == null || cmbSinif.SelectedValue is DataRowView) return;
            if (cmbSinif.SelectedValue == DBNull.Value)
            {
                cmbDers.DataSource = null;
                cmbDers.Items.Clear();
                cmbDers.Items.Add("Seçiniz");
                cmbDers.SelectedIndex = 0;
                return;
            }

            int okulId = Convert.ToInt32(cmbOkul.SelectedValue);
            int sinifId = Convert.ToInt32(cmbSinif.SelectedValue);

            using SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT D.DersID, D.DersAd
                  FROM OKULLAR_SINIFLAR_DERSLER OSD
                  JOIN DERSLER D ON D.DersID = OSD.DersID
                  WHERE OSD.OkulID = @okulId AND OSD.SinifID = @sinifId", cs);

            da.SelectCommand.Parameters.Add("@okulId", SqlDbType.Int).Value = okulId;
            da.SelectCommand.Parameters.Add("@sinifId", SqlDbType.Int).Value = sinifId;

            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow dr = dt.NewRow();
            dr["DersID"] = DBNull.Value;
            dr["DersAd"] = "Seçiniz";
            dt.Rows.InsertAt(dr, 0);

            cmbDers.DisplayMember = "DersAd";
            cmbDers.ValueMember = "DersID";
            cmbDers.DataSource = dt;
            cmbDers.SelectedIndex = 0;
        }

        private void cmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDers.SelectedIndex <= 0)
                txtDersAdi.Clear();
            else
                txtDersAdi.Text = cmbDers.Text;
        }

        // ================= ORTAK KONTROL =================
        private bool SecimKontrol()
        {
            if (cmbOkul.SelectedValue == null || cmbOkul.SelectedValue == DBNull.Value ||
                cmbSinif.SelectedValue == null || cmbSinif.SelectedValue == DBNull.Value)
            {
                MessageBox.Show("Okul ve sınıf seçimi zorunludur.");
                return false;
            }
            return true;
        }


        // ================= EKLE =================
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!SecimKontrol()) return;
            if (string.IsNullOrWhiteSpace(txtDersAdi.Text))
            {
                MessageBox.Show("Ders adı boş olamaz.");
                return;
            }

            if (MessageBox.Show("Ders eklenecek. Onaylıyor musunuz?",
                "Onay", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            using (SqlConnection con = new SqlConnection(cs))
            using (SqlCommand cmd = new SqlCommand("sp_DersEkle", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OkulID", cmbOkul.SelectedValue);
                cmd.Parameters.AddWithValue("@SinifID", cmbSinif.SelectedValue);
                cmd.Parameters.AddWithValue("@DersAdi", txtDersAdi.Text.Trim());

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ders eklendi.");
                    cmbSinif_SelectedIndexChanged(null, null);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // ================= GÜNCELLE =================
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (cmbDers.SelectedIndex <= 0)
            {
                MessageBox.Show("Güncellenecek ders seçiniz.");
                return;
            }

            if (MessageBox.Show("Ders güncellenecek. Onaylıyor musunuz?",
                "Onay", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            using (SqlConnection con = new SqlConnection(cs))
            using (SqlCommand cmd = new SqlCommand("sp_DersGuncelle", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OkulID", cmbOkul.SelectedValue);
                cmd.Parameters.AddWithValue("@SinifID", cmbSinif.SelectedValue);
                cmd.Parameters.AddWithValue("@DersID", cmbDers.SelectedValue);
                cmd.Parameters.AddWithValue("@YeniDersAdi", txtDersAdi.Text.Trim());

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ders güncellendi.");
                    cmbSinif_SelectedIndexChanged(null, null);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // ================= SİL =================
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (cmbDers.SelectedIndex <= 0)
            {
                MessageBox.Show("Silinecek ders seçiniz.");
                return;
            }

            if (MessageBox.Show(
                "Ders ve bu derse atanmış öğretmenler silinecek.\nOnaylıyor musunuz?",
                "KRİTİK ONAY",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.No)
                return;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlTransaction tr = con.BeginTransaction();

                try
                {
                    SqlCommand c1 = new SqlCommand(@"
                        DELETE FROM OKULLAR_SINIFLAR_DERSLER_OGRETMENLER
                        WHERE OkulID=@o AND SinifID=@s AND DersID=@d", con, tr);

                    c1.Parameters.AddWithValue("@o", cmbOkul.SelectedValue);
                    c1.Parameters.AddWithValue("@s", cmbSinif.SelectedValue);
                    c1.Parameters.AddWithValue("@d", cmbDers.SelectedValue);
                    c1.ExecuteNonQuery();

                    SqlCommand c2 = new SqlCommand(@"
                        DELETE FROM OKULLAR_SINIFLAR_DERSLER
                        WHERE OkulID=@o AND SinifID=@s AND DersID=@d", con, tr);

                    c2.Parameters.AddWithValue("@o", cmbOkul.SelectedValue);
                    c2.Parameters.AddWithValue("@s", cmbSinif.SelectedValue);
                    c2.Parameters.AddWithValue("@d", cmbDers.SelectedValue);
                    c2.ExecuteNonQuery();

                    tr.Commit();
                    MessageBox.Show("Ders silindi.");
                    cmbSinif_SelectedIndexChanged(null, null);
                    txtDersAdi.Clear();
                }
                catch
                {
                    tr.Rollback();
                    MessageBox.Show("Silme başarısız.");
                }
            }
        }

        private void FrmDersIslemleri_Shown(object sender, EventArgs e)
        {
            txtAra.Focus();
        }
    }
}
