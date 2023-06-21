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
    public partial class FromStudentEntrence : Form
    {
        public FromStudentEntrence()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl= new sqlbaglanti();

        private void bSignUp_Click(object sender, EventArgs e)
        {
            // Öğrenci var mı kontrolü
            SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM Tbl_Students WHERE StudentMail = @mail OR StudentNo = @no", bgl.baglanti());
            checkCommand.Parameters.AddWithValue("@mail", TxtMail.Text);
            checkCommand.Parameters.AddWithValue("@no", TxtStdNum.Text);
            int existingStudentCount = Convert.ToInt32(checkCommand.ExecuteScalar());

            if (existingStudentCount > 0)
            {
                MessageBox.Show("A student with the same email or student number already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int howmany = 5;
            DateTime notificationDate = DateTime.Now.Date;
            SqlCommand komut = new SqlCommand("insert into Tbl_Students (StudentName, StudentSurname, StudentMail, StudentNo, StudentPassword) values (@p1, @p2, @p3, @p4, @p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtStudentName.Text);
            komut.Parameters.AddWithValue("@p2", TxtStudentSurname.Text);
            komut.Parameters.AddWithValue("@p3", TxtMail.Text);
            komut.Parameters.AddWithValue("@p4", TxtStdNum.Text);
            komut.Parameters.AddWithValue("@p5", PasswordHasher.returnUserPassword(TxtStudentPassword.Text));
            komut.ExecuteNonQuery();
            //User settinglerin ayarlanması
            SqlCommand komut2 = new SqlCommand("insert into Tbl_UserSettings (StudentMail,StudentNo,How_many_books) values (@mail,@no,@howmany)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@mail", TxtMail.Text);
            komut2.Parameters.AddWithValue("@no", TxtStdNum.Text);
            komut2.Parameters.AddWithValue("@howmany", howmany);
            komut2.ExecuteNonQuery();
     
            bgl.baglanti().Close();
            MessageBox.Show("Sign up successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
