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
    public partial class FrmTeacherGiris : Form
    {
        public FrmTeacherGiris()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();
        private void linkRequest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_RequestRegistaration fr = new Frm_RequestRegistaration();
            fr.Show();
        }

        //giriş yap
        private void btnSignin_Click(object sender, EventArgs e)
        {
            // İlk olarak, başarısız giriş denemelerini kontrol etmek için gereken değişkenleri tanımlayalım
            int maxLoginAttempts = 5; 
            int blockDurationMinutes = 10; 

            // Önce başarısız giriş denemelerini kontrol edelim
            SqlCommand checkAttemptsCommand = new SqlCommand("SELECT COUNT(*) FROM Tbl_LoginTryTeacher WHERE AttemptTime >= @blockStartTime AND TeacherMail = @teacherMail", bgl.baglanti());
            checkAttemptsCommand.Parameters.AddWithValue("@blockStartTime", DateTime.Now.AddMinutes(-blockDurationMinutes));
            checkAttemptsCommand.Parameters.AddWithValue("@teacherMail", texbEmail.Text);
            int loginAttempts = (int)checkAttemptsCommand.ExecuteScalar();

            if (loginAttempts >= maxLoginAttempts)
            {
                MessageBox.Show($"Too many failed login attempts. Please try again after {blockDurationMinutes} minutes.");
                return;
            }

            // Eğer engelleme süresi içinde değilse, giriş işlemini devam ettirelim
            SqlCommand loginCommand = new SqlCommand("SELECT * FROM Tbl_Teachers WHERE TeacherMail=@p1 AND TeacherPassword=@p2", bgl.baglanti());
            loginCommand.Parameters.AddWithValue("@p1", texbEmail.Text);
            loginCommand.Parameters.AddWithValue("@p2", PasswordHasher.returnUserPassword(texbPassword.Text));
            SqlDataReader dr = loginCommand.ExecuteReader();
            if (dr.Read())
            {
                FrmTeacherMainFace fr = new FrmTeacherMainFace();
                fr.email = texbEmail.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                // Başarısız giriş denemesi olduğunda, Tbl_LoginTryTeacher tablosuna bir kayıt ekleyelim
                SqlCommand insertAttemptCommand = new SqlCommand("INSERT INTO Tbl_LoginTryTeacher (AttemptTime, TeacherMail, FailedAttempts) VALUES (@attemptTime, @teacherMail, 1)", bgl.baglanti());
                insertAttemptCommand.Parameters.AddWithValue("@attemptTime", DateTime.Now);
                insertAttemptCommand.Parameters.AddWithValue("@teacherMail", texbEmail.Text);
                insertAttemptCommand.ExecuteNonQuery();

                MessageBox.Show("Invalid Email & Password");
            }

            bgl.baglanti().Close();
        }

        
    }
}
