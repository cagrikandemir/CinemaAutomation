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
    public partial class Satislar : Form
    {
        public Satislar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage hm=new HomePage();
            hm.Show();
            this.Hide();
        }

        private void Satislar_Load(object sender, EventArgs e)
        {
            satis sts=new satis();
            string query = "select * from Satis_Bilgi";
            DataSet ds = sts.SatisGetir(query);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void txtad_Enter(object sender, EventArgs e)
        {
            if (txtad.Text == "Ara...")
            {
                txtad.Text = "";
                txtad.ForeColor = Color.Black;
            }
        }

        private void txtad_Leave(object sender, EventArgs e)
        {
            if(txtad.Text == "")
            {
                txtad.Text = "Ara...";
                txtad.ForeColor = Color.Silver;
            }

        }
    }
}
