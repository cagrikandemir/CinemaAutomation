using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaAutomation
{
    public partial class BiletSatış : Form
    {
        public BiletSatış()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage hm = new HomePage();
            hm.Show();
            this.Hide();
        }
        baglanti Mycon = new baglanti();
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
        private void SalonAd()
        {
            SqlConnection baglanti = Mycon.Getconnect();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select distinct Film_Salon from Seans_Bilgi where Film_Ad='" + combofilmisim.SelectedValue.ToString() + "' ", baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                combosalonisim.ValueMember = "Film_Salon".ToString();
                combosalonisim.DataSource = dt;
            }
            baglanti.Close();
        }
        private void SeansSaat()
        {
            SqlConnection baglanti = Mycon.Getconnect();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select distinct Film_Saat from Seans_Bilgi where Film_Ad='" + combofilmisim.SelectedValue.ToString() +"' and Film_Salon='"+combosalonisim.SelectedValue.ToString()+"' and Film_Tarih='"+combotarih.SelectedValue.ToString()+"' ", baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                combosaat.ValueMember = "Film_Saat".ToString();
                combosaat.DataSource = dt;
            }
            baglanti.Close();

        }
        private void Film_Tarih()
        {
            SqlConnection baglanti = Mycon.Getconnect();
            baglanti.Open();
            SqlCommand komut=new SqlCommand("select distinct Film_Tarih from Seans_Bilgi where Film_Ad='"+combofilmisim.SelectedValue.ToString()+"'and Film_Salon='"+combosalonisim.SelectedValue.ToString()+"' ",baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter sda=new SqlDataAdapter(komut);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                combotarih.ValueMember = "Film_Tarih".ToString();
                combotarih.DataSource = dt;
            }
        }
        int sayac = 0;
        private void BiletSatış_Load(object sender, EventArgs e)
        {
            FilmAd();
            
            sayac = 1;
            for(int i=0; i < 8;i++)
            {
                for(int j=0;j<9;j++)
                {
                    Button btn=new Button();
                    btn.Size = new Size(60, 60);
                    btn.BackColor = Color.White;
                    btn.Location = new Point(j *60 + 90, i * 60 + 110);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    if(j==4)
                    {
                        continue;
                    }
                    sayac++;
                    this.panel2.Controls.Add(btn);
                    btn.Click += btn_click;
                }
            }
        }

        private void btn_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(b.BackColor == Color.White)
            {
                txtkoltukno.Text = b.Text;
            }       
        }

        private void combofilmisim_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SalonAd();
        }

        private void combosalonisim_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            Film_Tarih();
        }

        private void combotarih_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SeansSaat();
        }
        private void DoluKoltuk()
        {         
            SqlConnection baglanti = Mycon.Getconnect();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Satis_Bilgi where Film_İsim='" + combofilmisim.SelectedValue.ToString() + "' and Salon_İsim='" + combosalonisim.SelectedValue.ToString() + "'and Film_Tarih='" + combotarih.SelectedValue.ToString() + "'and Film_Saati='" + combosaat.SelectedValue.ToString() + "'",baglanti);
            SqlDataReader rdr = komut.ExecuteReader();         
            while(rdr.Read())
            {
                foreach (Control item in panel2.Controls)
                {
                    if(item is Button)
                    {
                        if (rdr["Koltuk_No"].ToString()==item.Text)
                        {
                            item.BackColor = Color.Red;
                        }
                       
                    }
                }
               
            }
            baglanti.Close();
            rdr.Close();
            
        }
        private void yenilekoltuk()
        {
            foreach (Control item in panel2.Controls)
            {
                if(item is Button)
                {
                    item.BackColor = Color.White;
                }
            }
        }
        private void Biletİptal()
        {
            txtiptalno.Items.Clear();
            txtiptalno.Text = "";
            foreach (Control item in panel2.Controls)
            {
                if(item is Button)
                {
                    if(item.BackColor== Color.Red)
                    {
                        txtiptalno.Items.Add(item.Text);
                    }
                }
            }
        }
        private void btnsat_Click(object sender, EventArgs e)
        {
            satis sts=new satis();
            
            if (txtkoltukno.Text != "")
            {
               
                try
                {
                    
                    string query = "insert into Satis_Bilgi values('" + combofilmisim.Text + "','" + combosalonisim.Text + "','" + combotarih.Text + "','" + combosaat.Text + "','" + txtkoltukno.Text + "','" + txtad.Text + "','" + txtsoyad.Text + "','" + txtucret.Text + "')";
                    sts.SatisEkle(query);                 
                    MessageBox.Show("Bilet Başarıyla Satıldı", "Başarılı");
                    txtkoltukno.Text = "";
                    txtad.Text = "";
                    txtsoyad.Text = "";

                    DoluKoltuk();
                    Biletİptal();
                }
                catch (Exception)
                {
                    MessageBox.Show("Bilet Satılamadı Koltuk Dolu", "Hata");

                }
            }
            else MessageBox.Show("Gerekli Yerler Doldurulmadan Bilet Satılamaz","Hata");
        }

        private void combosaat_SelectedIndexChanged(object sender, EventArgs e)
        {
            yenilekoltuk();
            DoluKoltuk();
            Biletİptal();
   
        }

        private void combosaat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            satis sts= new satis();

            if (txtiptalno.Text != "")
            {

                try
                {
                    string query = "delete from Satis_Bilgi where Koltuk_No='" + txtiptalno.Text + "'";
                    sts.SatisSil(query);
                    MessageBox.Show("Bilet Başarıyla Silindi", "Başarılı");
                    
                    yenilekoltuk();
                    DoluKoltuk();
                }
                catch (Exception)
                {

                    MessageBox.Show("Bilet Silinemedi", "Hata");
                }
            }
            else MessageBox.Show("Lütfen Silmek İstediğiniz Koltuk Numarasını Seçiniz", "Uyarı");
        }
    }
}
