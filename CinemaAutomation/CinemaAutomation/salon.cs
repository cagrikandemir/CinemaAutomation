﻿using System;
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

        public DataSet SalonGetir(string query)
        {
            baglanti myconnection=new baglanti();
            SqlConnection baglanti=myconnection.Getconnect();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = query;
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
        public void SalonSil(string query) {
            baglanti myconnection = new baglanti();
            SqlConnection baglanti= myconnection.Getconnect();
            SqlCommand komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = query;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void SalonGuncelle(string query)
        {
            baglanti myconnection = new baglanti();
            SqlConnection baglanti = myconnection.Getconnect();
            SqlCommand komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = query;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
