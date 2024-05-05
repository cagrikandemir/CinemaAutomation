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
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage home=new HomePage();
            home.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtfilmad.Text != "")
            {
                string query = "insert into Film_Bilgi values('" + txtfilmad.Text + "','" + combofilmtur.Text + "','" + txtfilmsure.Text + "','" + txtyapımcı.Text + "','" + pictureBox2.ImageLocation + "')";
                Film flm = new Film();
                try
                {
                    flm.FilmEkle(query);
                    MessageBox.Show("Film Başarıyla Eklendi");
                    Temizle();
                    Filmler();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("İşlem Başarısız Aynı İsimde Film Mevcut", "Hata");
                }
                
            }
            else
                MessageBox.Show("Bilgileri Girmeden Film Ekleyemezsiniz", "Hata");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
        }
        baglanti mycon=new baglanti();
        private void Filmturgetir()
        {
            SqlConnection baglanti = mycon.Getconnect();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select filmtur from Filmtur_Bilgi", baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("filmtur", typeof(string));
            dt.Load(rdr);
            combofilmtur.ValueMember = "filmtur";
            combofilmtur.DataSource = dt;
            baglanti.Close();
        }
        private void AddMovie_Load(object sender, EventArgs e)
        {
            txtfilmad.BackColor = Color.White;
            filmnamepnl.BackColor = Color.White;
            Filmler();
            Filmturgetir();
           
        }
        void Filmler()
        {
            Film hs = new Film();
            string query = "select * from Film_Bilgi";
            DataSet ds = hs.FilmGetir(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        void Temizle()
        {
            txtfilmad.Text = "";
            txtfilmsure.Text = "";
            txtyapımcı.Text = "";
            combofilmtur.Text = "";
        }
        int key = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            Film flm = new Film();
            if (key == 0)
                MessageBox.Show("Lütfen Silmek İstediğiniz Filmi Seçiniz", "Uyarı");
            else
            {
                try
                {
                    string query = "delete from Film_Bilgi where filmıd =" + key +"";
                    flm.FilmSil(query);
                    MessageBox.Show("Seçilen Film Başarıyla Silindi", "Başarılı");
                    Filmler();
                }
                catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtfilmad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            combofilmtur.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtfilmsure.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtyapımcı.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            if (txtfilmad.Text=="")
                key= 0;

            else
                key = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            
        }

        private void txtfilmad_Click(object sender, EventArgs e)
        {
            txtfilmad.BackColor = Color.White;
            filmnamepnl.BackColor = Color.White;
            panel2.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
            txtfilmsure.BackColor = SystemColors.Control;
            txtyapımcı.BackColor = SystemColors.Control;
            combofilmtur.BackColor = SystemColors.Control;
        }

        private void combofilmtur_Click(object sender, EventArgs e)
        {
            combofilmtur.BackColor = Color.White;
            panel2.BackColor = Color.White;
            filmnamepnl.BackColor = SystemColors.Control;
            txtfilmad.BackColor= SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
            txtfilmsure.BackColor = SystemColors.Control;
            txtyapımcı.BackColor = SystemColors.Control;
        }
        private void txtfilmsure_Click(object sender, EventArgs e)
        {
            txtfilmsure.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel2.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
            txtfilmad.BackColor = SystemColors.Control;
            filmnamepnl.BackColor = SystemColors.Control;
            txtyapımcı.BackColor = SystemColors.Control;
            combofilmtur.BackColor = SystemColors.Control;
        }

        private void txtyapımcı_Click(object sender, EventArgs e)
        {
            txtyapımcı.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            panel2.BackColor = SystemColors.Control;
            filmnamepnl.BackColor = SystemColors.Control;
            txtfilmad.BackColor = SystemColors.Control;
            filmnamepnl.BackColor = SystemColors.Control;
            combofilmtur.BackColor = SystemColors.Control;
            txtfilmsure.BackColor= SystemColors.Control;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Film flm = new Film();
            if (key == 0)
                MessageBox.Show("Lütfen Güncellemek İçin Film Seçiniz", "Hata");
            else if (txtfilmad.Text != "")
            {
                try
                {
                    string query = "update Film_Bilgi set filmad='" + txtfilmad.Text + "',filmtur='" + combofilmtur.Text + "',filmsure='" + txtfilmsure.Text + "',yapimci='" + txtyapımcı.Text + "' where filmıd=" + key + ";";
                    flm.Filmguncelle(query);
                    MessageBox.Show("Seçilen Film Başarıyla Güncellendi", "Başarılı");
                    Filmler();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
