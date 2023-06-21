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

namespace Kutuphane_Proje
{
    public partial class FrmEscrowBook : Form
    {
        public FrmEscrowBook()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        //Kitap İd Arama
        private void bSearchBookId_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Books where id like'%" + tbBookid.Text + "%'", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            bgl.baglanti().Close();
        }

        private void FrmEscrowBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneProjeDataSet9.Tbl_RequestedBooks' table. You can move, or remove it, as needed.
            this.tbl_RequestedBooksTableAdapter.Fill(this.kutuphaneProjeDataSet9.Tbl_RequestedBooks);
            // TODO: This line of code loads data into the 'kutuphaneProjeDataSet8.Tbl_Students' table. You can move, or remove it, as needed.
            this.tbl_StudentsTableAdapter.Fill(this.kutuphaneProjeDataSet8.Tbl_Students);
            // TODO: This line of code loads data into the 'kutuphaneProjeDataSet7.Tbl_Books' table. You can move, or remove it, as needed.
            this.tbl_BooksTableAdapter.Fill(this.kutuphaneProjeDataSet7.Tbl_Books);
        }
        //Öğrenci Arama
        private void bSearchStudentNum_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Students where StudentNo like'%" + tbStudentNum.Text + "%'", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            bgl.baglanti().Close();
        }
        //Onay Sistemi
        private void button3_Click(object sender, EventArgs e)
        {
            // Kullanıcının maksimum kitap talep etme limitini veritabanından alın
            SqlCommand limitCommand = new SqlCommand("SELECT How_many_books FROM Tbl_UserSettings WHERE StudentMail = @StudentMail AND StudentNo = @StudentNo", bgl.baglanti());
            limitCommand.Parameters.AddWithValue("@StudentNo", texbStudentNo.Text);
            limitCommand.Parameters.AddWithValue("@StudentMail", texbStudentMail.Text);
            int maxBookLimit = Convert.ToInt32(limitCommand.ExecuteScalar());
            // Kullanıcının mevcut kitap sayısını sorgulayın
            SqlCommand countCommand = new SqlCommand("SELECT COUNT(*) FROM Tbl_GivenBooksStudent1 WHERE StudentMail = @StudentMail AND StudentNumber = @StudentNumber", bgl.baglanti());
            countCommand.Parameters.AddWithValue("@StudentMail", texbStudentMail.Text);
            countCommand.Parameters.AddWithValue("@StudentNumber", texbStudentNo.Text);
            int bookCount = Convert.ToInt32(countCommand.ExecuteScalar());

            if (bookCount >= maxBookLimit)
            {
                MessageBox.Show("The student has reached the maximum capacity she/he can take.");
                return;
            }
            SqlCommand komut = new SqlCommand("Select * From Tbl_Books where id=@p1 AND Book_Count > 0", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", texbBookId.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                int id = dr.GetInt32(0);
                string idString = id.ToString();
                string Book_Name = dr.GetString(1);
                string Book_Page = dr.GetString(2);
                string Book_Category = dr.GetString(3);
                string Book_Author = dr.GetString(4);
                string StudentNumber = texbStudentNo.Text;
                string StudentMail = texbStudentMail.Text;
                DateTime Date_Of_Issue = dateTimePicker1.Value;
                DateTime Date_Of_Back = Date_Of_Issue.AddDays(7);

                string Date_Of_Issue_String = Date_Of_Issue.ToString("yyyy-MM-dd");
                string Date_Of_Back_String = Date_Of_Back.ToString("yyyy-MM-dd");

                SqlCommand komut2 = new SqlCommand("SET IDENTITY_INSERT Tbl_GivenBooksStudent1 ON; " +
                    "Insert into Tbl_GivenBooksStudent1 (id, Book_Name, Book_Page, Book_Category, Book_Author, StudentNumber, StudentMail, Date_Of_Issue, Date_Of_Back) " +
                    "values (@Book_Id, @Book_Name, @Book_Page, @Book_Category, @Book_Author, @StudentNumber, @StudentMail, @Date_Of_Issue, @Date_Of_Back)", bgl.baglanti());
                komut2.Parameters.AddWithValue("@Book_Id", id);
                komut2.Parameters.AddWithValue("@Book_Name", Book_Name);
                komut2.Parameters.AddWithValue("@Book_Page", Book_Page);
                komut2.Parameters.AddWithValue("@Book_Category", Book_Category);
                komut2.Parameters.AddWithValue("@Book_Author", Book_Author);
                komut2.Parameters.AddWithValue("@StudentNumber", StudentNumber);
                komut2.Parameters.AddWithValue("@StudentMail", StudentMail);
                komut2.Parameters.AddWithValue("@Date_Of_Issue", Date_Of_Issue_String);
                komut2.Parameters.AddWithValue("@Date_Of_Back", Date_Of_Back_String);
                komut2.ExecuteNonQuery();
                MessageBox.Show("Successfully Escrowed");
                SqlCommand guncelle = new SqlCommand("Update Tbl_Books Set Book_Count = Book_Count -1 Where id=@p2", bgl.baglanti());
                guncelle.Parameters.AddWithValue("@p2", texbBookId.Text);
                guncelle.ExecuteNonQuery();
                //silme
                SqlCommand sil = new SqlCommand("Delete From Tbl_RequestedBooks Where id=@bu", bgl.baglanti());
                sil.Parameters.AddWithValue("@bu", texRequestId.Text);
                sil.ExecuteNonQuery();
                //Anında Güncelleme Requestler
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_RequestedBooks", bgl.baglanti());
                da.Fill(dt);
                dataGridView3.DataSource = dt;
                //Anında Güncelleme Kitaplar
                DataTable dta = new DataTable();
                SqlDataAdapter dab = new SqlDataAdapter("SELECT * FROM Tbl_Books", bgl.baglanti());
                dab.Fill(dta);
                dataGridView1.DataSource = dta;
            }
            else
            {
                MessageBox.Show("Book Not Found or There are not enough books");
            }
        }
        //admin girişe dönüş
        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminMain fr = new FrmAdminMain();
            fr.Show();
            this.Hide();
        }
        //Otofill
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Sadece satır tıklamalarını kontrol etmek için
            {
                DataGridViewRow row = dataGridView3.Rows[e.RowIndex];
                texRequestId.Text = row.Cells["id"].Value.ToString();
                texbBookId.Text = row.Cells["Book_Id"].Value.ToString();
                texbStudentNo.Text = row.Cells["StudentNumber"].Value.ToString();
                texbStudentMail.Text = row.Cells["StudentMail"].Value.ToString();
            }
        }

        
        //Reddet
        private void bDecline_Click_1(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("Delete From Tbl_RequestedBooks Where id=@bu1", bgl.baglanti());
            sil.Parameters.AddWithValue("@bu1", texRequestId.Text);
            DataTable dt = new DataTable();
            
            sil.ExecuteNonQuery();
            //Güncelleme
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_RequestedBooks", bgl.baglanti());
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            MessageBox.Show("Successfully Declined");
            
        }
       

    }
        
}
