namespace CinemaAutomation
{
    partial class SeansEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SeansId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Film_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Film_Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Film_Saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Film_Salon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Film_Tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.combotur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.filmnamepnl = new System.Windows.Forms.Panel();
            this.combofilmisim = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboseanssaat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.combosalon = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtad = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.filmnamepnl.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(54, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yeni Seans Ekle";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 48);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(936, 0);
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
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.Color.DarkRed;
            this.btngüncelle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncelle.ForeColor = System.Drawing.Color.White;
            this.btngüncelle.Location = new System.Drawing.Point(693, 489);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(178, 46);
            this.btngüncelle.TabIndex = 22;
            this.btngüncelle.Text = "GÜNCELLE";
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.DarkRed;
            this.btnsil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.Color.White;
            this.btnsil.Location = new System.Drawing.Point(777, 428);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(178, 46);
            this.btnsil.TabIndex = 21;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.DarkRed;
            this.btnekle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.ForeColor = System.Drawing.Color.Transparent;
            this.btnekle.Location = new System.Drawing.Point(593, 428);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(178, 46);
            this.btnekle.TabIndex = 20;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeansId,
            this.Film_ad,
            this.Film_Tarih,
            this.Film_Saat,
            this.Film_Salon,
            this.Film_Tur});
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(520, 458);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SeansId
            // 
            this.SeansId.DataPropertyName = "SeansId";
            this.SeansId.HeaderText = "Seans ID";
            this.SeansId.Name = "SeansId";
            // 
            // Film_ad
            // 
            this.Film_ad.DataPropertyName = "Film_ad";
            this.Film_ad.HeaderText = "Film Ad";
            this.Film_ad.Name = "Film_ad";
            // 
            // Film_Tarih
            // 
            this.Film_Tarih.DataPropertyName = "Film_Tarih";
            this.Film_Tarih.HeaderText = "Film Tarihi";
            this.Film_Tarih.Name = "Film_Tarih";
            // 
            // Film_Saat
            // 
            this.Film_Saat.DataPropertyName = "Film_Saat";
            this.Film_Saat.HeaderText = "Film Saati";
            this.Film_Saat.Name = "Film_Saat";
            // 
            // Film_Salon
            // 
            this.Film_Salon.DataPropertyName = "Film_Salon";
            this.Film_Salon.HeaderText = "Salon";
            this.Film_Salon.Name = "Film_Salon";
            // 
            // Film_Tur
            // 
            this.Film_Tur.DataPropertyName = "Film_Tur";
            this.Film_Tur.HeaderText = "Film Türü";
            this.Film_Tur.Name = "Film_Tur";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.combotur);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(538, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 45);
            this.panel2.TabIndex = 18;
            // 
            // combotur
            // 
            this.combotur.BackColor = System.Drawing.Color.White;
            this.combotur.Enabled = false;
            this.combotur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.combotur.FormattingEnabled = true;
            this.combotur.Location = new System.Drawing.Point(104, 9);
            this.combotur.Name = "combotur";
            this.combotur.Size = new System.Drawing.Size(313, 29);
            this.combotur.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Film Türü :";
            // 
            // filmnamepnl
            // 
            this.filmnamepnl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.filmnamepnl.Controls.Add(this.combofilmisim);
            this.filmnamepnl.Controls.Add(this.label2);
            this.filmnamepnl.Location = new System.Drawing.Point(538, 137);
            this.filmnamepnl.Name = "filmnamepnl";
            this.filmnamepnl.Size = new System.Drawing.Size(433, 45);
            this.filmnamepnl.TabIndex = 15;
            // 
            // combofilmisim
            // 
            this.combofilmisim.BackColor = System.Drawing.Color.White;
            this.combofilmisim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combofilmisim.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.combofilmisim.FormattingEnabled = true;
            this.combofilmisim.Location = new System.Drawing.Point(104, 8);
            this.combofilmisim.Name = "combofilmisim";
            this.combofilmisim.Size = new System.Drawing.Size(313, 29);
            this.combofilmisim.TabIndex = 9;
            this.combofilmisim.SelectionChangeCommitted += new System.EventHandler(this.combofilmisim_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(7, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Film İsmi :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(538, 239);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(433, 45);
            this.panel4.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 12);
            this.dateTimePicker1.MaxDate = new System.DateTime(2050, 12, 12, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(313, 27);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2024, 5, 27, 15, 11, 43, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(36, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tarih :";
            // 
            // comboseanssaat
            // 
            this.comboseanssaat.BackColor = System.Drawing.Color.White;
            this.comboseanssaat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboseanssaat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.comboseanssaat.FormattingEnabled = true;
            this.comboseanssaat.Location = new System.Drawing.Point(104, 8);
            this.comboseanssaat.Name = "comboseanssaat";
            this.comboseanssaat.Size = new System.Drawing.Size(313, 29);
            this.comboseanssaat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(2, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Seans Saati :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.comboseanssaat);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(538, 290);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 45);
            this.panel3.TabIndex = 16;
            // 
            // combosalon
            // 
            this.combosalon.BackColor = System.Drawing.Color.White;
            this.combosalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combosalon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.combosalon.FormattingEnabled = true;
            this.combosalon.Location = new System.Drawing.Point(104, 8);
            this.combosalon.Name = "combosalon";
            this.combosalon.Size = new System.Drawing.Size(313, 29);
            this.combosalon.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(29, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Salon :";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Controls.Add(this.combosalon);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(538, 341);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(433, 45);
            this.panel5.TabIndex = 17;
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtad.Location = new System.Drawing.Point(15, 64);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(313, 30);
            this.txtad.TabIndex = 23;
            this.txtad.Tag = "";
            this.txtad.TextChanged += new System.EventHandler(this.txtad_TextChanged);
            // 
            // SeansEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(983, 570);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.filmnamepnl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(600, 250);
            this.Name = "SeansEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SeansEkle";
            this.Load += new System.EventHandler(this.SeansEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.filmnamepnl.ResumeLayout(false);
            this.filmnamepnl.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel filmnamepnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combofilmisim;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboseanssaat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox combotur;
        private System.Windows.Forms.ComboBox combosalon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeansId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Film_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Film_Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Film_Saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Film_Salon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Film_Tur;
        private System.Windows.Forms.TextBox txtad;
    }
}