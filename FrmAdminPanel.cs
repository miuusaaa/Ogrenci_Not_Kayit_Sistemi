using Öğrenci_Not_Kayıt_Sistemi;
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
    public partial class FrmAdminPanel : Form
    {
        public FrmAdminPanel()
        {
            InitializeComponent();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {

            FrmOgrenciIslemleri frm = new FrmOgrenciIslemleri();
            frm.Show();

        }

        private void btnOgretmen_Click(object sender, EventArgs e)
        {
            FrmOgretmenIslemleri frm = new FrmOgretmenIslemleri();
            frm.Show();
        }

        private void btnOkul_Click(object sender, EventArgs e)
        {
            FrmOkulIslemleri frm = new FrmOkulIslemleri();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {

            Anasayfa frm = new Anasayfa();
            this.Hide();
            frm.Show();

        }

        private void btnSinif_Click(object sender, EventArgs e)
        {
            FrmSinifIslemleri frm = new FrmSinifIslemleri();
            frm.Show();
        }

        private void btnDers_Click(object sender, EventArgs e)
        {
            FrmDersIslemleri frm = new FrmDersIslemleri();
            frm.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FrmAdminIslemleri frm = new FrmAdminIslemleri();
            frm.Show();
        }

        private void FrmAdminPanel_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //formu kullanıcı büyütmesin istiyorsan kullan.
        }
    }
}

