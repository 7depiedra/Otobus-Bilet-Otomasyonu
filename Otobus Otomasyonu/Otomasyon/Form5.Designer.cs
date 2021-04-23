namespace Otomasyon
{
    partial class Form5
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSeferler2 = new System.Windows.Forms.DataGridView();
            this.gbSeferler = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbBiletRezervasyon = new System.Windows.Forms.GroupBox();
            this.btRezervasyonYap = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.gbSefer = new System.Windows.Forms.GroupBox();
            this.tbKoltukNo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbSeferUcreti = new System.Windows.Forms.TextBox();
            this.tbPeronNo = new System.Windows.Forms.TextBox();
            this.tbOtobusAdi = new System.Windows.Forms.TextBox();
            this.tbSeferSaati = new System.Windows.Forms.TextBox();
            this.tbSeferTarihi = new System.Windows.Forms.TextBox();
            this.tbSeferAdi = new System.Windows.Forms.TextBox();
            this.tbSeferNo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbMusteri = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMusteriTelNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMusteriNo = new System.Windows.Forms.TextBox();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.tbMusteriAdi = new System.Windows.Forms.TextBox();
            this.tbMusteriSoyadi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbKadın = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferler2)).BeginInit();
            this.gbSeferler.SuspendLayout();
            this.gbBiletRezervasyon.SuspendLayout();
            this.gbSefer.SuspendLayout();
            this.gbMusteri.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Otomasyon.Properties.Resources.bilet_icon;
            this.pictureBox1.Location = new System.Drawing.Point(26, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(371, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bilet Rezervasyon";
            // 
            // dgvSeferler2
            // 
            this.dgvSeferler2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeferler2.Location = new System.Drawing.Point(21, 78);
            this.dgvSeferler2.Name = "dgvSeferler2";
            this.dgvSeferler2.RowTemplate.Height = 24;
            this.dgvSeferler2.Size = new System.Drawing.Size(980, 194);
            this.dgvSeferler2.TabIndex = 2;
            this.dgvSeferler2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSeferler2_RowHeaderMouseClick);
            // 
            // gbSeferler
            // 
            this.gbSeferler.Controls.Add(this.label8);
            this.gbSeferler.Controls.Add(this.dgvSeferler2);
            this.gbSeferler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbSeferler.Location = new System.Drawing.Point(29, 46);
            this.gbSeferler.Name = "gbSeferler";
            this.gbSeferler.Size = new System.Drawing.Size(1023, 302);
            this.gbSeferler.TabIndex = 3;
            this.gbSeferler.TabStop = false;
            this.gbSeferler.Text = "Seferler";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(17, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "* Sefer seçimini buradan yapınız.";
            // 
            // gbBiletRezervasyon
            // 
            this.gbBiletRezervasyon.Controls.Add(this.btRezervasyonYap);
            this.gbBiletRezervasyon.Controls.Add(this.label15);
            this.gbBiletRezervasyon.Controls.Add(this.gbSefer);
            this.gbBiletRezervasyon.Controls.Add(this.gbMusteri);
            this.gbBiletRezervasyon.Controls.Add(this.gbSeferler);
            this.gbBiletRezervasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbBiletRezervasyon.Location = new System.Drawing.Point(26, 90);
            this.gbBiletRezervasyon.Name = "gbBiletRezervasyon";
            this.gbBiletRezervasyon.Size = new System.Drawing.Size(1080, 758);
            this.gbBiletRezervasyon.TabIndex = 4;
            this.gbBiletRezervasyon.TabStop = false;
            this.gbBiletRezervasyon.Text = "Bilet Rezervasyon";
            // 
            // btRezervasyonYap
            // 
            this.btRezervasyonYap.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btRezervasyonYap.Location = new System.Drawing.Point(460, 702);
            this.btRezervasyonYap.Name = "btRezervasyonYap";
            this.btRezervasyonYap.Size = new System.Drawing.Size(168, 39);
            this.btRezervasyonYap.TabIndex = 6;
            this.btRezervasyonYap.Text = "Rezervasyon Yap";
            this.btRezervasyonYap.UseVisualStyleBackColor = true;
            this.btRezervasyonYap.Click += new System.EventHandler(this.btRezervasyonYap_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(378, 668);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(323, 21);
            this.label15.TabIndex = 9;
            this.label15.Text = "* Müşteri ve sefer bilgilerini kontrol ediniz.";
            // 
            // gbSefer
            // 
            this.gbSefer.Controls.Add(this.tbKoltukNo);
            this.gbSefer.Controls.Add(this.label16);
            this.gbSefer.Controls.Add(this.tbSeferUcreti);
            this.gbSefer.Controls.Add(this.tbPeronNo);
            this.gbSefer.Controls.Add(this.tbOtobusAdi);
            this.gbSefer.Controls.Add(this.tbSeferSaati);
            this.gbSefer.Controls.Add(this.tbSeferTarihi);
            this.gbSefer.Controls.Add(this.tbSeferAdi);
            this.gbSefer.Controls.Add(this.tbSeferNo);
            this.gbSefer.Controls.Add(this.label14);
            this.gbSefer.Controls.Add(this.label13);
            this.gbSefer.Controls.Add(this.label12);
            this.gbSefer.Controls.Add(this.label11);
            this.gbSefer.Controls.Add(this.label10);
            this.gbSefer.Controls.Add(this.label9);
            this.gbSefer.Controls.Add(this.label7);
            this.gbSefer.Location = new System.Drawing.Point(552, 378);
            this.gbSefer.Name = "gbSefer";
            this.gbSefer.Size = new System.Drawing.Size(500, 287);
            this.gbSefer.TabIndex = 8;
            this.gbSefer.TabStop = false;
            this.gbSefer.Text = "Sefer";
            // 
            // tbKoltukNo
            // 
            this.tbKoltukNo.Location = new System.Drawing.Point(243, 243);
            this.tbKoltukNo.Name = "tbKoltukNo";
            this.tbKoltukNo.Size = new System.Drawing.Size(148, 27);
            this.tbKoltukNo.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(114, 246);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 21);
            this.label16.TabIndex = 2;
            this.label16.Text = "Koltuk No :";
            // 
            // tbSeferUcreti
            // 
            this.tbSeferUcreti.Location = new System.Drawing.Point(243, 212);
            this.tbSeferUcreti.Name = "tbSeferUcreti";
            this.tbSeferUcreti.ReadOnly = true;
            this.tbSeferUcreti.Size = new System.Drawing.Size(148, 27);
            this.tbSeferUcreti.TabIndex = 1;
            // 
            // tbPeronNo
            // 
            this.tbPeronNo.Location = new System.Drawing.Point(243, 181);
            this.tbPeronNo.Name = "tbPeronNo";
            this.tbPeronNo.ReadOnly = true;
            this.tbPeronNo.Size = new System.Drawing.Size(148, 27);
            this.tbPeronNo.TabIndex = 1;
            // 
            // tbOtobusAdi
            // 
            this.tbOtobusAdi.Location = new System.Drawing.Point(243, 150);
            this.tbOtobusAdi.Name = "tbOtobusAdi";
            this.tbOtobusAdi.ReadOnly = true;
            this.tbOtobusAdi.Size = new System.Drawing.Size(148, 27);
            this.tbOtobusAdi.TabIndex = 1;
            // 
            // tbSeferSaati
            // 
            this.tbSeferSaati.Location = new System.Drawing.Point(243, 119);
            this.tbSeferSaati.Name = "tbSeferSaati";
            this.tbSeferSaati.ReadOnly = true;
            this.tbSeferSaati.Size = new System.Drawing.Size(148, 27);
            this.tbSeferSaati.TabIndex = 1;
            // 
            // tbSeferTarihi
            // 
            this.tbSeferTarihi.Location = new System.Drawing.Point(243, 88);
            this.tbSeferTarihi.Name = "tbSeferTarihi";
            this.tbSeferTarihi.ReadOnly = true;
            this.tbSeferTarihi.Size = new System.Drawing.Size(148, 27);
            this.tbSeferTarihi.TabIndex = 1;
            // 
            // tbSeferAdi
            // 
            this.tbSeferAdi.Location = new System.Drawing.Point(243, 57);
            this.tbSeferAdi.Name = "tbSeferAdi";
            this.tbSeferAdi.ReadOnly = true;
            this.tbSeferAdi.Size = new System.Drawing.Size(148, 27);
            this.tbSeferAdi.TabIndex = 1;
            // 
            // tbSeferNo
            // 
            this.tbSeferNo.Location = new System.Drawing.Point(243, 26);
            this.tbSeferNo.Name = "tbSeferNo";
            this.tbSeferNo.ReadOnly = true;
            this.tbSeferNo.Size = new System.Drawing.Size(148, 27);
            this.tbSeferNo.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(114, 215);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 21);
            this.label14.TabIndex = 0;
            this.label14.Text = "Sefer Ücreti :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(114, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "Peron No :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(114, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "Otobüs Adı :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(114, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Sefer Saati :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(114, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sefer Tarihi :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(114, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sefer Adı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(114, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sefer No :";
            // 
            // gbMusteri
            // 
            this.gbMusteri.Controls.Add(this.label4);
            this.gbMusteri.Controls.Add(this.tbMusteriTelNo);
            this.gbMusteri.Controls.Add(this.label5);
            this.gbMusteri.Controls.Add(this.label2);
            this.gbMusteri.Controls.Add(this.tbMusteriNo);
            this.gbMusteri.Controls.Add(this.rbErkek);
            this.gbMusteri.Controls.Add(this.tbMusteriAdi);
            this.gbMusteri.Controls.Add(this.tbMusteriSoyadi);
            this.gbMusteri.Controls.Add(this.label6);
            this.gbMusteri.Controls.Add(this.rbKadın);
            this.gbMusteri.Controls.Add(this.label3);
            this.gbMusteri.Location = new System.Drawing.Point(29, 378);
            this.gbMusteri.Name = "gbMusteri";
            this.gbMusteri.Size = new System.Drawing.Size(500, 287);
            this.gbMusteri.TabIndex = 7;
            this.gbMusteri.TabStop = false;
            this.gbMusteri.Text = "Müşteri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(109, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "No :";
            // 
            // tbMusteriTelNo
            // 
            this.tbMusteriTelNo.Location = new System.Drawing.Point(236, 209);
            this.tbMusteriTelNo.Name = "tbMusteriTelNo";
            this.tbMusteriTelNo.Size = new System.Drawing.Size(148, 27);
            this.tbMusteriTelNo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(109, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cinsiyeti :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(109, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı :";
            // 
            // tbMusteriNo
            // 
            this.tbMusteriNo.Location = new System.Drawing.Point(236, 37);
            this.tbMusteriNo.Name = "tbMusteriNo";
            this.tbMusteriNo.ReadOnly = true;
            this.tbMusteriNo.Size = new System.Drawing.Size(148, 27);
            this.tbMusteriNo.TabIndex = 6;
            // 
            // rbErkek
            // 
            this.rbErkek.AccessibleDescription = "";
            this.rbErkek.AutoSize = true;
            this.rbErkek.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbErkek.Location = new System.Drawing.Point(236, 167);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(71, 25);
            this.rbErkek.TabIndex = 3;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // tbMusteriAdi
            // 
            this.tbMusteriAdi.Location = new System.Drawing.Point(236, 80);
            this.tbMusteriAdi.Name = "tbMusteriAdi";
            this.tbMusteriAdi.Size = new System.Drawing.Size(148, 27);
            this.tbMusteriAdi.TabIndex = 1;
            // 
            // tbMusteriSoyadi
            // 
            this.tbMusteriSoyadi.Location = new System.Drawing.Point(236, 123);
            this.tbMusteriSoyadi.Name = "tbMusteriSoyadi";
            this.tbMusteriSoyadi.Size = new System.Drawing.Size(148, 27);
            this.tbMusteriSoyadi.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(109, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Telefon No :";
            // 
            // rbKadın
            // 
            this.rbKadın.AccessibleDescription = "";
            this.rbKadın.AutoSize = true;
            this.rbKadın.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKadın.Location = new System.Drawing.Point(313, 167);
            this.rbKadın.Name = "rbKadın";
            this.rbKadın.Size = new System.Drawing.Size(71, 25);
            this.rbKadın.TabIndex = 4;
            this.rbKadın.TabStop = true;
            this.rbKadın.Text = "Kadın";
            this.rbKadın.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(109, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyadı :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Candara", 8F);
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(876, 857);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(230, 17);
            this.label17.TabIndex = 5;
            this.label17.Text = "Hulusi Bindebir * hulusi-bindebir.com";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1139, 883);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.gbBiletRezervasyon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form5";
            this.Text = "Bilet Satış";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferler2)).EndInit();
            this.gbSeferler.ResumeLayout(false);
            this.gbSeferler.PerformLayout();
            this.gbBiletRezervasyon.ResumeLayout(false);
            this.gbBiletRezervasyon.PerformLayout();
            this.gbSefer.ResumeLayout(false);
            this.gbSefer.PerformLayout();
            this.gbMusteri.ResumeLayout(false);
            this.gbMusteri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSeferler2;
        private System.Windows.Forms.GroupBox gbSeferler;
        private System.Windows.Forms.GroupBox gbBiletRezervasyon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbSefer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbMusteri;
        private System.Windows.Forms.TextBox tbMusteriTelNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMusteriNo;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.TextBox tbMusteriAdi;
        private System.Windows.Forms.TextBox tbMusteriSoyadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbKadın;
        private System.Windows.Forms.TextBox tbSeferUcreti;
        private System.Windows.Forms.TextBox tbPeronNo;
        private System.Windows.Forms.TextBox tbOtobusAdi;
        private System.Windows.Forms.TextBox tbSeferSaati;
        private System.Windows.Forms.TextBox tbSeferTarihi;
        private System.Windows.Forms.TextBox tbSeferAdi;
        private System.Windows.Forms.TextBox tbSeferNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btRezervasyonYap;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbKoltukNo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}