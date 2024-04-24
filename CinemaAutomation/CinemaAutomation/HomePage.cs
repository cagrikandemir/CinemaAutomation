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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 giris = new Form1();
            giris.Show();
            this.Close();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            btnanamenü.BackColor = Color.Red;
        }

        private void btnanamenü_Click(object sender, EventArgs e)
        {

        }

        private void bnfilmekle_Click(object sender, EventArgs e)
        {
            AddMovie frm=new AddMovie();
            frm.ShowDialog();
        }

        private void btnsalonekle_Click(object sender, EventArgs e)
        {
            AddSln frm=new AddSln();
            frm.ShowDialog();
        }
    }
}
