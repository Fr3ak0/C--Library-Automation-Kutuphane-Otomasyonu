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
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }
        //Öğrenci giriş
        private void bStudent_Click(object sender, EventArgs e)
        {
            FrmStudentGiris fr = new FrmStudentGiris();
            fr.Show();
            this.Hide();
        }
        //Öğretmen giriş
        private void bTeacher_Click(object sender, EventArgs e)
        {
            FrmTeacherGiris fr = new FrmTeacherGiris();
            fr.Show();
            this.Hide();
        }
        //Admin girş
        private void bAdmin_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
            this.Hide();
        }
    }
}
