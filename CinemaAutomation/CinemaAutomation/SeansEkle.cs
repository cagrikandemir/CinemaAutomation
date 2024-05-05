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
        private void FilmTur()
        {
            SqlConnection baglanti = Mycon.Getconnect();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Film_Bilgi where filmad='" + combofilmisim.SelectedValue.ToString() + "' ", baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                combotur.Text = dr["filmtur"].ToString();
            }
            baglanti.Close();
        }
        private void Seans()
        {
            SqlConnection baglanti=Mycon.Getconnect();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select Saat from Seans_Saat_Bilgi",baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Saat", typeof(string));
            dt.Load(rdr);
            comboseanssaat.ValueMember = "Saat";
            comboseanssaat.DataSource = dt;
            baglanti.Close();

        }
        private void Salon()
        {
            SqlConnection baglanti = Mycon.Getconnect();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select SalonAd from Salon_Bilgi", baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SalonAd", typeof(string));
            dt.Load(rdr);
            combosalon.ValueMember = "SalonAd";
            combosalon.DataSource = dt;
            baglanti.Close();

        }
        void Seansget()
        {
            Seans sns= new Seans();
            string query = "select * from Seans_Bilgi";
            DataSet ds = sns.SeansGetir(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        void Reset()
        {
            combofilmisim.SelectedValue = "";
            combosalon.SelectedValue = "";
            comboseanssaat.SelectedValue = "";
            combotur.SelectedValue = "";

        }
        private void SeansEkle_Load(object sender, EventArgs e)
        {
            FilmAd();
            Seans();
            Salon();
            Seansget();
            
        }
        private void combofilmisim_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilmTur();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Seans sns = new Seans();
            if (combofilmisim.Text != "")
            {
                string query = "insert into Seans_Bilgi values('" + combofilmisim.Text + "','"+combotur.Text+"','" + dateTimePicker1.Text + "','" + comboseanssaat.Text + "','" + combosalon.Text + "')";
                
                try
                {
                    sns.SeansEkle(query);
                    MessageBox.Show("Seans Başarıyla Eklendi","Başarılı");
                    Seansget();
                    Reset();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("İşlem Başarısız Eklemek İstenilen Seans Mevcut", "Hata");
                }

            }
            else
                MessageBox.Show("Bilgileri Girmeden Seans Ekleyemezsiniz", "Hata");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            Seans sns = new Seans();
            if (combofilmisim.Text != "")
            {
                try
                {
                    string query = "delete from Seans_Bilgi where SeansId=" + key + "";
                    sns.SeansSil(query);
                    MessageBox.Show("Seçilen Seans Silindi", "Başarılı");
                    Seansget();
                    Reset();

                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
                MessageBox.Show("Silinemedi", "Hata");

        }
        int key = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            combofilmisim.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            combotur.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboseanssaat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            combosalon.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            if (combofilmisim.SelectedIndex==0)
                key = 0;
            else
                key = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            Seans sns=new Seans();
            if (key != 0)
            {

                try
                {
                    string query = "update Seans_Bilgi set Film_Ad='" + combofilmisim.Text + "',Film_Tur='" + combotur.Text + "',Film_Tarih='" + dateTimePicker1.Text + "',Film_Saat='" + comboseanssaat.Text + "',Film_Salon='" + combosalon.Text + "' where SeansId="+key+"";
                    sns.SeansGuncelle(query);
                    MessageBox.Show("Seans Başarıyla Güncellendi", "Başarılı");
                    Seansget();
                    Reset();
                }
                catch (Exception)
                {

                }

            }
            else MessageBox.Show("Güncellemek İstediğiniz Seansı Seçiniz", "Hata");
           
        }
    }
}
