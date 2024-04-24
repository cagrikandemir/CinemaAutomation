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
            Application.Exit();
        }

        private void txt_kullaniciadi_MouseUp(object sender, MouseEventArgs e)
        {
            panel2.BackColor = Color.White;
            txtslnad.BackColor = Color.White;
            
        }

        private void AddSln_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string query = "insert into Salon_Bilgi values('" + txtslnad.Text+"')";
            salon sln = new salon();
            try
            {
                sln.SalonEkle(query);
                MessageBox.Show("Salon Başarıyla Eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Salon Eklenemedi");
            }
        }
    }
}
