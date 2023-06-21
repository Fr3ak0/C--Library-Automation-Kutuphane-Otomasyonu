using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Kutuphane_Proje
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl=new sqlbaglanti();
        //Giriş yap
        private void btnSigninA_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Admin where AdminMail=@p1 and AdminPassword=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", texbEmailA.Text);
            komut.Parameters.AddWithValue("@p2", texbPasswordA.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAdminMain fr = new FrmAdminMain();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You are not admin.");
            }
            bgl.baglanti().Close();
        }
    }
}
