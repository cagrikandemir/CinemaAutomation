using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAutomation
{
    internal class Seans
    {
        public void SeansEkle(string query)
        {
            baglanti myconnection=new baglanti();
            SqlConnection baglanti = myconnection.Getconnect();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            baglanti.Open();
            komut.CommandText = query;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void SeansSil(string query)
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
        public void SeansGuncelle(string query)
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
        public DataSet SeansGetir(string query)
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
        public bool SeansVarMi(string filmAd, string filmTur, string filmTarih, string filmSaat, string filmSalon)
        {
            string query = $"SELECT COUNT(*) FROM Seans_Bilgi WHERE Film_Ad = '{filmAd}' AND Film_Tur = '{filmTur}' AND Film_Tarih = '{filmTarih}' AND Film_Saat = '{filmSaat}' AND Film_Salon = '{filmSalon}'";
            baglanti myconnection = new baglanti();
            SqlConnection baglanti = myconnection.Getconnect();
            SqlCommand komut = new SqlCommand(query, baglanti);
            baglanti.Open();
            int count = (int)komut.ExecuteScalar();
            baglanti.Close();
            return count > 0;
        }
    }
}
