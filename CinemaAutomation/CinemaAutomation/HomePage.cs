using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            Application.Exit();
        }
        private List<string> imagePaths = new List<string>();
        private int currentIndex1 = 0;
        private int currentIndex2 = 1;
        private int currentIndex3 = 2;
        private Timer timer = new Timer();
        private void LoadImagesFromDatabase()
        {
            string connectionString = "Data Source=CAGRI\\SQLEXPRESS;Initial Catalog=cinema_automation;Integrated Security=True;Encrypt=False";
            string query = "SELECT resim FROM Film_Bilgi";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string imagePath = reader["resim"].ToString();
                    imagePaths.Add(imagePath);
                }
            }
        }
        private void SetupTimer()
        {
            timer.Interval = 3000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }
        private void HomePage_Load(object sender, EventArgs e)
        {
            LoadImagesFromDatabase();
            SetupTimer();

            //Saat
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer2_Tick);
            timer.Start();
            UpdateDateTimeLabel();
        }
        private void UpdateDateTimeLabel()
        {
            DateTime now = DateTime.Now;
            string dayOfWeek = now.ToString("dddd");
            string time = now.ToString("HH:mm:ss");
            labeldate.Text = $"Bugün: {dayOfWeek}\nSaat: {time}";
        }
        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            btnanamenü.BackColor = Color.Red;
        }

        private void btnanamenü_Click(object sender, EventArgs e)
        {
            SeansSaat seansEkleSaat = new SeansSaat();
            seansEkleSaat.ShowDialog();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            SeansEkle Seans=new SeansEkle();
            Seans.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FilmTurekle flm=new FilmTurekle();
            flm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BiletSatış bltsts = new BiletSatış();
            bltsts.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Satislar sts=new Satislar();
            sts.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdatePictureBox(pictureBox5, ref currentIndex1);
            UpdatePictureBox(pictureBox2, ref currentIndex2);
            UpdatePictureBox(pictureBox3, ref currentIndex3);
        }
        private void UpdatePictureBox(PictureBox pictureBox, ref int currentIndex)
        {
            if (imagePaths.Count > 0)
            {
                currentIndex = (currentIndex + 1) % imagePaths.Count;
                string currentImagePath = imagePaths[currentIndex];

                if (File.Exists(currentImagePath))
                {
                    pictureBox.Image = Image.FromFile(currentImagePath);
                }
                else
                {
                    MessageBox.Show($"Image not found: {currentImagePath}");
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            UpdateDateTimeLabel();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kullanicilar kk=new Kullanicilar();
            kk.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 frm=new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
