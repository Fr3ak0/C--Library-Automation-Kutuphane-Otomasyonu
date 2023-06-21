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
    public partial class FrmAdminMain : Form
    {
        public FrmAdminMain()
        {
            InitializeComponent();
        }
        //Öğretmen Onayı
        private void bTeacherRequest_Click(object sender, EventArgs e)
        {
            FrmTeacherRequest fr = new FrmTeacherRequest();
            fr.Show();
            this.Hide();
        }
        //Kitapları düzenle
        private void bEditBooks_Click(object sender, EventArgs e)
        {
            FrmEditBooks fr= new FrmEditBooks();
            fr.Show();
            this.Hide();
        }
        //Kitapları listele
        private void bListBooks_Click(object sender, EventArgs e)
        {
            FrmListBookAdmin fr = new FrmListBookAdmin();
            fr.Show();
            this.Hide();
        }
        //Emanet Kitap
        private void bEmanetKitap_Click(object sender, EventArgs e)
        {
            FrmEscrowBook frm = new FrmEscrowBook();
            frm.Show();
            this.Hide();
        }
        //Kitapları takip et
        private void bFollowBooks_Click(object sender, EventArgs e)
        {
            FrmFollowEscrowedBooks fr = new FrmFollowEscrowedBooks();
            fr.Show();
            this.Hide();
        }
        //Öğrenci ayarları
        private void button1_Click(object sender, EventArgs e)
        {
            FrmChangeUserSettings frm = new FrmChangeUserSettings();
            frm.Show();
            this.Hide();
        }

    }
}
