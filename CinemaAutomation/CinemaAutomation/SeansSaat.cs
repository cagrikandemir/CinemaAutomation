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
    public partial class SeansSaat : Form
    {
        public SeansSaat()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Saat ssat= new Saat();
            if (txtsaat.Text != "")
            {
                try
                {
                    string query = "insert into Seans_Saat_Bilgi values('" + txtsaat.Text + "')";
                    ssat.SaatEkle(query);
                    MessageBox.Show("Saat Başarıyla Eklendi", "Başarılı");
                    saatler();

                }
                catch (Exception EX)
                {
                    MessageBox.Show("Seans Mevcut Farklı Seans Eklemeyi Deneyin","Uyarı");
                }
            }
            else MessageBox.Show("Metin Kutusu Boş Bırakılamaz", "Hata");
            

            
        }
        void saatler()
        {
            Saat st=new Saat();
            string query = "select * from Seans_Saat_Bilgi";
            DataSet ds = st.SaatGetir(query);
            dataGridView1.DataSource = ds.Tables[0];
            
        }
        private void SeansSaat_Load(object sender, EventArgs e)
        {
            saatler();
        }
       
        private void btnclosee_Click(object sender, EventArgs e)
        {
            HomePage home= new HomePage();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Saat st = new Saat();
            if (txtsaat.Text != "")
            {
                try
                {
                    string query = "delete from Seans_Saat_Bilgi where SaatId=" + key + "";
                    st.SaatSil(query);
                    MessageBox.Show("Seans Saati Başarıyla Silindi", "Başarılı");
                    saatler();

                }
                catch (Exception)
                {
                    
                }
            }
            else
                MessageBox.Show("Tablodan Silmek İstediğiniz Satırı Seçiniz", "Uyarı");

        }
        int key = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsaat.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            if(txtsaat.Text =="")
            {
                key = 0;
            }
            else
                key = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            Saat st = new Saat();
            if (txtsaat.Text != "")
            {
                try
                {
                    string query = "update Seans_Saat_Bilgi Set Saat='"+txtsaat.Text+"'where SaatId=" + key + "";
                    st.SaatGuncelle(query);
                    MessageBox.Show("Seans Saati Başarıyla Güncellendi", "Başarılı");
                    saatler();

                }
                catch (Exception)
                {

                }
            }
            else
                MessageBox.Show("Tablodan Güncellemek İstediğiniz Satırı Seçiniz", "Uyarı");

        }
    }
}
