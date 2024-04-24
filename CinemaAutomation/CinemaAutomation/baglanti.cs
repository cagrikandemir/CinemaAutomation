using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CinemaAutomation
{
    internal class baglanti
    {
        public SqlConnection Getconnect()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString ="Data Source=CAGRI\\SQLEXPRESS;Initial Catalog=cinema_automation;Integrated Security=True;Encrypt=False";
            return baglanti;
        }

    }
}
