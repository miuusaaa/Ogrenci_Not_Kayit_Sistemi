using BCrypt.Net;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Öğrenci_Not_Kayıt_Sistemi
{
    public partial class FrmOgretmenIslemleri : Form
    {
        private string conString = "Server=AKALI;Database=OgrenciNotKayitSistemi;Trusted_Connection=True;TrustServerCertificate=True;";

        public FrmOgretmenIslemleri()
        {
            InitializeComponent();
        }

        private void FrmOgretmenIslemleri_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //formu kullanıcı büyütmesin istiyorsan kullan.
            txtOgretmenTelefon.MaxLength = 13;

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.TabStop = true;
                else
                    c.TabStop = false;
            }
            
            LoadOgretmenler();
            AktiflikRenkleriniUygula();
            dgvOgretmenler.ClearSelection();

            dgvOgretmenler.CurrentCellDirtyStateChanged += dgvOgretmenler_CurrentCellDirtyStateChanged;

            foreach (DataGridViewRow row in dgvOgretmenler.Rows)
            {
                bool aktif = row.Cells["Aktif"].Value != DBNull.Value && Convert.ToBoolean(row.Cells["Aktif"].Value);
            }

        }

        private void LoadOgretmenler()
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();

                // SQL sorgusu filtrelemedeki gibi: sınıflar birleştirilmiş ve sütunlar düzenli
                string sql = @"
           SELECT 
    o.OgretmenID,
    o.Ad AS 'Adı',
    o.Soyad AS 'Soyadı',
    o.Brans AS 'BransID',
    d.DersAd AS 'Branşı',
    o.CalistigiOkul AS 'OkulID',
    ok.OkulAd AS 'Çalıştığı Okul',
    STRING_AGG(s.SinifAd, ', ') AS 'Girdiği Siniflar',
    o.Email AS 'E-posta',
    o.Telefon,
    og.KullaniciAdi AS 'Kullanıcı Adı',
    ISNULL(og.Aktif, 0) AS 'Aktif'

FROM OGRETMENLER o
JOIN DERSLER d ON o.Brans = d.DersID
JOIN OKULLAR ok ON o.CalistigiOkul = ok.OkulID
LEFT JOIN OGRETMEN_GIRIS og ON o.OgretmenID = og.OgretmenID
LEFT JOIN OKULLAR_SINIFLAR_DERSLER_OGRETMENLER osdo ON osdo.OgretmenID = o.OgretmenID
LEFT JOIN SINIFLAR s ON osdo.SinifID = s.SinifID
GROUP BY 
    o.OgretmenID, o.Ad, o.Soyad, o.Brans, d.DersAd,
    o.CalistigiOkul, ok.OkulAd,
    o.Email, o.Telefon, og.Aktif,
    og.KullaniciAdi
ORDER BY o.Ad, o.Soyad
;";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvOgretmenler.DataSource = dt;

                if (!(dgvOgretmenler.Columns["Aktif"] is DataGridViewCheckBoxColumn))
                {
                    DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                    chk.Name = "Aktif";
                    chk.HeaderText = "Aktif";
                    chk.DataPropertyName = "Aktif";
                    chk.TrueValue = true;
                    chk.FalseValue = false;

                    dgvOgretmenler.Columns.Remove("Aktif");
                    dgvOgretmenler.Columns.Add(chk);
                }

                dgvOgretmenler.Columns["Aktif"].DisplayIndex = 0;

                // Gereksiz ID’leri gizle
                dgvOgretmenler.Columns["OgretmenID"].Visible = false;
                dgvOgretmenler.Columns["BransID"].Visible = false;
                dgvOgretmenler.Columns["OkulID"].Visible = false;

                // Sütun sırasını ayarlayabilirsin
                dgvOgretmenler.Columns["Adı"].DisplayIndex = 0;
                dgvOgretmenler.Columns["Soyadı"].DisplayIndex = 1;
                dgvOgretmenler.Columns["Branşı"].DisplayIndex = 2;
                dgvOgretmenler.Columns["Çalıştığı Okul"].DisplayIndex = 3;
                dgvOgretmenler.Columns["Girdiği Siniflar"].DisplayIndex = 4;
                dgvOgretmenler.Columns["E-posta"].DisplayIndex = 5;
                dgvOgretmenler.Columns["Telefon"].DisplayIndex = 6;
                dgvOgretmenler.Columns["Kullanıcı Adı"].DisplayIndex = 7;
                dgvOgretmenler.Columns["Telefon"].DisplayIndex = 8;
                dgvOgretmenler.Columns["Aktif"].DisplayIndex = 9;


                // Okul comboboxları aynı kalabilir
                string sqlOkullar = "SELECT OkulID,OkulAd FROM OKULLAR";
                SqlDataAdapter daOkul = new SqlDataAdapter(sqlOkullar, conn);
                SqlDataAdapter daGuncelOkul = new SqlDataAdapter(sqlOkullar, conn);
                DataTable dtOkul = new DataTable();
                DataTable dtGuncelOkul = new DataTable();
                daOkul.Fill(dtOkul);
                daGuncelOkul.Fill(dtGuncelOkul);

                DataRow drOkul = dtOkul.NewRow();
                drOkul["OkulID"] = 0;
                drOkul["OkulAd"] = "— Seçiniz —";
                dtOkul.Rows.InsertAt(drOkul, 0);

                DataRow drGuncelOkul = dtGuncelOkul.NewRow();
                drGuncelOkul["OkulID"] = 0;
                drGuncelOkul["OkulAd"] = "— Seçiniz —";
                dtGuncelOkul.Rows.InsertAt(drGuncelOkul, 0);

                cmbOkullar.ValueMember = "OkulID";
                cmbOkullar.DisplayMember = "OkulAd";
                cmbOkullar.DataSource = dtOkul;
                cmbOkullar.SelectedIndex = 0;

                cmbGuncelOkullar.ValueMember = "OkulID";
                cmbGuncelOkullar.DisplayMember = "OkulAd";
                cmbGuncelOkullar.DataSource = dtGuncelOkul;
                cmbGuncelOkullar.SelectedIndex = 0;
            }

            foreach (DataGridViewRow row in dgvOgretmenler.Rows)
            {
                row.Cells["Aktif"].Tag = row.Cells["Aktif"].Value;

                if (row.Cells["Kullanıcı Adı"].Value == DBNull.Value)
                {
                    row.Cells["Kullanıcı Adı"].Value = "— Tanımlı Değil —";
                }

            }

            foreach (DataGridViewColumn col in dgvOgretmenler.Columns)
            {
                col.ReadOnly = true;
            }

            dgvOgretmenler.Columns["Aktif"].ReadOnly = false;

        }

        private async void btnOgretmenEkle_Click(object sender, EventArgs e)
        {

            string plainPassword = Guid.NewGuid().ToString("N").Substring(0, 10);
            string hash = BCrypt.Net.BCrypt.HashPassword(plainPassword);

            if (string.IsNullOrWhiteSpace(txtOgretmenAd.Text) ||
                string.IsNullOrWhiteSpace(txtOgretmenSoyad.Text) ||
                cmbOkullar.SelectedValue == null ||
                cmbBranslar.SelectedValue == null)
            {
                MessageBox.Show("Ad, soyad, okul ve branş zorunludur!");
                return;
            }

            if (clbSiniflar.CheckedItems.Count == 0)
            {
                MessageBox.Show("Lütfen öğretmenin ders vereceği en az bir sınıf seçin.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))

            {
                MessageBox.Show("Lütfen öğretmen için kullanıcı adı belirleyiniz.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtOgretmenEmail.Text))

            {
                MessageBox.Show("Lütfen öğretmenin e-mailini giriniz.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtOgretmenTelefon.Text))

            {
                MessageBox.Show("Lütfen öğretmenin telefon numarasını giriniz.");
                return;
            }



            int okulID = Convert.ToInt32(cmbOkullar.SelectedValue);
            int bransID = Convert.ToInt32(cmbBranslar.SelectedValue);

            string ad = txtOgretmenAd.Text.Trim();
            string soyad = txtOgretmenSoyad.Text.Trim();
            string email = string.IsNullOrWhiteSpace(txtOgretmenEmail.Text) ? null : txtOgretmenEmail.Text.Trim();
            string telefon = string.IsNullOrWhiteSpace(txtOgretmenTelefon.Text) ? null : txtOgretmenTelefon.Text.Trim();
            string kullaniciadi = string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) ? null : txtKullaniciAdi.Text.Trim();

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();

                // EMAIL KONTROL
                string checkEmail = "SELECT COUNT(*) FROM OGRETMENLER WHERE Email=@e";
                using (SqlCommand c1 = new SqlCommand(checkEmail, conn))
                {
                    c1.Parameters.AddWithValue("@e", email ?? (object)DBNull.Value);
                    if (!string.IsNullOrWhiteSpace(email) && (int)c1.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Bu email başka öğretmende kayıtlı!");
                        return;
                    }
                }

                // kullanıcadı kontrol 
                string checkNİCK = "SELECT COUNT(*) FROM OGRETMEN_GIRIS WHERE KullaniciAdi = @n\r\n";
                using (SqlCommand c1 = new SqlCommand(checkNİCK, conn))
                {
                    c1.Parameters.AddWithValue("@n", kullaniciadi ?? (object)DBNull.Value);
                    if (!string.IsNullOrWhiteSpace(kullaniciadi) && (int)c1.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Bu kullanıcı adı başka öğretmende kayıtlı!");
                        return;
                    }
                }
                // TELEFON KONTROL
                string checkTel = "SELECT COUNT(*) FROM OGRETMENLER WHERE Telefon=@t";
                using (SqlCommand c2 = new SqlCommand(checkTel, conn))
                {
                    c2.Parameters.AddWithValue("@t", telefon ?? (object)DBNull.Value);
                    if (!string.IsNullOrWhiteSpace(telefon) && (int)c2.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Bu telefon başka öğretmende kayıtlı!");
                        return;
                    }
                }

                // SINIF ÇAKIŞMA KONTROLÜ
                List<int> atanabilirSiniflar = new List<int>();
                List<string> atanabilirSinifAdlari = new List<string>();

                foreach (var item in clbSiniflar.CheckedItems)
                {
                    dynamic sinif = item;
                    int sinifID = sinif.ID;

                    string sql = @"SELECT COUNT(*)
FROM OKULLAR_SINIFLAR_DERSLER_OGRETMENLER osd
JOIN OGRETMENLER o ON o.OgretmenID = osd.OgretmenID
JOIN OGRETMEN_GIRIS og ON o.OgretmenID = og.OgretmenID
WHERE osd.OkulID = @okul
  AND osd.SinifID = @sinif
  AND osd.DersID = @brans
  AND og.Aktif = 1

";

                    using (SqlCommand kontrol = new SqlCommand(sql, conn))
                    {
                        kontrol.Parameters.AddWithValue("@okul", okulID);
                        kontrol.Parameters.AddWithValue("@sinif", sinifID);
                        kontrol.Parameters.AddWithValue("@brans", bransID);

                        int doluMu = (int)kontrol.ExecuteScalar();

                        if (doluMu == 0)
                        {
                            atanabilirSiniflar.Add(sinifID);
                            atanabilirSinifAdlari.Add(sinif.Name);
                        }
                    }
                }

                // HİÇBİR SINIFA ATANAMIYORSA EKLEME
                if (atanabilirSiniflar.Count == 0)
                {
                    MessageBox.Show("Seçilen sınıfların tamamı bu branş için dolu. Öğretmen sisteme eklenmedi.");
                    return;
                }

                // ONAY MESAJI (sadece 1 defa)
                string liste = string.Join(", ", atanabilirSinifAdlari);
                DialogResult onay = MessageBox.Show(
                    $"Bu öğretmen sadece şu sınıflara atanabilecek:\n\n{liste}\n\nEklemek istiyor musunuz?",
                    "Onay",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (onay != DialogResult.Yes)
                    return;

                // ÖĞRETMENİ TEK KERE EKLE
                int ogretmenID;
                bool dbBasarili = false;

                using (SqlTransaction tr = conn.BeginTransaction())
                {
                    try
                    {

                        string addQuery = @"INSERT INTO OGRETMENLER
                            (Ad, Soyad, Email, Telefon, Brans, CalistigiOkul)
                            VALUES (@ad, @soyad, @e, @t, @b, @o)
                            SELECT SCOPE_IDENTITY()";

                        string addQuerygiris =
                            @"INSERT INTO OGRETMEN_GIRIS (OgretmenID, KullaniciAdi,SifreHash,Aktif,Email,Telefon) VALUES (@ogretmenID,@n,@hash,1,@email,@telefon)";

                        using (SqlCommand cmdAdd = new SqlCommand(addQuery, conn, tr))
                        {
                            cmdAdd.Parameters.AddWithValue("@ad", ad);
                            cmdAdd.Parameters.AddWithValue("@soyad", soyad);
                            cmdAdd.Parameters.AddWithValue("@e", (object)email ?? DBNull.Value);
                            cmdAdd.Parameters.AddWithValue("@t", (object)telefon ?? DBNull.Value);
                            cmdAdd.Parameters.AddWithValue("@b", bransID);
                            cmdAdd.Parameters.AddWithValue("@o", okulID);

                            ogretmenID = Convert.ToInt32(cmdAdd.ExecuteScalar());

                        }

                        using (SqlCommand cmdAddgiris = new SqlCommand(addQuerygiris, conn,tr))
                        {
                            cmdAddgiris.Parameters.AddWithValue("@ogretmenID", ogretmenID);
                            cmdAddgiris.Parameters.AddWithValue("@n", kullaniciadi);
                            cmdAddgiris.Parameters.AddWithValue("@hash", hash);
                            cmdAddgiris.Parameters.AddWithValue("@email", txtOgretmenEmail.Text);
                            cmdAddgiris.Parameters.AddWithValue("@telefon", txtOgretmenTelefon.Text);

                            cmdAddgiris.ExecuteNonQuery();
                        }


                        // ATANABİLEN SINIFLARA EKLE
                        foreach (int sinifID in atanabilirSiniflar)
                        {
                            string insert = @"INSERT INTO OKULLAR_SINIFLAR_DERSLER_OGRETMENLER
                              (OgretmenID, OkulID, SinifID, DersID)
                              VALUES (@oID, @okul, @sinif, @ders)";

                            using (SqlCommand cmdInsert = new SqlCommand(insert, conn,tr))
                            {
                                cmdInsert.Parameters.AddWithValue("@oID", ogretmenID);
                                cmdInsert.Parameters.AddWithValue("@okul", okulID);
                                cmdInsert.Parameters.AddWithValue("@sinif", sinifID);
                                cmdInsert.Parameters.AddWithValue("@ders", bransID);
                                cmdInsert.ExecuteNonQuery();
                            }
                        }
                        tr.Commit();
                        dbBasarili = true;
                    }
                    catch (Exception ex)
                    {
                        try { tr.Rollback(); } catch { }
                        MessageBox.Show("Veritabanı hatası: " + ex.Message);
                        return;
                    }
                }

                // 🔹 BURASI ARTIK TRANSACTION DIŞI
                if (dbBasarili)
                {
                    try
                    {
                        MailHelper.maileIlkGirisBilgileriGonder(email, kullaniciadi, plainPassword);
                        await SmsHelper.smseIlkGirisBilgileriGonder(telefon, kullaniciadi, plainPassword);

                        MessageBox.Show("Öğretmen sisteme eklendi ve giriş bilgileri e-posta ve telefonuna gönderildi.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Öğretmen eklendi fakat bilgiler e-posta ve telefonuna gönderilemedi :\n" + ex.Message
                        );
                    }

                    txtKullaniciAdi.Clear();
                    txtOgretmenEmail.Clear();
                    txtOgretmenTelefon.Clear();
                    LoadOgretmenler();
                    AktiflikRenkleriniUygula();
                }
            }
        }


        private void btnOgretmenGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvOgretmenler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz öğretmeni seçin.");
                return;
            }


            if (cmbGuncelOkullar.SelectedValue == null || cmbGuncelBranslar.SelectedValue == null)
            {
                MessageBox.Show("Okul ve branş seçimi zorunludur!");
                return;
            }

            if (clbGuncelSiniflar.CheckedItems.Count == 0)
            {
                MessageBox.Show("Lütfen öğretmenin çalışacağı sınıfları seçin.");
                return;
            }

            int ogretmenID = Convert.ToInt32(dgvOgretmenler.SelectedRows[0].Cells["OgretmenID"].Value);

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();

                // Telefon kontrolü
                string checkPhone = "SELECT COUNT(*) FROM OGRETMENLER WHERE Telefon=@telefon AND OgretmenID<>@id";
                using (SqlCommand cmdPhone = new SqlCommand(checkPhone, conn))
                {
                    cmdPhone.Parameters.AddWithValue("@telefon", txtGuncelTelefon.Text.Trim());
                    cmdPhone.Parameters.AddWithValue("@id", ogretmenID);

                    if ((int)cmdPhone.ExecuteScalar() > 0 && !string.IsNullOrWhiteSpace(txtGuncelTelefon.Text))
                    {
                        MessageBox.Show("Bu telefon numarası başka öğretmende kayıtlı!");
                        return;
                    }
                }

                // Email kontrolü
                string checkEmail = "SELECT COUNT(*) FROM OGRETMENLER WHERE Email=@email AND OgretmenID<>@id";
                using (SqlCommand cmdEmail = new SqlCommand(checkEmail, conn))
                {
                    cmdEmail.Parameters.AddWithValue("@email", txtGuncelEmail.Text.Trim());
                    cmdEmail.Parameters.AddWithValue("@id", ogretmenID);

                    if ((int)cmdEmail.ExecuteScalar() > 0 && !string.IsNullOrWhiteSpace(txtGuncelEmail.Text))
                    {
                        MessageBox.Show("Bu Email başka öğretmende kayıtlı!");
                        return;
                    }
                }

                // kullanıcı adı kontrolü
                string checkNİCK = "SELECT COUNT(*) FROM OGRETMEN_GIRIS WHERE KullaniciAdi =@nick AND OgretmenID<>@id";
                using (SqlCommand cmd = new SqlCommand(checkNİCK, conn))
                {
                    cmd.Parameters.AddWithValue("@nick", txtKullaniciAdi.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", ogretmenID);

                    if ((int)cmd.ExecuteScalar() > 0 && !string.IsNullOrWhiteSpace(txtGuncelKullaniciAdi.Text))
                    {
                        MessageBox.Show("Bu kullanıcı adı başka öğretmende kayıtlı!");
                        return;
                    }
                }

                // ONAY
                string sinifListesi = string.Join(", ",
                    clbGuncelSiniflar.CheckedItems.Cast<dynamic>().Select(x => x.Name));

                DialogResult result = MessageBox.Show(
                    $"Öğretmeni seçilen okul ve branştaki şu sınıflara güncellemek istiyor musunuz?\n\n{sinifListesi}",
                    "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes) return;

                // 1) Öğretmen bilgilerini güncelle
                string updateQuery = @"UPDATE OGRETMENLER
                   SET Brans=@brans, CalistigiOkul=@okul,
                       Email=@email, Telefon=@telefon
                   WHERE OgretmenID=@id";

                string updateQuerygiris = @"UPDATE OGRETMEN_GIRIS
                   SET KullaniciAdi = @nick
                   WHERE OgretmenID=@id";

                using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
                {
                    cmdUpdate.Parameters.AddWithValue("@brans", cmbGuncelBranslar.SelectedValue);
                    cmdUpdate.Parameters.AddWithValue("@okul", cmbGuncelOkullar.SelectedValue);
                    cmdUpdate.Parameters.AddWithValue("@email",
                        string.IsNullOrWhiteSpace(txtGuncelEmail.Text) ? DBNull.Value : (object)txtGuncelEmail.Text);
                    cmdUpdate.Parameters.AddWithValue("@telefon",
                        string.IsNullOrWhiteSpace(txtGuncelTelefon.Text) ? DBNull.Value : (object)txtGuncelTelefon.Text);

                    cmdUpdate.Parameters.AddWithValue("@id", ogretmenID);

                    cmdUpdate.ExecuteNonQuery();
                }

                using (SqlCommand cmdUpdategiris = new SqlCommand(updateQuerygiris, conn))
                {

                    cmdUpdategiris.Parameters.AddWithValue("@nick",
                        string.IsNullOrWhiteSpace(txtGuncelKullaniciAdi.Text) ? DBNull.Value : (object)txtGuncelKullaniciAdi.Text);




                    cmdUpdategiris.Parameters.AddWithValue("@id", ogretmenID);

                    cmdUpdategiris.ExecuteNonQuery();
                }




                // 2) Yeni sınıf atamaları - sadece müsait ve duplicate olmayan sınıflar eklenir
                // 2️⃣ SINIF ATAMALARINI SENKRONİZE ET (EKLE + SİL)

                int okulID = Convert.ToInt32(cmbGuncelOkullar.SelectedValue);
                int dersID = Convert.ToInt32(cmbGuncelBranslar.SelectedValue);

                // UI'daki seçili sınıflar
                List<int> seciliSiniflar = clbGuncelSiniflar.CheckedItems
                    .Cast<SinifItem>()
                    .Select(x => x.ID)
                    .ToList();

                // DB'deki mevcut sınıflar
                List<int> dbSiniflar = new List<int>();

                // 1️⃣ Mevcut tüm eski sınıfları sil
                using (SqlCommand cmdDelete = new SqlCommand(
                    @"DELETE FROM OKULLAR_SINIFLAR_DERSLER_OGRETMENLER
      WHERE OgretmenID=@ogretmenID", conn))
                {
                    cmdDelete.Parameters.AddWithValue("@ogretmenID", ogretmenID);
                    cmdDelete.ExecuteNonQuery();
                }

                // 2️⃣ Yeni seçilen sınıfları ekle
                foreach (int sinifID in seciliSiniflar)
                {
                    string insertSql = @"INSERT INTO OKULLAR_SINIFLAR_DERSLER_OGRETMENLER
                         (OgretmenID, OkulID, SinifID, DersID)
                         VALUES (@ogretmenID, @okulID, @sinifID, @dersID)";
                    using (SqlCommand cmd = new SqlCommand(insertSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ogretmenID", ogretmenID);
                        cmd.Parameters.AddWithValue("@okulID", okulID);
                        cmd.Parameters.AddWithValue("@sinifID", sinifID);
                        cmd.Parameters.AddWithValue("@dersID", dersID);
                        cmd.ExecuteNonQuery();
                    }
                }

            }

            MessageBox.Show("Öğretmen bilgileri başarıyla güncellendi.");

            LoadOgretmenler();
            AktiflikRenkleriniUygula();

            // 🔵 GÜNCELLENEN ÖĞRETMENİ TEKRAR SEÇ
            foreach (DataGridViewRow r in dgvOgretmenler.Rows)
            {
                if (Convert.ToInt32(r.Cells["OgretmenID"].Value) == ogretmenID)
                {
                    r.Selected = true;
                    dgvOgretmenler.FirstDisplayedScrollingRowIndex = r.Index;
                    break;
                }
            }

            // ✔️ SINIF LİSTESİ DOĞRU YENİDEN YÜKLENSİN
            LoadSiniflarForCheckedList();

        }



        private void btnOgretmenSil_Click(object sender, EventArgs e)
        {
            if (dgvOgretmenler.SelectedRows.Count == 0) { MessageBox.Show("Lütfen sistemden silmek istediğiniz öğretmeni tablodan seçin!"); return; }
            int ogretmenID = 0;

            if (dgvOgretmenler.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvOgretmenler.SelectedRows[0];
                if (dgvOgretmenler.Columns.Contains("OgretmenID"))
                    ogretmenID = Convert.ToInt32(row.Cells["OgretmenID"].Value);

                else if (dgvOgretmenler.Columns.Contains("ID")) ogretmenID = Convert.ToInt32(row.Cells["ID"].Value);

                else return; // ID yoksa işlemi durdur

            }

            DialogResult result = MessageBox.Show("Seçtiğiniz öğretmeni silmek istediğinize emin misiniz?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string deleteOS = "DELETE FROM OKULLAR_SINIFLAR_DERSLER_OGRETMENLER WHERE OgretmenID=@ogretmenID";
                string deletegiris = "DELETE FROM OGRETMEN_GIRIS WHERE OgretmenID=@ogretmenID";
                string deleteNotlar = "DELETE FROM NOTLAR WHERE OgretmenID=@ogretmenID";
                string deleteSQL = "DELETE FROM OGRETMENLER WHERE OgretmenID=@ogretmenID";

                using (SqlCommand komut = new SqlCommand(deleteOS, connection))
                {
                    komut.Parameters.AddWithValue("@ogretmenID", ogretmenID);
                    komut.ExecuteNonQuery();
                }

                using (SqlCommand komut = new SqlCommand(deletegiris, connection))
                {
                    komut.Parameters.AddWithValue("@ogretmenID", ogretmenID);
                    komut.ExecuteNonQuery();
                }

                using (SqlCommand komut = new SqlCommand(deleteNotlar, connection))
                {
                    komut.Parameters.AddWithValue("@ogretmenID", ogretmenID);
                    komut.ExecuteNonQuery();
                }

                using (SqlCommand komut = new SqlCommand(deleteSQL, connection))
                {
                    komut.Parameters.AddWithValue("@ogretmenID", ogretmenID);
                    komut.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Öğretmen sistemden başarıyla silindi.");
            LoadOgretmenler();
            AktiflikRenkleriniUygula();
        }

        private void LoadSiniflarForCheckedList()
        {
            // Eventleri kapat
            clbGuncelSiniflar.ItemCheck -= clbGuncelSiniflar_ItemCheck;

            clbGuncelSiniflar.BeginUpdate();
            clbGuncelSiniflar.Items.Clear();

            if (cmbGuncelOkullar.SelectedValue == null || cmbGuncelBranslar.SelectedValue == null)
            {
                clbGuncelSiniflar.EndUpdate();
                clbGuncelSiniflar.ItemCheck += clbGuncelSiniflar_ItemCheck;
                return;
            }

            if (!int.TryParse(cmbGuncelOkullar.SelectedValue.ToString(), out int okulID) ||
                !int.TryParse(cmbGuncelBranslar.SelectedValue.ToString(), out int dersID))
            {
                clbGuncelSiniflar.EndUpdate();
                clbGuncelSiniflar.ItemCheck += clbGuncelSiniflar_ItemCheck;
                return;
            }

            int ogretmenID = dgvOgretmenler.SelectedRows.Count > 0
                ? Convert.ToInt32(dgvOgretmenler.SelectedRows[0].Cells["OgretmenID"].Value)
                : -1;

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();

                // Sadece o okul-ders için atanmış sınıflar
                string sql = @"
            SELECT s.SinifID, s.SinifAd
            FROM SINIFLAR s
            INNER JOIN OKULLAR_SINIFLAR_DERSLER osd ON s.SinifID = osd.SinifID
            WHERE osd.OkulID = @okulID AND osd.DersID = @dersID
            ORDER BY s.SinifAd";

                List<SinifItem> siniflar = new List<SinifItem>();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@okulID", okulID);
                    cmd.Parameters.AddWithValue("@dersID", dersID);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            siniflar.Add(new SinifItem { ID = dr.GetInt32(0), Name = dr.GetString(1) });
                        }
                    }
                }

                // CLB’ye ekle
                foreach (var s in siniflar)
                {
                    clbGuncelSiniflar.Items.Add(s, false);
                }

                // Mevcut öğretmenin atanmış sınıflarını işaretle
                if (ogretmenID != -1)
                {
                    string sqlChecked = @"
                SELECT SinifID 
                FROM OKULLAR_SINIFLAR_DERSLER_OGRETMENLER 
                WHERE OgretmenID = @ogretmenID 
                  AND OkulID = @okulID
                  AND DersID = @dersID";

                    using (SqlCommand cmdChecked = new SqlCommand(sqlChecked, conn))
                    {
                        cmdChecked.Parameters.AddWithValue("@ogretmenID", ogretmenID);
                        cmdChecked.Parameters.AddWithValue("@okulID", okulID);
                        cmdChecked.Parameters.AddWithValue("@dersID", dersID);

                        using (SqlDataReader dr2 = cmdChecked.ExecuteReader())
                        {
                            while (dr2.Read())
                            {
                                int sinifID = dr2.GetInt32(0);
                                for (int i = 0; i < clbGuncelSiniflar.Items.Count; i++)
                                {
                                    var item = (SinifItem)clbGuncelSiniflar.Items[i];
                                    if (item.ID == sinifID)
                                    {
                                        clbGuncelSiniflar.SetItemChecked(i, true);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            clbGuncelSiniflar.EndUpdate();

            // Eventleri tekrar aç
            clbGuncelSiniflar.ItemCheck += clbGuncelSiniflar_ItemCheck;
        }

        private void dgvOgretmenler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvOgretmenler.Rows[e.RowIndex];

            if (dgvOgretmenler.Columns.Contains("CalistigiOkul"))
                cmbGuncelOkullar.SelectedValue = row.Cells["CalistigiOkul"].Value;
            else if (dgvOgretmenler.Columns.Contains("OkulID"))
                cmbGuncelOkullar.SelectedValue = row.Cells["OkulID"].Value;

            // Brans ID sütunu
            if (dgvOgretmenler.Columns.Contains("Brans"))
                cmbGuncelBranslar.SelectedValue = row.Cells["Brans"].Value;
            else if (dgvOgretmenler.Columns.Contains("BransID"))
                cmbGuncelBranslar.SelectedValue = row.Cells["BransID"].Value;

            txtGuncelEmail.Text = row.Cells["E-posta"].Value.ToString();
            txtGuncelTelefon.Text = row.Cells["Telefon"].Value.ToString();
            txtGuncelKullaniciAdi.Text = row.Cells["Kullanıcı Adı"].Value.ToString();

            dgvOgretmenler.Columns["OgretmenID"].Visible = false;


            LoadSiniflarForCheckedList();

        }



        private void clbGuncelSiniflar_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue != CheckState.Checked) return;

            var item = (SinifItem)clbGuncelSiniflar.Items[e.Index];
            int sinifID = item.ID;
            int okulID = Convert.ToInt32(cmbGuncelOkullar.SelectedValue);
            int dersID = Convert.ToInt32(cmbGuncelBranslar.SelectedValue);
            int ogretmenID = dgvOgretmenler.SelectedRows.Count > 0
                             ? Convert.ToInt32(dgvOgretmenler.SelectedRows[0].Cells["OgretmenID"].Value)
                             : 0;

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                string sql = @"SELECT COUNT(*)
FROM OKULLAR_SINIFLAR_DERSLER_OGRETMENLER osd
JOIN OGRETMENLER o ON o.OgretmenID = osd.OgretmenID
LEFT JOIN OGRETMEN_GIRIS og ON o.OgretmenID = og.OgretmenID
WHERE osd.SinifID=@sinifID
  AND osd.DersID=@dersID
  AND osd.OkulID=@okulID
  AND og.Aktif = 1
  AND o.OgretmenID<>@ogretmenID
";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@sinifID", sinifID);
                    cmd.Parameters.AddWithValue("@dersID", dersID);
                    cmd.Parameters.AddWithValue("@okulID", okulID);
                    cmd.Parameters.AddWithValue("@ogretmenID", ogretmenID);

                    if ((int)cmd.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Bu sınıfa aynı dersten başka bir öğretmen zaten atanmış! Seçim iptal edildi.");
                        e.NewValue = CheckState.Unchecked;
                    }
                }
            }
        }

        // Telefon alanı sadece rakam ve max 13 karakter
        private void txtOgretmenTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '+')
                e.Handled = true;

            if (txtOgretmenTelefon.Text.Length >= 13 && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void txtGuncelTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            if (txtGuncelTelefon.Text.Length >= 13) e.Handled = true;
        }

        private void cmbOkullar_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBranslarForSelectedOkul();
            LoadSiniflarForAdd(); // Sınıfları da güncelle
        }

        private void cmbGuncelOkullar_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGuncelBranslarForSelectedOkul();
            LoadSiniflarForCheckedList(); // clb'yi güncelle
        }

        private void LoadBranslarForSelectedOkul()
        {
            if (cmbOkullar.SelectedValue == null)
            {
                cmbBranslar.DataSource = null;
                cmbBranslar.Items.Clear();
                cmbBranslar.Text = "";
                return;
            }

            int okulID = Convert.ToInt32(cmbOkullar.SelectedValue);

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                string sql = @"SELECT DISTINCT d.DersID, d.DersAd
                       FROM DERSLER d
                       JOIN OKULLAR_SINIFLAR_DERSLER osd ON osd.DersID = d.DersID
                       WHERE osd.OkulID = @okulID";
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@okulID", okulID);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        cmbBranslar.DataSource = null;
                        cmbBranslar.Items.Clear();
                        cmbBranslar.Text = "";
                        return;
                    }

                    cmbBranslar.ValueMember = "DersID";
                    cmbBranslar.DisplayMember = "DersAd";
                    cmbBranslar.DataSource = dt;
                }
            }
        }

        private void LoadGuncelBranslarForSelectedOkul()
        {
            if (cmbGuncelOkullar.SelectedValue == null)
            {
                cmbGuncelBranslar.DataSource = null;
                return;
            }


            int okulID = Convert.ToInt32(cmbGuncelOkullar.SelectedValue);

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                string sql = @"SELECT DISTINCT d.DersID, d.DersAd
                       FROM DERSLER d
                       JOIN OKULLAR_SINIFLAR_DERSLER osd ON osd.DersID = d.DersID
                       WHERE osd.OkulID = @okulID";

                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@okulID", okulID);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbGuncelBranslar.DataSource = null; // önce temizle
                    cmbGuncelBranslar.Items.Clear();

                    if (dt.Rows.Count > 0)
                    {
                        cmbGuncelBranslar.DataSource = dt;
                        cmbGuncelBranslar.ValueMember = "DersID";
                        cmbGuncelBranslar.DisplayMember = "DersAd";
                        cmbGuncelBranslar.SelectedIndex = 0; // ilk değeri seç
                    }
                }
            }
        }

        private void LoadSiniflarForAdd()
        {
            clbSiniflar.Items.Clear();
            if (cmbOkullar.SelectedValue == null || cmbBranslar.SelectedValue == null) return;

            int okulID = Convert.ToInt32(cmbOkullar.SelectedValue);
            int dersID = Convert.ToInt32(cmbBranslar.SelectedValue);

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                string sql = @"SELECT s.SinifID, s.SinifAd 
                       FROM SINIFLAR s
                       JOIN OKULLAR_SINIFLAR_DERSLER osd ON osd.SinifID = s.SinifID
                       WHERE osd.OkulID = @okulID AND osd.DersID = @dersID";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@okulID", okulID);
                    cmd.Parameters.AddWithValue("@dersID", dersID);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            clbSiniflar.Items.Add(new SinifItem { ID = dr.GetInt32(0), Name = dr.GetString(1) }, false);

                        }


                    }
                }
            }
        }

        private void LoadGuncelSiniflarForAdd()
        {
            clbGuncelSiniflar.Items.Clear();
            if (cmbGuncelOkullar.SelectedValue == null || cmbGuncelBranslar.SelectedValue == null) return;

            int okulID = Convert.ToInt32(cmbGuncelOkullar.SelectedValue);
            int dersID = Convert.ToInt32(cmbGuncelBranslar.SelectedValue);

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                string sql = @"SELECT s.SinifID, s.SinifAd 
                       FROM SINIFLAR s
                       JOIN OKULLAR_SINIFLAR_DERSLER osd ON osd.SinifID = s.SinifID
                       WHERE osd.OkulID = @okulID AND osd.DersID = @dersID";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@okulID", okulID);
                    cmd.Parameters.AddWithValue("@dersID", dersID);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            clbGuncelSiniflar.Items.Add(new SinifItem { ID = dr.GetInt32(0), Name = dr.GetString(1) }, false);
                        }

                    }
                }
            }
        }

        private void cmbBranslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSiniflarForAdd();
        }

        private void cmbGuncelBranslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSiniflarForCheckedList();
        }

        private void txtFilterOgretmen_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string query = @"SELECT 
    o.OgretmenID,
    o.Ad AS 'Adı',
    o.Soyad AS 'Soyadı',
    o.Brans AS 'BransID',
    d.DersAd AS 'Branşı',
    o.CalistigiOkul AS 'OkulID',
    ok.OkulAd AS 'Çalıştığı Okul',
    STRING_AGG(s.SinifAd, ', ') AS 'Girdiği Siniflar',
    o.Email AS 'E-posta',
    o.Telefon,
    ISNULL(og.Aktif, 0) AS Aktif

FROM OGRETMENLER o
JOIN OKULLAR ok ON o.CalistigiOkul = ok.OkulID
JOIN DERSLER d ON o.Brans = d.DersID
LEFT JOIN OKULLAR_SINIFLAR_DERSLER_OGRETMENLER osdo
       ON osdo.OgretmenID = o.OgretmenID
LEFT JOIN SINIFLAR s ON osdo.SinifID = s.SinifID
LEFT JOIN OGRETMEN_GIRIS og 
       ON og.OgretmenID = o.OgretmenID

WHERE o.Ad LIKE @p1 OR o.Soyad LIKE @p1 
      OR d.DersAd LIKE @p1 OR ok.OkulAd LIKE @p1 
      OR s.SinifAd LIKE @p1  
      OR o.Email LIKE @p1 OR o.Telefon LIKE @p1
GROUP BY o.OgretmenID, o.Ad, o.Soyad, o.Brans, d.DersAd, o.CalistigiOkul, ok.OkulAd, o.Email, o.Telefon, og.Aktif

ORDER BY o.Ad, o.Soyad";
                ;
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@p1", "%" + txtFilterOgretmen.Text + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvOgretmenler.DataSource = null;

                    dgvOgretmenler.DataSource = dt;

                    dgvOgretmenler.Columns["OgretmenID"].Visible = false;
                    dgvOgretmenler.Columns["BransID"].Visible = false;
                    dgvOgretmenler.Columns["OkulID"].Visible = false;

                }
            }

            foreach (DataGridViewRow row in dgvOgretmenler.Rows)
            {
                row.Cells["Aktif"].Tag = row.Cells["Aktif"].Value;
                bool aktif = Convert.ToBoolean(row.Cells["Aktif"].Value);
                row.DefaultCellStyle.BackColor = aktif ? Color.White : Color.LightGray;
            }

            AktiflikRenkleriniUygula();
        }

        private void dgvOgretmenler_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvOgretmenler.IsCurrentCellDirty)
                dgvOgretmenler.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void btnAktiflikKaydet_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show(
                    "Aktif/Pasif değişiklikleri kaydedilsin mi?",
                    "Onay",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (onay != DialogResult.Yes)
            {
                return;
            }

            using SqlConnection con = new SqlConnection(conString);

            con.Open();
            SqlTransaction tr = con.BeginTransaction();

            try
            {
                bool degisiklikVar = false;

                foreach (DataGridViewRow row in dgvOgretmenler.Rows)
                {
                    bool eski = row.Cells["Aktif"].Tag != null
                    && Convert.ToBoolean(row.Cells["Aktif"].Tag);

                    bool yeni = row.Cells["Aktif"].Value != DBNull.Value
                                && Convert.ToBoolean(row.Cells["Aktif"].Value);


                    if (eski != yeni)
                    {
                        degisiklikVar = true;

                        SqlCommand cmd = new SqlCommand(
                            "UPDATE OGRETMEN_GIRIS SET Aktif=@a WHERE OgretmenID=@id",
                            con, tr);

                        cmd.Parameters.AddWithValue("@a", yeni);
                        cmd.Parameters.AddWithValue("@id", row.Cells["OgretmenID"].Value);
                        cmd.ExecuteNonQuery();
                    }
                }

                if (!degisiklikVar)
                {
                    MessageBox.Show("Herhangi bir aktiflik değişimi yapılmadı.");
                    tr.Rollback();
                    return;
                }

                

                tr.Commit();
                MessageBox.Show("Aktif/Pasif değişiklikleri kaydedildi.");
                LoadOgretmenler();
                AktiflikRenkleriniUygula();
            }
            catch
            {
                tr.Rollback();
                MessageBox.Show("Aktiflik kaydedilirken hata oluştu.");
            }
        }

        private void AktiflikRenkleriniUygula()
        {
            foreach (DataGridViewRow row in dgvOgretmenler.Rows)
            {
                bool aktif = row.Cells["Aktif"].Value != DBNull.Value
                             && Convert.ToBoolean(row.Cells["Aktif"].Value);

                row.DefaultCellStyle.BackColor =
                    aktif ? Color.White : Color.LightGray;

                row.Cells["Aktif"].Tag = aktif;
            }
        }

        private void txtOgretmenTelefon_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtOgretmenTelefon.Text, @"^\+90\d{10}$"))
            {
                MessageBox.Show("Telefon numarası +905XXXXXXXXX formatında olmalıdır.");
            }
        }

        private void txtGuncelTelefon_Leave(object sender, EventArgs e)
        {

            if (!Regex.IsMatch(txtGuncelTelefon.Text, @"^\+90\d{10}$"))
            {
                MessageBox.Show("Telefon numarası +905XXXXXXXXX formatında olmalıdır.");
            }
        }

        private bool EmailGecerliMi(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }

        private void txtOgretmenEmail_Leave(object sender, EventArgs e)
        {
            if (!EmailGecerliMi(txtOgretmenEmail.Text.Trim()))
            {
                MessageBox.Show("Geçerli bir e-posta adresi giriniz.");
            }
        }

        private void txtGuncelEmail_Leave(object sender, EventArgs e)
        {
            if (!EmailGecerliMi(txtGuncelEmail.Text.Trim()))
            {
                MessageBox.Show("Geçerli bir e-posta adresi giriniz.");
            }
        }
    }

    public class SinifItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name; // sadece sınıf adını göster
        }
    }

}
