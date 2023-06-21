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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kutuphane_Proje
{
    public partial class FrmChangeUserSettings : Form
    {
        public FrmChangeUserSettings()
        {
            InitializeComponent();
        }

        private void FrmChangeUserSettings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneProjeDataSet13.Tbl_UserSettings' table. You can move, or remove it, as needed.
            this.tbl_UserSettingsTableAdapter1.Fill(this.kutuphaneProjeDataSet13.Tbl_UserSettings);
            

        }
        sqlbaglanti bgl=new sqlbaglanti();
        //ayar değiş
        private void bChangeSet_Click(object sender, EventArgs e)
        {
            string studentMail = texbStudentMail.Text; 
            string studentNumber = texbStudentNum.Text; 

            SqlCommand komut = new SqlCommand("UPDATE Tbl_UserSettings SET How_many_books = @p1 WHERE StudentMail = @StudentMail AND StudentNo = @StudentNo", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", texbBookCap.Text);
            komut.Parameters.AddWithValue("@StudentMail", studentMail);
            komut.Parameters.AddWithValue("@StudentNo", studentNumber);
            komut.ExecuteNonQuery();
            MessageBox.Show("Successfully Changed");

            // Anında Güncelleme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_UserSettings", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        //otofill
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Sadece satır tıklamalarını kontrol etmek için
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                texbStudentNum.Text = row.Cells["StudentNo"].Value.ToString();
                texbStudentMail.Text = row.Cells["StudentMail"].Value.ToString();
                texbBookCap.Text = row.Cells["How_many_books"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAdminMain fr = new FrmAdminMain();
            fr.Show();
            this.Hide();
        }
    }
}
