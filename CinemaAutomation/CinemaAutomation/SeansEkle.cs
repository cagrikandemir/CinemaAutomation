using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CinemaAutomation
{
    public partial class SeansEkle : Form
    {
        public SeansEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage home=new HomePage();
            home.Show();
            this.Close();
        }
          baglanti Mycon=new baglanti();
        private void FilmAd()
        {
            SqlConnection baglanti = Mycon.Getconnect();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select filmad from Film_Bilgi", baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("filmad", typeof(string));
            dt.Load(rdr);
            combofilmisim.ValueMember = "filmad";
            combofilmisim.DataSource = dt;
            baglanti.Close();
        }
        private void SeansEkle_Load(object sender, EventArgs e)
        {
            FilmAd();
        }
    }
}
