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
    public partial class KayıtekleForm : Form
    {
        public KayıtekleForm()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Form1 menü= new Form1();
            menü.Show();
            this.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {
            kullanicikayit kyt=new kullanicikayit();
            if (txt_kullaniciadi.Text != "" && txtsifre.Text != "")
            {
                try
                {
                    string query = "insert into Kullanici_Bilgi values('" + txt_kullaniciadi.Text + "','" + txtsifre.Text + "')";
                    kyt.KullaniciEkle(query);
                    MessageBox.Show("Kullanıcı Başarıyla Kayıt Edildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txt_kullaniciadi.Text = "";
                    txtsifre.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Aynı Kullanıcı Adında Mevcut Hesap Var ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            MessageBox.Show("Lütfen Boş Yer Bırakmayınız","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Stop);
        }
    }
}
