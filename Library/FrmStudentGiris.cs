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
    public partial class FrmStudentGiris : Form
    {
        public FrmStudentGiris()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl=new sqlbaglanti();  
        private void linkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FromStudentEntrence fr = new FromStudentEntrence();
            fr.Show();
        }
        //Giriş yap
        private void btnSignin_Click(object sender, EventArgs e)
        {

            // İlk olarak, başarısız giriş denemelerini kontrol etmek için gereken değişkenleri tanımlayalım
            int maxLoginAttempts = 5; // Maksimum giriş deneme sayısı
            int blockDurationMinutes = 10; // Engelleme süresi (dakika)

            // Önce başarısız giriş denemelerini kontrol edelim
            SqlCommand checkAttemptsCommand = new SqlCommand("SELECT COUNT(*) FROM Tbl_LoginTry WHERE AttemptTime >= @blockStartTime AND StudentNumEmail = @studentNumEmail", bgl.baglanti());
            checkAttemptsCommand.Parameters.AddWithValue("@blockStartTime", DateTime.Now.AddMinutes(-blockDurationMinutes));
            checkAttemptsCommand.Parameters.AddWithValue("@studentNumEmail", texbStudentNumEmail.Text);
            int loginAttempts = (int)checkAttemptsCommand.ExecuteScalar();

            if (loginAttempts >= maxLoginAttempts)
            {
                MessageBox.Show($"Too many failed login attempts. Please try again after {blockDurationMinutes} minutes.");
                return;
            }

            // Eğer engelleme süresi içinde değilse, giriş işlemini devam ettirelim
            SqlCommand loginCommand = new SqlCommand("SELECT * FROM Tbl_Students WHERE (StudentMail=@p1 OR StudentNo=@p1) AND StudentPassword=@p2", bgl.baglanti());
            loginCommand.Parameters.AddWithValue("@p1", texbStudentNumEmail.Text);
            loginCommand.Parameters.AddWithValue("@p2", PasswordHasher.returnUserPassword(texbPassword.Text));
            SqlDataReader dr = loginCommand.ExecuteReader();
            if (dr.Read())
            {
                FrmTeacherStudentPreFace fr = new FrmTeacherStudentPreFace();
                fr.emailorstudentnum = texbStudentNumEmail.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                // Başarısız giriş denemesi olduğunda, Tbl_LoginTry tablosuna bir kayıt ekleyelim
                SqlCommand insertAttemptCommand = new SqlCommand("INSERT INTO Tbl_LoginTry (AttemptTime, StudentNumEmail, FailedAttempts) VALUES (@attemptTime, @studentNumEmail, 1)", bgl.baglanti());
                insertAttemptCommand.Parameters.AddWithValue("@attemptTime", DateTime.Now);
                insertAttemptCommand.Parameters.AddWithValue("@studentNumEmail", texbStudentNumEmail.Text);
                insertAttemptCommand.ExecuteNonQuery();

                MessageBox.Show("Invalid StudentNum/Email & Password");
            }

            bgl.baglanti().Close();
        }

    }
        
}
