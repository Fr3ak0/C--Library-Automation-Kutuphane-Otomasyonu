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
    public partial class FrmEditBooks : Form
    {
        public FrmEditBooks()
        {
            InitializeComponent();
        }

       
        //maine dönüş
        private void button2_Click(object sender, EventArgs e)
        {
            FrmAdminMain fr=new FrmAdminMain();
            fr.Show();
            this.Hide();
        }
        sqlbaglanti bgl=new sqlbaglanti();
        //Kitap ekle
        private void bAdd_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert Into Tbl_Books (Book_Name,Book_Page,Category,Book_Author,Book_Count) values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", texBBookName.Text);
            komut.Parameters.AddWithValue("@p2", texBBookPage.Text);
            komut.Parameters.AddWithValue("@p3", texBCategory.Text);
            komut.Parameters.AddWithValue("@p4", texBAuthor.Text);
            komut.Parameters.AddWithValue("@p5", texBBookCount.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Added successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            texBBookName.Text = "";
            texBBookPage.Text = "";
            texBCategory.Text = "";
            texBAuthor.Text = "";
            texBBookCount.Text = "";
        }
        //Kitap sil
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("Delete From Tbl_Books Where Book_Name=@bookname", bgl.baglanti());
            sil.Parameters.AddWithValue("@bookname", textBox1.Text);
            sil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Deleted successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Stok ekle
        private void button3_Click(object sender, EventArgs e)
        {

            string kitapAdi = textbNewBookName.Text;
            int eklenecekSayi = Convert.ToInt32(textbHowMuch.Text);
            using (SqlConnection connection =bgl.baglanti())
            {
                

                // Kitap adına göre kitap bilgilerini alıyoruz
                string query = "SELECT Book_Count FROM Tbl_Books WHERE Book_Name = @Title";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Title", kitapAdi);

                int existingBookCount = Convert.ToInt32(command.ExecuteScalar());

                if (existingBookCount >= 0)
                {
                    // Kitap varsa BookCount değerini artırıyoruz
                    query = "UPDATE Tbl_Books SET Book_Count = Book_Count + @Count WHERE Book_Name = @Title";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Count", eklenecekSayi);
                    command.Parameters.AddWithValue("@Title", kitapAdi);
                    command.ExecuteNonQuery();

                    MessageBox.Show($"{kitapAdi} succesfully {eklenecekSayi} increased.");
                }
                else
                {
                    MessageBox.Show($"{kitapAdi} not found.");
                }
                connection.Close();

            }
        }
        //Stok sil
        private void button4_Click(object sender, EventArgs e)
        {
            string kitapAdi = textbDel.Text;
            int eklenecekSayi = Convert.ToInt32(textbDelHow.Text);
            using (SqlConnection connection = bgl.baglanti())
            {


                // Kitap adına göre kitap bilgilerini alıyoruz
                string query = "SELECT Book_Count FROM Tbl_Books WHERE Book_Name = @Title";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Title", kitapAdi);

                int existingBookCount = Convert.ToInt32(command.ExecuteScalar());

                if (existingBookCount >= 0)
                {
                    // Kitap varsa BookCount değerini azaltıyouz
                    query = "UPDATE Tbl_Books SET Book_Count = Book_Count - @Count WHERE Book_Name = @Title";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Count", eklenecekSayi);
                    command.Parameters.AddWithValue("@Title", kitapAdi);
                    command.ExecuteNonQuery();

                    MessageBox.Show($"{kitapAdi} succesfuly {eklenecekSayi} decreased.");
                }
                else
                {
                    MessageBox.Show($"{kitapAdi} not found.");
                }
                connection.Close();

            }
        }
    }
}
