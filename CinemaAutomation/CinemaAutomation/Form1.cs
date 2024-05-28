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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_kullaniciadi_Click(object sender, EventArgs e)
        {
            
            txtsifre.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            txt_kullaniciadi.BackColor = SystemColors.Control;
        }

        private void txtsifre_Click(object sender, EventArgs e)
        {
            txt_kullaniciadi.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txtsifre.BackColor = SystemColors.Control;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txtsifre.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txtsifre.UseSystemPasswordChar = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti con=new baglanti();
            if (txt_kullaniciadi.Text != "" && txtsifre.Text != "")
            {
                using (SqlConnection connection = con.Getconnect())
                {
                    connection.Open();
                    string query = "SELECT * FROM Kullanici_Bilgi WHERE kullaniciadi = @kullaniciadi AND sifre = @sifre";

                    using (SqlCommand komut = new SqlCommand(query, connection))
                    {

                        komut.Parameters.AddWithValue("@kullaniciadi", txt_kullaniciadi.Text);
                        komut.Parameters.AddWithValue("@sifre", txtsifre.Text);

                        using (SqlDataReader dr = komut.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                HomePage homePage = new HomePage();
                                homePage.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else MessageBox.Show("Gerekli Yerleri Doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KayıtekleForm kyt=new KayıtekleForm();
            kyt.Show();
            this.Hide();
        }
    }
}
