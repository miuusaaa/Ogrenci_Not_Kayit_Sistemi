namespace Öğrenci_Not_Kayıt_Sistemi
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void btnOgrGiris_Click(object sender, EventArgs e)
        {
            FrmOgrenciGiris frm = new FrmOgrenciGiris();
            frm.Show();
            this.Hide();
        }

        private void btnOgmGiris_Click(object sender, EventArgs e)
        {
            FrmOgretmenGiris frm = new FrmOgretmenGiris();
            frm.Show();
            this.Hide();
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            FrmAdminGiris frm = new FrmAdminGiris();
            frm.Show();
            this.Hide();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //formu kullanıcı büyütmesin istiyorsan kullan.
        }
    }
}
