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
    public partial class FrmTeacherRequest : Form
    {
        public FrmTeacherRequest()
        {
            InitializeComponent();
        }

        private void FrmTeacherRequest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneProjeDataSet.Tbl_TeacherReq' table. You can move, or remove it, as needed.
            this.tbl_TeacherReqTableAdapter.Fill(this.kutuphaneProjeDataSet.Tbl_TeacherReq);

        }
        sqlbaglanti bgl=new sqlbaglanti();
        //İçeri al
        private void bGetin_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_TeacherReq where id=@p1", bgl.baglanti());
            
            komut.Parameters.AddWithValue("@p1", texbRequestid.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                string TeacherName=dr.GetString(1);
                string TeacherSurname=dr.GetString(2);
                string TeacherMail=dr.GetString(3);
                string TeacherPassword=dr.GetString(4);
                SqlCommand ekle = new SqlCommand("INSERT INTO Tbl_Teachers (TeacherName,TeacherSurname,TeacherMail,TeacherPassword) VALUES (@TeacherName,@TeacherSurname,@TeacherMail,@TeacherPassword)", bgl.baglanti());
                ekle.Parameters.AddWithValue ("@TeacherName", TeacherName);
                ekle.Parameters.AddWithValue("@TeacherSurname", TeacherSurname);
                ekle.Parameters.AddWithValue("@TeacherMail", TeacherMail);
                ekle.Parameters.AddWithValue("@TeacherPassword", TeacherPassword);
                ekle.ExecuteNonQuery();
                MessageBox.Show("Successfully Taken In");
                
            }
            SqlCommand sil = new SqlCommand("Delete From Tbl_TeacherReq Where id=@p2" ,bgl.baglanti());
            sil.Parameters.AddWithValue("@p2", texbRequestid.Text);
            sil.ExecuteNonQuery();
            // DataGridView Req güncellemesi
            DataTable dtv = new DataTable();
            SqlDataAdapter dam = new SqlDataAdapter("SELECT * FROM Tbl_TeacherReq", bgl.baglanti());
            dam.Fill(dtv);
            dataGridView1.DataSource = dtv;
        }
        //back to admin main
        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminMain fr = new FrmAdminMain();
            fr.Show();
            this.Hide();
        }
    }
}
