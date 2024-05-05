namespace CinemaAutomation
{
    partial class AddMovie
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
            this.txtfilmad = new System.Windows.Forms.TextBox();
            this.filmnamepnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.combofilmtur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtfilmsure = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtyapımcı = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filmıd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmtur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmsure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yapimci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnafis = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.filmnamepnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.panel1.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yeni Film Ekle";
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
            // txtfilmad
            // 
            this.txtfilmad.BackColor = System.Drawing.SystemColors.Control;
            this.txtfilmad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfilmad.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtfilmad.Location = new System.Drawing.Point(120, 9);
            this.txtfilmad.Name = "txtfilmad";
            this.txtfilmad.Size = new System.Drawing.Size(361, 26);
            this.txtfilmad.TabIndex = 8;
            this.txtfilmad.Click += new System.EventHandler(this.txtfilmad_Click);
            // 
            // filmnamepnl
            // 
            this.filmnamepnl.BackColor = System.Drawing.SystemColors.Control;
            this.filmnamepnl.Controls.Add(this.label2);
            this.filmnamepnl.Controls.Add(this.txtfilmad);
            this.filmnamepnl.Location = new System.Drawing.Point(12, 109);
            this.filmnamepnl.Name = "filmnamepnl";
            this.filmnamepnl.Size = new System.Drawing.Size(489, 45);
            this.filmnamepnl.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Film İsmi :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.combofilmtur);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 45);
            this.panel2.TabIndex = 9;
            // 
            // combofilmtur
            // 
            this.combofilmtur.BackColor = System.Drawing.Color.White;
            this.combofilmtur.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combofilmtur.FormattingEnabled = true;
            this.combofilmtur.Location = new System.Drawing.Point(120, 7);
            this.combofilmtur.Name = "combofilmtur";
            this.combofilmtur.Size = new System.Drawing.Size(361, 32);
            this.combofilmtur.TabIndex = 8;
            this.combofilmtur.Click += new System.EventHandler(this.combofilmtur_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Film Türü :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.txtfilmsure);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(12, 211);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 45);
            this.panel3.TabIndex = 9;
            // 
            // txtfilmsure
            // 
            this.txtfilmsure.BackColor = System.Drawing.SystemColors.Control;
            this.txtfilmsure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfilmsure.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtfilmsure.Location = new System.Drawing.Point(120, 10);
            this.txtfilmsure.Name = "txtfilmsure";
            this.txtfilmsure.Size = new System.Drawing.Size(361, 26);
            this.txtfilmsure.TabIndex = 10;
            this.txtfilmsure.Click += new System.EventHandler(this.txtfilmsure_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Film Süresi :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.txtyapımcı);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(12, 262);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(489, 45);
            this.panel4.TabIndex = 9;
            // 
            // txtyapımcı
            // 
            this.txtyapımcı.BackColor = System.Drawing.SystemColors.Control;
            this.txtyapımcı.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtyapımcı.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyapımcı.Location = new System.Drawing.Point(120, 9);
            this.txtyapımcı.Name = "txtyapımcı";
            this.txtyapımcı.Size = new System.Drawing.Size(361, 26);
            this.txtyapımcı.TabIndex = 11;
            this.txtyapımcı.Click += new System.EventHandler(this.txtyapımcı_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(23, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Yapımcı :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmıd,
            this.filmad,
            this.filmtur,
            this.filmsure,
            this.yapimci,
            this.resim});
            this.dataGridView1.Location = new System.Drawing.Point(12, 448);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 255);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // filmıd
            // 
            this.filmıd.DataPropertyName = "filmıd";
            this.filmıd.HeaderText = "Film ID";
            this.filmıd.Name = "filmıd";
            // 
            // filmad
            // 
            this.filmad.DataPropertyName = "filmad";
            this.filmad.HeaderText = "Film İsmi";
            this.filmad.Name = "filmad";
            // 
            // filmtur
            // 
            this.filmtur.DataPropertyName = "filmtur";
            this.filmtur.HeaderText = "Film Türü";
            this.filmtur.Name = "filmtur";
            // 
            // filmsure
            // 
            this.filmsure.DataPropertyName = "filmsure";
            this.filmsure.HeaderText = "Film Süresi(dk)";
            this.filmsure.Name = "filmsure";
            // 
            // yapimci
            // 
            this.yapimci.DataPropertyName = "yapimci";
            this.yapimci.HeaderText = "Yapımcı";
            this.yapimci.Name = "yapimci";
            // 
            // resim
            // 
            this.resim.DataPropertyName = "resim";
            this.resim.HeaderText = "Resim";
            this.resim.Name = "resim";
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnekle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.ForeColor = System.Drawing.Color.White;
            this.btnekle.Location = new System.Drawing.Point(15, 363);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(178, 46);
            this.btnekle.TabIndex = 12;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.SteelBlue;
            this.btnsil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.Color.White;
            this.btnsil.Location = new System.Drawing.Point(215, 363);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(178, 46);
            this.btnsil.TabIndex = 13;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.button3_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.Color.SteelBlue;
            this.btngüncelle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncelle.ForeColor = System.Drawing.Color.White;
            this.btngüncelle.Location = new System.Drawing.Point(404, 363);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(178, 46);
            this.btngüncelle.TabIndex = 14;
            this.btngüncelle.Text = "GÜNCELLE";
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnafis
            // 
            this.btnafis.BackColor = System.Drawing.Color.SteelBlue;
            this.btnafis.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnafis.ForeColor = System.Drawing.Color.White;
            this.btnafis.Location = new System.Drawing.Point(689, 384);
            this.btnafis.Name = "btnafis";
            this.btnafis.Size = new System.Drawing.Size(178, 46);
            this.btnafis.TabIndex = 15;
            this.btnafis.Text = "AFİŞ EKLE";
            this.btnafis.UseVisualStyleBackColor = false;
            this.btnafis.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(630, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(293, 292);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 715);
            this.Controls.Add(this.btnafis);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.filmnamepnl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(600, 180);
            this.Name = "AddMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddMovie";
            this.Load += new System.EventHandler(this.AddMovie_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.filmnamepnl.ResumeLayout(false);
            this.filmnamepnl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtfilmad;
        private System.Windows.Forms.Panel filmnamepnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfilmsure;
        private System.Windows.Forms.TextBox txtyapımcı;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.ComboBox combofilmtur;
        private System.Windows.Forms.Button btnafis;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmıd;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmad;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmtur;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmsure;
        private System.Windows.Forms.DataGridViewTextBoxColumn yapimci;
        private System.Windows.Forms.DataGridViewTextBoxColumn resim;
    }
}