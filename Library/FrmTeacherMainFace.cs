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
    public partial class FrmTeacherMainFace : Form
    {
        public FrmTeacherMainFace()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        public string email;
        private void FrmTeacherMainFace_Load(object sender, EventArgs e)
        {
            label3.Text = email;
            // TODO: This line of code loads data into the 'kutuphaneProjeDataSet5.Tbl_Books' table. You can move, or remove it, as needed.
            this.tbl_BooksTableAdapter.Fill(this.kutuphaneProjeDataSet5.Tbl_Books);
            //Ad Soyad Çekme
            SqlCommand komut = new SqlCommand("Select TeacherName,TeacherSurname From Tbl_Teachers where TeacherMail=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", label3.Text);
            SqlDataReader dr= komut.ExecuteReader();
            while (dr.Read())
            {
                label11.Text = dr[0] + " " + dr[1];
                bgl.baglanti().Close();
            }
            //MyBooks
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("Select * From Tbl_GivenBooksTeacher1 Where TeacherMail='"+email+"'",bgl.baglanti());
            da.Fill(dt);
            dataMybooks.DataSource = dt;

        }
        //0 olanları gösterme
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // CheckBox işaretlendiğinde Book_Count değeri 0 olan kitapları DataGridView'da göstermeme
                DataView dv = new DataView(this.kutuphaneProjeDataSet5.Tbl_Books);
                dv.RowFilter = "Book_Count <> 0";
                dataGridViewTT.DataSource = dv;
            }
            else
            {
                // CheckBox işareti kaldırıldığında tüm kitapları DataGridView'da gösterme
                dataGridViewTT.DataSource = this.kutuphaneProjeDataSet5.Tbl_Books;
            }
            dataGridViewTT.Refresh();
        }

        //Kitap İsmine Göre Arama
        private void bSearchBookName_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Books where Book_Name like'%" + texbNameBookT.Text + "%'", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewTT.DataSource = ds.Tables[0];
            bgl.baglanti().Close();
        }
        //Kitap Kategorisine Göre Arama
        private void bSearchCate_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Books where Category like'%" + texbCategoryT.Text + "%'", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewTT.DataSource = ds.Tables[0];
            bgl.baglanti().Close();
        }
        //Kitap Yazarına Göre Arama
        private void bSearchAuthor_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Books where Book_Author like'%" + texbAuthornameT.Text + "%'", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewTT.DataSource = ds.Tables[0];
            bgl.baglanti().Close();
        }
        //Kitap Ödünç Alma
        private void bGetTheBook_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Books WHERE id=@p1 AND Book_Count > 0", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textbBookId.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                int id = dr.GetInt32(0);
                string idString = id.ToString();
                string Book_Name = dr.GetString(1);
                string Book_Page = dr.GetString(2);
                string Book_Category = dr.GetString(3);
                string Book_Author = dr.GetString(4);
                string TeacherMail = textbYourEmail.Text;

                // Check if the entered email address matches the logged-in email address
                if (TeacherMail == email)
                {
                    SqlCommand komut2 = new SqlCommand("SET IDENTITY_INSERT Tbl_GivenBooksTeacher1 ON; " + "INSERT INTO Tbl_GivenBooksTeacher1 (id, Book_Name, Book_Page, Book_Category, Book_Author, TeacherMail) VALUES (@Book_Id, @Book_Name, @Book_Page, @Book_Category, @Book_Author, @TeacherMail)", bgl.baglanti());
                    komut2.Parameters.AddWithValue("@Book_Id", id);
                    komut2.Parameters.AddWithValue("@Book_Name", Book_Name);
                    komut2.Parameters.AddWithValue("@Book_Page", Book_Page);
                    komut2.Parameters.AddWithValue("@Book_Category", Book_Category);
                    komut2.Parameters.AddWithValue("@Book_Author", Book_Author);
                    komut2.Parameters.AddWithValue("@TeacherMail", TeacherMail);
                    komut2.ExecuteNonQuery();

                    MessageBox.Show("Successfully Escrowed");

                    SqlCommand guncelle = new SqlCommand("UPDATE Tbl_Books SET Book_Count = Book_Count - 1 WHERE id=@p2", bgl.baglanti());
                    guncelle.Parameters.AddWithValue("@p2", textbBookId.Text);
                    guncelle.ExecuteNonQuery();

                    // DataGridView Verilen Kitap güncellemesi
                    string query = "SELECT * FROM Tbl_GivenBooksTeacher1 WHERE TeacherMail = @TeacherMail";
                    SqlCommand cmd = new SqlCommand(query, bgl.baglanti());
                    cmd.Parameters.AddWithValue("@TeacherMail", TeacherMail);

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataMybooks.DataSource = dt;

                    // DataGridView Books güncellemesi
                    DataTable dtv = new DataTable();
                    SqlDataAdapter dam = new SqlDataAdapter("SELECT * FROM Tbl_Books", bgl.baglanti());
                    dam.Fill(dtv);
                    dataGridViewTT.DataSource = dtv;
                }
                else
                {
                    MessageBox.Show("Invalid email address. Book cannot be given.");
                }
            }
            else
            {
                MessageBox.Show("Book not found or there are not enough books");
            }

        }
        //Kitap İade
        private void bReturnBookT_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_GivenBooksTeacher1 where id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", texbBookIdT.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) 
            {
                string id = texbBookIdT.Text;
                SqlCommand komut2 = new SqlCommand("Delete From Tbl_GivenBooksTeacher1 where id=@id" ,bgl.baglanti());
                komut2.Parameters.AddWithValue ("id", id);
                komut2.ExecuteNonQuery();
                MessageBox.Show("Successfully Returned.");
                SqlCommand guncelle = new SqlCommand("Update Tbl_Books Set Book_Count = Book_Count +1 Where id=@p2", bgl.baglanti());
                guncelle.Parameters.AddWithValue("@p2", texbBookIdT.Text);
                guncelle.ExecuteNonQuery();

                // DataGridView Verilen Kitap güncellemesi
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_GivenBooksTeacher1", bgl.baglanti());
                da.Fill(dt);
                dataMybooks.DataSource = dt;
                // DataGridView Books güncellemesi
                DataTable dtv = new DataTable();
                SqlDataAdapter dam = new SqlDataAdapter("SELECT * FROM Tbl_Books", bgl.baglanti());
                dam.Fill(dtv);
                dataGridViewTT.DataSource = dtv;
            }
            else
            {
                MessageBox.Show("Book Not Found");
            }
        }
        //" " ile başlayan arama
        private void bStratsW_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Books WHERE Book_Name LIKE @bookName", bgl.baglanti());
            komut.Parameters.AddWithValue("@bookName", texbStartsW.Text + "%");

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridViewTT.DataSource = ds.Tables[0];
            bgl.baglanti().Close();
        }
    }
}
