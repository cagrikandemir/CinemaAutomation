using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CinemaAutomation
{
    internal class salon
    {
        public void SalonEkle(string query)
        {
            baglanti myconnection = new baglanti();
            SqlConnection baglanti = myconnection.Getconnect();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            baglanti.Open();
            komut.CommandText = query;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
