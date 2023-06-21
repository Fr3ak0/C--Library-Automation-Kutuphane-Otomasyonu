using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Globalization;
using System.Net;

namespace Kutuphane_Proje
{
    public partial class FrmTeacherStudentPreFace : Form
    {
        
        public FrmTeacherStudentPreFace()
        {
            InitializeComponent();
            //Bildirim sistemi
            SqlCommand command = new SqlCommand("SELECT * FROM Tbl_GivenBooksStudent1 WHERE Date_Of_Back < @CurrentDate", bgl.baglanti());
            command.Parameters.AddWithValue("@CurrentDate", DateTime.Now.Date);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentNumber = reader.GetString(5);
                string studentMail = reader.GetString(6);
                DateTime notificationDate = DateTime.Now.Date;
                int bookid = reader.GetInt16(0);

                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM Tbl_Notifications WHERE StudentNumber = @StudentNumber AND Book_Id = @Book_Id", bgl.baglanti());
                checkCommand.Parameters.AddWithValue("@StudentNumber", studentNumber);
                checkCommand.Parameters.AddWithValue("@Book_Id", bookid);

                int notificationCount = (int)checkCommand.ExecuteScalar();

                if (notificationCount == 0)
                {
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Tbl_Notifications (Message, StudentNumber, StudentMail, Notification_date, Book_Id) VALUES (@Message, @StudentNumber, @StudentMail, @NotificationDate, @Book_Id)", bgl.baglanti());
                    insertCommand.Parameters.AddWithValue("@Message", "The return date has passed, please return the book.");
                    insertCommand.Parameters.AddWithValue("@StudentNumber", studentNumber);
                    insertCommand.Parameters.AddWithValue("@StudentMail", studentMail);
                    insertCommand.Parameters.AddWithValue("@NotificationDate", notificationDate);
                    insertCommand.Parameters.AddWithValue("@Book_Id", bookid);
                    insertCommand.ExecuteNonQuery();
                }
            }


        }

       

        sqlbaglanti bgl = new sqlbaglanti();
        //Kitap ad arama
        private void bSearchBookName_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Books where Book_Name like'%" + texbBookName.Text + "%'", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            bgl.baglanti().Close();
        }
        //Kitap Kategori Arama
        private void bSearchCategory_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Books where Category like'%" + texbCategory.Text + "%'", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            bgl.baglanti().Close();
        }
        //Kitap Yazar Arama
        private void bSearchAuthor_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Books where Book_Author like'%" + texbAuthor.Text + "%'", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            bgl.baglanti().Close();
        }

        public string emailorstudentnum;

        private void FrmTeacherStudentPreFace_Load(object sender, EventArgs e)
        {
            label13.Text = emailorstudentnum;
            // TODO: This line of code loads data into the 'kutuphaneProjeDataSet6.Tbl_Books' table. You can move, or remove it, as needed.
            this.tbl_BooksTableAdapter.Fill(this.kutuphaneProjeDataSet6.Tbl_Books);
            //Ad SoyadÇekme
            SqlCommand komut = new SqlCommand("Select StudentName,StudentSurname From Tbl_Students where StudentMail=@p1 or StudentNo=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", label13.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label5.Text = dr[0] + " " + dr[1];
                bgl.baglanti().Close();
            }
            //MyBooks
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_GivenBooksStudent1 Where StudentMail='" + emailorstudentnum + "'Or StudentNumber='"+emailorstudentnum+"'" , bgl.baglanti());
            da.Fill(dt);
            dataMybooks.DataSource = dt;
            //Bildirimler
            DataTable dta = new DataTable();
            SqlDataAdapter dab = new SqlDataAdapter("Select * From Tbl_Notifications Where StudentMail='" + emailorstudentnum + "'Or StudentNumber='" + emailorstudentnum + "'", bgl.baglanti());
            dab.Fill(dta);
            dataNotification.DataSource = dta;

        }
        //Kitap Talep Etme
        private void bgetthebooks_Click(object sender, EventArgs e)
        {
            // Kullanıcının e-posta veya kullanıcı numarasını alın
            string studentMail = textBox2.Text;
            string studentNumber = texbStudenNum.Text;

            // Öğrenci numarası ve e-posta adresini doğrula
            SqlCommand verificationCommand = new SqlCommand("SELECT COUNT(*) FROM Tbl_Students WHERE StudentMail = @StudentMail AND StudentNo = @StudentNo", bgl.baglanti());
            verificationCommand.Parameters.AddWithValue("@StudentMail", studentMail);
            verificationCommand.Parameters.AddWithValue("@StudentNo", studentNumber);
            int count = Convert.ToInt32(verificationCommand.ExecuteScalar());

            if (count > 0)
            {
                // Kullanıcının maksimum kitap talep etme limitini veritabanından alın
                SqlCommand limitCommand = new SqlCommand("SELECT How_many_books FROM Tbl_UserSettings WHERE StudentMail = @StudentMail AND StudentNo = @StudentNo", bgl.baglanti());
                limitCommand.Parameters.AddWithValue("@StudentMail", studentMail);
                limitCommand.Parameters.AddWithValue("@StudentNo", studentNumber);
                int maxBookLimit = Convert.ToInt32(limitCommand.ExecuteScalar());

                // Kullanıcının mevcut kitap sayısını sorgulayın
                SqlCommand countCommand = new SqlCommand("SELECT COUNT(*) FROM Tbl_GivenBooksStudent1 WHERE StudentMail = @StudentMail AND StudentNumber = @StudentNumber", bgl.baglanti());
                countCommand.Parameters.AddWithValue("@StudentMail", studentMail);
                countCommand.Parameters.AddWithValue("@StudentNumber", studentNumber);
                int bookCount = Convert.ToInt32(countCommand.ExecuteScalar());

                SqlCommand countCommand1 = new SqlCommand("SELECT COUNT(*) FROM Tbl_RequestedBooks WHERE StudentMail = @StudentMail AND StudentNumber = @StudentNumber", bgl.baglanti());
                countCommand1.Parameters.AddWithValue("@StudentMail", studentMail);
                countCommand1.Parameters.AddWithValue("@StudentNumber", studentNumber);
                int bookCount1 = Convert.ToInt32(countCommand1.ExecuteScalar());

                // Maksimum kitap talep etme limitini kontrol edin
                if (bookCount >= maxBookLimit || bookCount1 >= maxBookLimit)
                {
                    MessageBox.Show("You have reached the maximum limit of books you can request.");
                    return;
                }

                SqlCommand checkRequestCommand = new SqlCommand("SELECT COUNT(*) FROM Tbl_RequestedBooks WHERE Book_Id = @BookId AND StudentNumber = @StudentNumber AND StudentMail = @StudentMail", bgl.baglanti());
                checkRequestCommand.Parameters.AddWithValue("@BookId", texbBookId.Text);
                checkRequestCommand.Parameters.AddWithValue("@StudentNumber", studentNumber);
                checkRequestCommand.Parameters.AddWithValue("@StudentMail", studentMail);
                int requestCount = Convert.ToInt32(checkRequestCommand.ExecuteScalar());

                if (requestCount > 0)
                {
                    MessageBox.Show("A request for this book already exists.");
                    return;
                }

                SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Books WHERE id = @p1 AND Book_Count > 0", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", texbBookId.Text);
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string Date_Of_Receipt = dateReceipt.Value.ToString("yyyy-MM-dd");

                    SqlCommand komut2 = new SqlCommand("INSERT INTO Tbl_RequestedBooks (Book_Id, StudentNumber, StudentMail, Date_Of_Receipt) VALUES (@id, @StudentNumber, @StudentMail, @Date_Of_Receipt)", bgl.baglanti());
                    komut2.Parameters.AddWithValue("@id", id);
                    komut2.Parameters.AddWithValue("@StudentNumber", studentNumber);
                    komut2.Parameters.AddWithValue("@StudentMail", studentMail);
                    komut2.Parameters.AddWithValue("@Date_Of_Receipt", Date_Of_Receipt);
                    komut2.ExecuteNonQuery();

                    MessageBox.Show("Successfully Requested");
                }
                else
                {
                    MessageBox.Show("Book Not Found or There are not enough books");
                }
            }
            else
            {
                MessageBox.Show("Invalid Student Number or Email");
            }
        }
        //0 olanları göster
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // CheckBox işaretlendiğinde Book_Count değeri 0 olan kitapları DataGridView'da göstermeme
                DataView dv = new DataView(this.kutuphaneProjeDataSet6.Tbl_Books);
                dv.RowFilter = "Book_Count <> 0";
                dataGridView2.DataSource = dv;
            }
            else
            {
                // CheckBox işareti kaldırıldığında tüm kitapları DataGridView'da gösterme
                dataGridView2.DataSource = this.kutuphaneProjeDataSet6.Tbl_Books;
            }
            dataGridView2.Refresh();
        }
        //Kitap iade
        private void bReturnBookT_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_GivenBooksStudent1 WHERE id = @p1 AND StudentNumber = @p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", texbBookIdMy.Text);
            komut.Parameters.AddWithValue("@p2", texbStdNum.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                int id = dr.GetInt16(0);
                string Book_Name = dr.GetString(1);
                string StudentNumber = dr.GetString(5);
                string StudentMail = dr.GetString(6);
                DateTime Date_Of_Issue = dr.GetDateTime(7);
                DateTime Date_Of_Back = dr.GetDateTime(8);

                SqlCommand checkReturnedCommand = new SqlCommand("SELECT COUNT(*) FROM Tbl_Returnedbooks2 WHERE id = @BookId AND StudentNumber = @StudentNumber", bgl.baglanti());
                checkReturnedCommand.Parameters.AddWithValue("@BookId", id);
                checkReturnedCommand.Parameters.AddWithValue("@StudentNumber", StudentNumber);
                int returnedCount = Convert.ToInt32(checkReturnedCommand.ExecuteScalar());

                if (returnedCount > 0)
                {
                    MessageBox.Show("The book has already been returned.");
                }
                else
                {
                    SqlCommand komut2 = new SqlCommand("SET IDENTITY_INSERT Tbl_Returnedbooks2 ON; " +
                        "INSERT INTO Tbl_Returnedbooks2 (id, Book_Name, StudentMail, StudentNumber, Date_Of_Issue, Date_Of_Back) " +
                        "VALUES (@Book_Id, @Book_Name, @StudentMail, @StudentNumber, @Date_Of_Issue, @Date_Of_Back)", bgl.baglanti());
                    komut2.Parameters.AddWithValue("@Book_Id", id);
                    komut2.Parameters.AddWithValue("@Book_Name", Book_Name);
                    komut2.Parameters.AddWithValue("@StudentMail", StudentMail);
                    komut2.Parameters.AddWithValue("@StudentNumber", StudentNumber);
                    komut2.Parameters.AddWithValue("@Date_Of_Issue", Date_Of_Issue);
                    komut2.Parameters.AddWithValue("@Date_Of_Back", Date_Of_Back);
                    komut2.ExecuteNonQuery();

                    MessageBox.Show("Successfully After Admin Approval Book will be given.");
                }
            }
            else
            {
                MessageBox.Show("Book Not Found");
            }

        }
        // " " ile başlayanı göster
        private void bStratsW_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Books WHERE Book_Name LIKE @bookName", bgl.baglanti());
            komut.Parameters.AddWithValue("@bookName", texbStartsW.Text + "%");

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView2.DataSource = ds.Tables[0];
            bgl.baglanti().Close();
        }

        
    }
}

