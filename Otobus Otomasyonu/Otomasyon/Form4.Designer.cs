namespace Otomasyon
{
    partial class Form4
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvSeferler = new System.Windows.Forms.DataGridView();
            this.tbSeferNo = new System.Windows.Forms.TextBox();
            this.tbSeferAdi = new System.Windows.Forms.TextBox();
            this.dtpSeferTarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSeferSaati = new System.Windows.Forms.TextBox();
            this.tbPeronNo = new System.Windows.Forms.TextBox();
            this.gbSeferİslemleri = new System.Windows.Forms.GroupBox();
            this.cbOtobusAdi = new System.Windows.Forms.ComboBox();
            this.tbSeferUcreti = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btOtobusTemizle = new System.Windows.Forms.Button();
            this.btOtobusGuncelle = new System.Windows.Forms.Button();
            this.btOtobusSil = new System.Windows.Forms.Button();
            this.btOtobusEkle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferler)).BeginInit();
            this.gbSeferİslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(392, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sefer İşlemleri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Otomasyon.Properties.Resources.islem_icon;
            this.pictureBox1.Location = new System.Drawing.Point(26, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dgvSeferler
            // 
            this.dgvSeferler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeferler.Location = new System.Drawing.Point(42, 85);
            this.dgvSeferler.Name = "dgvSeferler";
            this.dgvSeferler.RowTemplate.Height = 24;
            this.dgvSeferler.Size = new System.Drawing.Size(977, 176);
            this.dgvSeferler.TabIndex = 2;
            this.dgvSeferler.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSeferler_RowHeaderMouseClick);
            // 
            // tbSeferNo
            // 
            this.tbSeferNo.Location = new System.Drawing.Point(159, 53);
            this.tbSeferNo.Multiline = true;
            this.tbSeferNo.Name = "tbSeferNo";
            this.tbSeferNo.Size = new System.Drawing.Size(198, 27);
            this.tbSeferNo.TabIndex = 1;
            // 
            // tbSeferAdi
            // 
            this.tbSeferAdi.Location = new System.Drawing.Point(159, 88);
            this.tbSeferAdi.Multiline = true;
            this.tbSeferAdi.Name = "tbSeferAdi";
            this.tbSeferAdi.Size = new System.Drawing.Size(198, 27);
            this.tbSeferAdi.TabIndex = 2;
            // 
            // dtpSeferTarihi
            // 
            this.dtpSeferTarihi.CalendarFont = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpSeferTarihi.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpSeferTarihi.Location = new System.Drawing.Point(159, 122);
            this.dtpSeferTarihi.Name = "dtpSeferTarihi";
            this.dtpSeferTarihi.Size = new System.Drawing.Size(198, 26);
            this.dtpSeferTarihi.TabIndex = 3;
            this.dtpSeferTarihi.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sefer Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sefer No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(37, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sefer Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(37, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sefer Saati :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(626, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Otobüs Adı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(628, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Peron No :";
            // 
            // tbSeferSaati
            // 
            this.tbSeferSaati.Location = new System.Drawing.Point(159, 158);
            this.tbSeferSaati.Multiline = true;
            this.tbSeferSaati.Name = "tbSeferSaati";
            this.tbSeferSaati.Size = new System.Drawing.Size(198, 27);
            this.tbSeferSaati.TabIndex = 4;
            // 
            // tbPeronNo
            // 
            this.tbPeronNo.Location = new System.Drawing.Point(744, 88);
            this.tbPeronNo.Multiline = true;
            this.tbPeronNo.Name = "tbPeronNo";
            this.tbPeronNo.Size = new System.Drawing.Size(198, 27);
            this.tbPeronNo.TabIndex = 6;
            // 
            // gbSeferİslemleri
            // 
            this.gbSeferİslemleri.Controls.Add(this.cbOtobusAdi);
            this.gbSeferİslemleri.Controls.Add(this.tbSeferUcreti);
            this.gbSeferİslemleri.Controls.Add(this.label8);
            this.gbSeferİslemleri.Controls.Add(this.btOtobusTemizle);
            this.gbSeferİslemleri.Controls.Add(this.btOtobusGuncelle);
            this.gbSeferİslemleri.Controls.Add(this.btOtobusSil);
            this.gbSeferİslemleri.Controls.Add(this.btOtobusEkle);
            this.gbSeferİslemleri.Controls.Add(this.tbPeronNo);
            this.gbSeferİslemleri.Controls.Add(this.tbSeferNo);
            this.gbSeferİslemleri.Controls.Add(this.tbSeferAdi);
            this.gbSeferİslemleri.Controls.Add(this.dtpSeferTarihi);
            this.gbSeferİslemleri.Controls.Add(this.tbSeferSaati);
            this.gbSeferİslemleri.Controls.Add(this.label2);
            this.gbSeferİslemleri.Controls.Add(this.label7);
            this.gbSeferİslemleri.Controls.Add(this.label3);
            this.gbSeferİslemleri.Controls.Add(this.label6);
            this.gbSeferİslemleri.Controls.Add(this.label4);
            this.gbSeferİslemleri.Controls.Add(this.label5);
            this.gbSeferİslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbSeferİslemleri.Location = new System.Drawing.Point(42, 310);
            this.gbSeferİslemleri.Name = "gbSeferİslemleri";
            this.gbSeferİslemleri.Size = new System.Drawing.Size(977, 222);
            this.gbSeferİslemleri.TabIndex = 7;
            this.gbSeferİslemleri.TabStop = false;
            this.gbSeferİslemleri.Text = "Sefer İşlemleri";
            // 
            // cbOtobusAdi
            // 
            this.cbOtobusAdi.FormattingEnabled = true;
            this.cbOtobusAdi.Location = new System.Drawing.Point(744, 56);
            this.cbOtobusAdi.Name = "cbOtobusAdi";
            this.cbOtobusAdi.Size = new System.Drawing.Size(198, 28);
            this.cbOtobusAdi.TabIndex = 5;
            // 
            // tbSeferUcreti
            // 
            this.tbSeferUcreti.Location = new System.Drawing.Point(744, 122);
            this.tbSeferUcreti.Name = "tbSeferUcreti";
            this.tbSeferUcreti.Size = new System.Drawing.Size(198, 27);
            this.tbSeferUcreti.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(628, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sefer Ücreti :";
            // 
            // btOtobusTemizle
            // 
            this.btOtobusTemizle.Font = new System.Drawing.Font("Candara", 9.5F);
            this.btOtobusTemizle.Location = new System.Drawing.Point(882, 154);
            this.btOtobusTemizle.Name = "btOtobusTemizle";
            this.btOtobusTemizle.Size = new System.Drawing.Size(89, 28);
            this.btOtobusTemizle.TabIndex = 11;
            this.btOtobusTemizle.Text = "Temizle";
            this.btOtobusTemizle.UseVisualStyleBackColor = true;
            this.btOtobusTemizle.Click += new System.EventHandler(this.btOtobusTemizle_Click);
            // 
            // btOtobusGuncelle
            // 
            this.btOtobusGuncelle.Font = new System.Drawing.Font("Candara", 9.5F);
            this.btOtobusGuncelle.Location = new System.Drawing.Point(787, 154);
            this.btOtobusGuncelle.Name = "btOtobusGuncelle";
            this.btOtobusGuncelle.Size = new System.Drawing.Size(89, 28);
            this.btOtobusGuncelle.TabIndex = 10;
            this.btOtobusGuncelle.Text = "Güncelle";
            this.btOtobusGuncelle.UseVisualStyleBackColor = true;
            this.btOtobusGuncelle.Click += new System.EventHandler(this.btOtobusGuncelle_Click);
            // 
            // btOtobusSil
            // 
            this.btOtobusSil.Font = new System.Drawing.Font("Candara", 9.5F);
            this.btOtobusSil.Location = new System.Drawing.Point(692, 154);
            this.btOtobusSil.Name = "btOtobusSil";
            this.btOtobusSil.Size = new System.Drawing.Size(89, 28);
            this.btOtobusSil.TabIndex = 9;
            this.btOtobusSil.Text = "Sil";
            this.btOtobusSil.UseVisualStyleBackColor = true;
            this.btOtobusSil.Click += new System.EventHandler(this.btOtobusSil_Click);
            // 
            // btOtobusEkle
            // 
            this.btOtobusEkle.Font = new System.Drawing.Font("Candara", 9.5F);
            this.btOtobusEkle.Location = new System.Drawing.Point(597, 154);
            this.btOtobusEkle.Name = "btOtobusEkle";
            this.btOtobusEkle.Size = new System.Drawing.Size(89, 28);
            this.btOtobusEkle.TabIndex = 8;
            this.btOtobusEkle.Text = "Ekle";
            this.btOtobusEkle.UseVisualStyleBackColor = true;
            this.btOtobusEkle.Click += new System.EventHandler(this.btOtobusEkle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 8F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(789, 546);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Hulusi Bindebir * hulusi-bindebir.com";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1064, 572);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvSeferler);
            this.Controls.Add(this.gbSeferİslemleri);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Sefer İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferler)).EndInit();
            this.gbSeferİslemleri.ResumeLayout(false);
            this.gbSeferİslemleri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvSeferler;
        private System.Windows.Forms.TextBox tbSeferNo;
        private System.Windows.Forms.TextBox tbSeferAdi;
        private System.Windows.Forms.DateTimePicker dtpSeferTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSeferSaati;
        private System.Windows.Forms.TextBox tbPeronNo;
        private System.Windows.Forms.GroupBox gbSeferİslemleri;
        private System.Windows.Forms.Button btOtobusTemizle;
        private System.Windows.Forms.Button btOtobusGuncelle;
        private System.Windows.Forms.Button btOtobusSil;
        private System.Windows.Forms.Button btOtobusEkle;
        private System.Windows.Forms.TextBox tbSeferUcreti;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbOtobusAdi;
        private System.Windows.Forms.Label label9;
    }
}