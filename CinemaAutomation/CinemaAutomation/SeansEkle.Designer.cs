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
            this.panel2 = new System.Windows.Forms.Panel();
            this.combofilmtur = new System.Windows.Forms.ComboBox();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.filmnamepnl.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yeni Seans Ekle";
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
            this.panel1.Size = new System.Drawing.Size(894, 48);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(847, 0);
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
            this.btngüncelle.BackColor = System.Drawing.Color.SteelBlue;
            this.btngüncelle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncelle.ForeColor = System.Drawing.Color.White;
            this.btngüncelle.Location = new System.Drawing.Point(594, 454);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(178, 46);
            this.btngüncelle.TabIndex = 22;
            this.btngüncelle.Text = "GÜNCELLE";
            this.btngüncelle.UseVisualStyleBackColor = false;
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.SteelBlue;
            this.btnsil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.Color.White;
            this.btnsil.Location = new System.Drawing.Point(678, 393);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(178, 46);
            this.btnsil.TabIndex = 21;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnekle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.ForeColor = System.Drawing.Color.White;
            this.btnekle.Location = new System.Drawing.Point(494, 393);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(178, 46);
            this.btnekle.TabIndex = 20;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeansId,
            this.Film_ad,
            this.Film_Tarih,
            this.Film_Saat});
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(439, 458);
            this.dataGridView1.TabIndex = 19;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.combofilmtur);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(457, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 45);
            this.panel2.TabIndex = 18;
            // 
            // combofilmtur
            // 
            this.combofilmtur.BackColor = System.Drawing.Color.White;
            this.combofilmtur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.combofilmtur.FormattingEnabled = true;
            this.combofilmtur.Location = new System.Drawing.Point(104, 8);
            this.combofilmtur.Name = "combofilmtur";
            this.combofilmtur.Size = new System.Drawing.Size(313, 29);
            this.combofilmtur.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Film Türü :";
            // 
            // filmnamepnl
            // 
            this.filmnamepnl.BackColor = System.Drawing.SystemColors.Control;
            this.filmnamepnl.Controls.Add(this.combofilmisim);
            this.filmnamepnl.Controls.Add(this.label2);
            this.filmnamepnl.Location = new System.Drawing.Point(457, 135);
            this.filmnamepnl.Name = "filmnamepnl";
            this.filmnamepnl.Size = new System.Drawing.Size(433, 45);
            this.filmnamepnl.TabIndex = 15;
            // 
            // combofilmisim
            // 
            this.combofilmisim.BackColor = System.Drawing.Color.White;
            this.combofilmisim.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.combofilmisim.FormattingEnabled = true;
            this.combofilmisim.Location = new System.Drawing.Point(104, 8);
            this.combofilmisim.Name = "combofilmisim";
            this.combofilmisim.Size = new System.Drawing.Size(313, 29);
            this.combofilmisim.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Film İsmi :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(457, 237);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(433, 45);
            this.panel4.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 12);
            this.dateTimePicker1.MaxDate = new System.DateTime(2024, 4, 30, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(313, 27);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2024, 4, 30, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(36, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tarih :";
            // 
            // comboseanssaat
            // 
            this.comboseanssaat.BackColor = System.Drawing.Color.White;
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
            this.label5.Location = new System.Drawing.Point(2, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Seans Saati :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.comboseanssaat);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(457, 288);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 45);
            this.panel3.TabIndex = 16;
            // 
            // SeansEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 536);
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
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox combofilmtur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel filmnamepnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combofilmisim;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeansId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Film_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Film_Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Film_Saat;
        private System.Windows.Forms.ComboBox comboseanssaat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
    }
}