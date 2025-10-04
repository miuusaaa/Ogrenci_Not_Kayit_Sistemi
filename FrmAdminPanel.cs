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
            panelContent.Controls.Clear();
            FrmOgrenciListe frm = new FrmOgrenciListe()
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
               FormBorderStyle = FormBorderStyle.None
            };
            panelContent.Controls.Add(frm);
            frm.Show();
        
        }
    }
}

