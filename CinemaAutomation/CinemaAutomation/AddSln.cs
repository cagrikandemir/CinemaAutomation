using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CinemaAutomation
{
    public partial class AddSln : Form
    {
        public AddSln()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }

        private void txt_kullaniciadi_MouseUp(object sender, MouseEventArgs e)
        {
            panel2.BackColor = Color.White;
            txtslnad.BackColor = Color.White;
            
        }

        private void AddSln_Load(object sender, EventArgs e)
        {
            SalonBilgiGet();
        }
        void SalonBilgiGet()
        {
            
            salon sln=new salon();
            string query = "select * from Salon_Bilgi";
            DataSet ds =sln.SalonGetir(query);
            dataGridView1.DataSource = ds.Tables[0];        
        }
        void reset()
        {
            txtslnad.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtslnad.Text != "")
            {
                string query = "insert into Salon_Bilgi values('" + txtslnad.Text + "')";
                salon sln = new salon();
                try
                {
                    sln.SalonEkle(query);
                    MessageBox.Show("Salon Başarıyla Eklendi","Başarılı");
                    SalonBilgiGet();
                    reset();
                }
                catch (Exception)
                {
                    MessageBox.Show("Salon Eklenemedi","Hata");
                }
            }
            else MessageBox.Show("Lütfen Metin Kutusunu Boş Bırakmayınız", "Hata");
        }
        int key = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtslnad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


            if (txtslnad.Text == "")
                key = 0;

            else
                key= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            salon sln = new salon();
            if(key==0)
            {
                MessageBox.Show("Silmek İçin Tablodan Salon Seçiniz", "Hata");             
            }
            else
            {
                try
                {
                    string query = "delete from Salon_Bilgi where salonıd=" + key + "";
                    sln.SalonSil(query);
                    MessageBox.Show("Seçilen Salon Başarıyla Silindi", "Başarılı");
                    reset();
                    SalonBilgiGet();
                }
                catch (Exception)
                {
                    MessageBox.Show("Seçilen Salon Silinemedi", "Hata");
                }
            }

        }
        private void btngüncelle_Click(object sender, EventArgs e)
        {
            salon sln = new salon();
            if (key == 0)
                MessageBox.Show("Lütfen Güncellemek İçin Salon Seçiniz", "Hata");
            else if (txtslnad.Text != "")
            {
                try
                {
                    string query = "update Salon_Bilgi set SalonAd='" + txtslnad.Text + "' where salonıd=" + key + ";";
                    sln.SalonGuncelle(query);
                    MessageBox.Show("Seçilen Salon Başarıyla Güncellendi", "Başarılı");
                    SalonBilgiGet();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
