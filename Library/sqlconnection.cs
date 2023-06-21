using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Kutuphane_Proje
{
    class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-U4KIU5K\\SQLEXPRESS;Initial Catalog=KutuphaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;
        } 
    }
}
