using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAutomation
{
    internal class Saat
    {

        public void SaatEkle(string query)
        {
            baglanti myconnection= new baglanti();
            SqlConnection baglanti = myconnection.Getconnect();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            baglanti.Open();
            komut.CommandText = query;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void SaatSil(string query)
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
        public DataSet SaatGetir(string query)
        {
            baglanti myconnection = new baglanti();
            SqlConnection baglanti = myconnection.Getconnect();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = query;
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
        public void SaatGuncelle(string query)
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
