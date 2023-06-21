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
using System.Data.SqlClient;

namespace Kutuphane_Proje
{
    public partial class FrmFollowEscrowedBooks : Form
    {
        public FrmFollowEscrowedBooks()
        {
            InitializeComponent();
        }
        //maine dön
        private void button2_Click(object sender, EventArgs e)
        {
            FrmAdminMain fr = new FrmAdminMain();
            fr.Show();
            this.Hide();
        }

        private void FrmFollowEscrowedBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneProjeDataSet12.Tbl_GivenBooksStudent1' table. You can move, or remove it, as needed.
            this.tbl_GivenBooksStudent1TableAdapter.Fill(this.kutuphaneProjeDataSet12.Tbl_GivenBooksStudent1);
            // TODO: This line of code loads data into the 'kutuphaneProjeDataSet10.Tbl_ReturnedBooks2' table. You can move, or remove it, as needed.
            this.tbl_ReturnedBooks2TableAdapter.Fill(this.kutuphaneProjeDataSet10.Tbl_ReturnedBooks2);

        }
        sqlbaglanti bgl= new sqlbaglanti();
        //Get Book
        private void bGetBook_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_ReturnedBooks2 Where StudentNumber=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", texbStudentNum.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                int id = dr.GetInt16(0);
                string StudentNumber=dr.GetString(2);
                string StudentMail=dr.GetString(3);
                SqlCommand komut2 = new SqlCommand("Delete From Tbl_GivenBooksStudent1 where StudentNumber=@p1 and id=@p2 and StudentMail=@p3", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", texbStudentNum.Text);
                komut2.Parameters.AddWithValue("@p2", texbBookId.Text);
                komut2.Parameters.AddWithValue("@p3", texbStudentMail.Text);
                komut2.ExecuteNonQuery();
                MessageBox.Show("Successfully Retrieved");
                //sil
                SqlCommand sil = new SqlCommand("Delete From Tbl_ReturnedBooks2 where id=@id1 and StudentNumber=@std and StudentMail=@mail", bgl.baglanti());
                sil.Parameters.AddWithValue("@id1", texbBookId.Text);
                sil.Parameters.AddWithValue("@std", texbStudentNum.Text);
                sil.Parameters.AddWithValue("@mail", texbStudentMail.Text);
                sil.ExecuteNonQuery();
                //ekle
                SqlCommand guncelle = new SqlCommand("Update Tbl_Books Set Book_Count = Book_Count +1 Where id=@idd", bgl.baglanti());
                guncelle.Parameters.AddWithValue("@idd", texbBookId.Text);
                guncelle.ExecuteNonQuery();
                //bildirim silme
                SqlCommand bildsil = new SqlCommand("Delete From Tbl_Notifications Where Book_Id=@bid and StudentNumber=@stdnum and StudentMail=@stdmail",bgl.baglanti());
                bildsil.Parameters.AddWithValue("@bid",texbBookId.Text);
                bildsil.Parameters.AddWithValue("@stdnum", texbStudentNum.Text);
                bildsil.Parameters.AddWithValue("@stdmail", texbStudentMail.Text);
                bildsil.ExecuteNonQuery();
                //Anında Güncelleme returnler
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_ReturnedBooks2", bgl.baglanti());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                //Anında Güncelleme givens
                DataTable dta = new DataTable();
                SqlDataAdapter dab = new SqlDataAdapter("SELECT * FROM Tbl_GivenBooksStudent1", bgl.baglanti());
                dab.Fill(dta);
                dataGridView2.DataSource = dta;
            }
            else
            {
                MessageBox.Show("No such request was found."); 
            }
        }
        //otofill
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Sadece satır tıklamalarını kontrol etmek için
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                texbBookId.Text = row.Cells["id"].Value.ToString();
                texbStudentNum.Text = row.Cells["StudentNumber"].Value.ToString();
                texbStudentMail.Text = row.Cells["StudentMail"].Value.ToString();

                
            }
        }
        //Süre Uzatma
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_GivenBooksStudent1 where id=@p1 and StudentNumber=@p2 and StudentMail=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", texbid.Text);
            komut.Parameters.AddWithValue("@p2", texbstdnum.Text);
            komut.Parameters.AddWithValue("@p3", texbstdmail.Text);
            SqlDataReader dr= komut.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();

                DateTime newDateOfBack = dateTimePicker1.Value;
                string newDateOfBackString = newDateOfBack.ToString("yyyy-MM-dd");

                SqlCommand updateCommand = new SqlCommand("UPDATE Tbl_GivenBooksStudent1 SET Date_Of_Back=@NewDateOfBack WHERE id=@p1 AND StudentNumber=@p2 AND StudentMail=@p3", bgl.baglanti());
                updateCommand.Parameters.AddWithValue("@NewDateOfBack", newDateOfBackString);
                updateCommand.Parameters.AddWithValue("@p1", texbid.Text);
                updateCommand.Parameters.AddWithValue("@p2", texbstdnum.Text);
                updateCommand.Parameters.AddWithValue("@p3", texbstdmail.Text);

                int affectedRows = updateCommand.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Date_Of_Back updated successfully.");
                    //bildirim silme
                    SqlCommand bildsil = new SqlCommand("Delete From Tbl_Notifications Where Book_Id=@bid and StudentNumber=@stdnum and StudentMail=@stdmail",bgl.baglanti());
                    bildsil.Parameters.AddWithValue("@bid", texbid.Text);
                    bildsil.Parameters.AddWithValue("@stdnum", texbstdnum.Text);
                    bildsil.Parameters.AddWithValue("@stdmail", texbstdmail.Text);
                    bildsil.ExecuteNonQuery();
                    //Anında Güncelleme givens
                    DataTable dta = new DataTable();
                    SqlDataAdapter dab = new SqlDataAdapter("SELECT * FROM Tbl_GivenBooksStudent1", bgl.baglanti());
                    dab.Fill(dta);
                    dataGridView2.DataSource = dta;
                }
                else
                {
                    MessageBox.Show("An error occurred while updating Date_Of_Back.");
                }
            }
            else
            {
                MessageBox.Show("Record not found.");
            }
        }
        //otofill2
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Sadece satır tıklamalarını kontrol etmek için
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                texbid.Text = row.Cells["id1"].Value.ToString();
                texbstdnum.Text = row.Cells["StudentNumber1"].Value.ToString();
                texbstdmail.Text = row.Cells["StudentMail1"].Value.ToString();
                dateTimePicker1.Text = row.Cells["Date_Of_Back"].Value.ToString();
            }
        }
    }
}
