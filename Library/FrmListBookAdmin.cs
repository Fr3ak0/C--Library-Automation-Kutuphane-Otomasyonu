using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Proje
{
    public partial class FrmListBookAdmin : Form
    {
        public FrmListBookAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAdminMain fr = new FrmAdminMain();
            fr.Show();
            this.Hide();
        }

        private void FrmListBookAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneProjeDataSet2.Tbl_Books' table. You can move, or remove it, as needed.
            this.tbl_BooksTableAdapter.Fill(this.kutuphaneProjeDataSet2.Tbl_Books);

        }

        
    }
}
