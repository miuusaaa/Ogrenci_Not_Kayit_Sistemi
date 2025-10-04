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
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        public string ogrno;

        SqlConnection connection = new SqlConnection(FrmOgrenciGiris.con);

        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            lblNo.Text = ogrno;
            
            connection.Open();
            string query = "select OB.* from OGRBILGILERI OB join OGRGIRISBILGILERI OGB ON OB.OGRID = OGB.ogrid WHERE okulno =@okulno";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@okulno",ogrno);
            SqlDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                lblAd.Text = dr[1].ToString();
                lblSoyad.Text = dr[2].ToString();
                lblS1.Text = dr[3].ToString();
                lblS2.Text = dr[4].ToString();
                lblS3.Text = dr[5].ToString();
                lblOrtalama.Text = dr[6].ToString();
                lblSonuc.Text = dr[7].ToString();
            }
            connection.Close();
        }
    }
}
