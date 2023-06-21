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
    public partial class Frm_RequestRegistaration : Form
    {
        public Frm_RequestRegistaration()
        {
            InitializeComponent();
        }
        
        sqlbaglanti bgl=new sqlbaglanti();  
        //Kayıt olma
        private void bSignUp_Click(object sender, EventArgs e)
        {

            string teacherName = texbTeacherName.Text;
            string teacherSurname = texbTeacherSurname.Text;
            string teacherMail = texbMail.Text;
            string teacherPassword = PasswordHasher.returnUserPassword(texbTeacherPassword.Text);
            //Kontrol etme
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Tbl_Teachers WHERE TeacherMail = @mail OR EXISTS (SELECT 1 FROM Tbl_TeacherReq WHERE TeacherMail = @mail)", bgl.baglanti());
            command.Parameters.AddWithValue("@mail", teacherMail);

            int count = (int)command.ExecuteScalar();
            bgl.baglanti().Close();

            if (count > 0)
            {
                MessageBox.Show("A user with the same email already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Admin Onayına gönderme
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_TeacherReq (TeacherName, TeacherSurname, TeacherMail, TeacherPassword) VALUES (@p1, @p2, @p3, @p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", teacherName);
            komut.Parameters.AddWithValue("@p2", teacherSurname);
            komut.Parameters.AddWithValue("@p3", teacherMail);
            komut.Parameters.AddWithValue("@p4", teacherPassword);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Requested Succesfully. After Admin Approval, You Can Sign In", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
