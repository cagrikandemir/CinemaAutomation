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
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query="insert into Film_Bilgi values('"+txtfilmad.Text+"','"+combofilmtur.SelectedText+"','"+txtfilmsure.Text+"','"+txtyapımcı.Text+"','"+pictureBox2.ImageLocation+"')";
            Film flm=new Film();
            try
            {
                flm.FilmEkle(query);
                MessageBox.Show("Film Başarıyla Eklendi");
                Temizle();
                Filmler();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Önceden Kayıtlı Olan Film");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
        }

        private void AddMovie_Load(object sender, EventArgs e)
        {
            Filmler();
           
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
        
    }
}
