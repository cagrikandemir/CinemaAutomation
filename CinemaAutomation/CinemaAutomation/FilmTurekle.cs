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
    public partial class FilmTurekle : Form
    {
        public FilmTurekle()
        {
            InitializeComponent();
        }

        private void btnclosee_Click(object sender, EventArgs e)
        {
            HomePage home=new HomePage();
            home.Show();
            this.Hide();
        }
        void TurlerGetir()
        {
            Filmturleri flmtur = new Filmturleri();
            string query = "select *from Filmtur_Bilgi";
            DataSet ds = flmtur.FilmTurGetir(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Filmturleri flmtur=new Filmturleri();
            if (txtfilmtür.Text != "")
            {
                try
                {
                    string query = "insert into Filmtur_Bilgi values('" + txtfilmtür.Text + "')";
                    flmtur.FilmTurEkle(query);
                    MessageBox.Show("Film Türü Başarıyla Eklendi", "Başarılı");
                    TurlerGetir();
                    txtfilmtür.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Aynı İsimde Film Türü Mevcut", "Hata");
                }
            }
            else
                MessageBox.Show("Metin Kutusunu Boş Bırakmayınız", "Uyarı");
        }
        int key = 0;
        private void btnsil_Click(object sender, EventArgs e)
        {
            Filmturleri flmtur = new Filmturleri();
            if (key == 0)
                MessageBox.Show("Lütfen Silmek İstediğiniz Film Türünü Seçiniz", "Uyarı");
            else
            {
                try
                {
                    string query = "delete from Filmtur_bilgi where TurId =" + key + "";
                    flmtur.FilmTurSil(query);
                    MessageBox.Show("Seçilen Film Başarıyla Silindi", "Başarılı");
                    TurlerGetir();
                    txtfilmtür.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtfilmtür.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            if (txtfilmtür.Text == "")
                key = 0;
            else
                key = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

        }

        private void FilmTurekle_Load(object sender, EventArgs e)
        {
            TurlerGetir();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Filmturleri flmtur = new Filmturleri();
            if (key == 0)
                MessageBox.Show("Lütfen Güncellemek İçin Film Türü Seçiniz", "Hata");
            else if (txtfilmtür.Text!="")
            {
                try
                {
                    string query = "update Filmtur_Bilgi set filmtur='" + txtfilmtür.Text + "' where turId=" + key + "";
                    flmtur.FilmGuncelle(query);
                    MessageBox.Show("Film Türü Başarıyla Güncellendi", "Başarılı");
                    TurlerGetir();
                    txtfilmtür.Text = "";
                }
                catch (Exception)
                {

                }
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
