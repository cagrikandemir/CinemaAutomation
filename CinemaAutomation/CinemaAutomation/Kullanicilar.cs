using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaAutomation
{
    public partial class Kullanicilar : Form
    {
        public Kullanicilar()
        {
            InitializeComponent();
        }
        public void KullaniciGetir()
        {
            kullanicikayit sts = new kullanicikayit();
            string query = "select * from Kullanici_Bilgi";
            DataSet ds = sts.KullaniciGetir(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void Kullanicilar_Load(object sender, EventArgs e)
        {
            KullaniciGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kullanicikayit sns = new kullanicikayit();
            if (textBox1.Text != "")
            {
                try
                {
                    string query = "delete from Kullanici_Bilgi where Id=" + key + "";
                    sns.KullaniciSil(query);
                    MessageBox.Show("Seçilen Kullanıcı Silindi", "Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    KullaniciGetir();
                    textBox1.Text = "";
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
                MessageBox.Show("Kullanıcı Silinemedi Kullanıcı Seçiniz", "Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
        int key = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            if (textBox1.Text=="")
                key = 0;
            else
                key = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage hm=new HomePage();
            hm.Show();
            this.Hide();
        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {
            filter();
        }
        private void filter()
        {
            kullanicikayit hs = new kullanicikayit();
            string query = "select * from Kullanici_Bilgi where kullaniciadi like '%" + txtad.Text + "%'";
            DataSet ds = hs.KullaniciGetir(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
