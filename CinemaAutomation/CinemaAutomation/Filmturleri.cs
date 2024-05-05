using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAutomation
{
    internal class Filmturleri
    {

        public void FilmTurEkle(string query)
        {
            baglanti myconnection=new baglanti();
            SqlConnection baglanti = myconnection.Getconnect();
            SqlCommand komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = query;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public DataSet FilmTurGetir(string query)
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
        public void FilmTurSil(string query) {

            baglanti myconnection = new baglanti();
            SqlConnection baglanti = myconnection.Getconnect();
            SqlCommand komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = query;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void FilmGuncelle(string query)
        {
            baglanti myconnection=new baglanti();
            SqlConnection baglanti=myconnection.Getconnect();
            SqlCommand komut=new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = query;
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

    }
}
