namespace CinemaAutomation
{
    partial class Satislar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Film_İsim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salon_İsim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Film_Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Film_Saati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Koltuk_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtad = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 48);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(920, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CinemaAutomation.Properties.Resources.Clap_cinema;
            this.pictureBox1.Location = new System.Drawing.Point(15, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tüm Satışlar";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.SteelBlue;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnclose.Location = new System.Drawing.Point(1269, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(47, 48);
            this.btnclose.TabIndex = 0;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Film_İsim,
            this.Salon_İsim,
            this.Film_Tarih,
            this.Film_Saati,
            this.Koltuk_No,
            this.Ad,
            this.Soyad,
            this.ucret});
            this.dataGridView1.Location = new System.Drawing.Point(15, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(940, 602);
            this.dataGridView1.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Satış ID";
            this.Id.Name = "Id";
            // 
            // Film_İsim
            // 
            this.Film_İsim.DataPropertyName = "Film_İsim";
            this.Film_İsim.HeaderText = "Film Adı";
            this.Film_İsim.Name = "Film_İsim";
            // 
            // Salon_İsim
            // 
            this.Salon_İsim.DataPropertyName = "Salon_İsim";
            this.Salon_İsim.HeaderText = "Salon Adı";
            this.Salon_İsim.Name = "Salon_İsim";
            // 
            // Film_Tarih
            // 
            this.Film_Tarih.DataPropertyName = "Film_Tarih";
            this.Film_Tarih.HeaderText = "Film Tarihi";
            this.Film_Tarih.Name = "Film_Tarih";
            // 
            // Film_Saati
            // 
            this.Film_Saati.DataPropertyName = "Film_Saati";
            this.Film_Saati.HeaderText = "Film Saati";
            this.Film_Saati.Name = "Film_Saati";
            // 
            // Koltuk_No
            // 
            this.Koltuk_No.DataPropertyName = "Koltuk_No";
            this.Koltuk_No.HeaderText = "Koltuk Numarası";
            this.Koltuk_No.Name = "Koltuk_No";
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "Ad";
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            // 
            // Soyad
            // 
            this.Soyad.DataPropertyName = "Soyad";
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.Name = "Soyad";
            // 
            // ucret
            // 
            this.ucret.DataPropertyName = "ucret";
            this.ucret.HeaderText = "Ücret Tipi";
            this.ucret.Name = "ucret";
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtad.Location = new System.Drawing.Point(642, 65);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(313, 30);
            this.txtad.TabIndex = 9;
            this.txtad.Tag = "";
            this.txtad.Text = "Ara...";
            this.txtad.TextChanged += new System.EventHandler(this.txtad_TextChanged);
            this.txtad.Enter += new System.EventHandler(this.txtad_Enter);
            this.txtad.Leave += new System.EventHandler(this.txtad_Leave);
            // 
            // Satislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 715);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(600, 180);
            this.Name = "Satislar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Satislar";
            this.Load += new System.EventHandler(this.Satislar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Film_İsim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salon_İsim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Film_Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Film_Saati;
        private System.Windows.Forms.DataGridViewTextBoxColumn Koltuk_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucret;
    }
}