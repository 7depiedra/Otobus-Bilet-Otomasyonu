namespace Otomasyon
{
    partial class Form3
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
            this.dgvOtobusler = new System.Windows.Forms.DataGridView();
            this.tbOtobusID = new System.Windows.Forms.TextBox();
            this.tbOtobusAdi = new System.Windows.Forms.TextBox();
            this.tbKoltukAdedi = new System.Windows.Forms.TextBox();
            this.tbKoltukDuzeni = new System.Windows.Forms.TextBox();
            this.tbBagajHacmi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbOtobusBilgileri = new System.Windows.Forms.GroupBox();
            this.btOtobusTemizle = new System.Windows.Forms.Button();
            this.btOtobusGuncelle = new System.Windows.Forms.Button();
            this.btOtobusSil = new System.Windows.Forms.Button();
            this.btOtobusEkle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtobusler)).BeginInit();
            this.gbOtobusBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Otobüs İşlemleri";
            // 
            // dgvOtobusler
            // 
            this.dgvOtobusler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOtobusler.Location = new System.Drawing.Point(36, 79);
            this.dgvOtobusler.Name = "dgvOtobusler";
            this.dgvOtobusler.RowTemplate.Height = 24;
            this.dgvOtobusler.Size = new System.Drawing.Size(711, 199);
            this.dgvOtobusler.TabIndex = 2;
            this.dgvOtobusler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOtobusler_CellContentClick);
            this.dgvOtobusler.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOtobusler_RowHeaderMouseClick);
            // 
            // tbOtobusID
            // 
            this.tbOtobusID.Location = new System.Drawing.Point(138, 55);
            this.tbOtobusID.Name = "tbOtobusID";
            this.tbOtobusID.ReadOnly = true;
            this.tbOtobusID.Size = new System.Drawing.Size(155, 27);
            this.tbOtobusID.TabIndex = 1;
            // 
            // tbOtobusAdi
            // 
            this.tbOtobusAdi.Location = new System.Drawing.Point(138, 95);
            this.tbOtobusAdi.Name = "tbOtobusAdi";
            this.tbOtobusAdi.Size = new System.Drawing.Size(155, 27);
            this.tbOtobusAdi.TabIndex = 2;
            // 
            // tbKoltukAdedi
            // 
            this.tbKoltukAdedi.Location = new System.Drawing.Point(138, 137);
            this.tbKoltukAdedi.Name = "tbKoltukAdedi";
            this.tbKoltukAdedi.Size = new System.Drawing.Size(155, 27);
            this.tbKoltukAdedi.TabIndex = 3;
            this.tbKoltukAdedi.TextChanged += new System.EventHandler(this.tbKoltukAdedi_TextChanged);
            // 
            // tbKoltukDuzeni
            // 
            this.tbKoltukDuzeni.Location = new System.Drawing.Point(510, 55);
            this.tbKoltukDuzeni.Name = "tbKoltukDuzeni";
            this.tbKoltukDuzeni.Size = new System.Drawing.Size(155, 27);
            this.tbKoltukDuzeni.TabIndex = 4;
            // 
            // tbBagajHacmi
            // 
            this.tbBagajHacmi.Location = new System.Drawing.Point(510, 95);
            this.tbBagajHacmi.Name = "tbBagajHacmi";
            this.tbBagajHacmi.Size = new System.Drawing.Size(155, 27);
            this.tbBagajHacmi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Otobüs ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Otobüs Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Koltuk Adedi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(351, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Koltuk Düzeni :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(351, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Bagaj Hacmi (m³) :";
            // 
            // gbOtobusBilgileri
            // 
            this.gbOtobusBilgileri.Controls.Add(this.btOtobusTemizle);
            this.gbOtobusBilgileri.Controls.Add(this.btOtobusGuncelle);
            this.gbOtobusBilgileri.Controls.Add(this.btOtobusSil);
            this.gbOtobusBilgileri.Controls.Add(this.btOtobusEkle);
            this.gbOtobusBilgileri.Controls.Add(this.label2);
            this.gbOtobusBilgileri.Controls.Add(this.label6);
            this.gbOtobusBilgileri.Controls.Add(this.label5);
            this.gbOtobusBilgileri.Controls.Add(this.tbOtobusID);
            this.gbOtobusBilgileri.Controls.Add(this.label4);
            this.gbOtobusBilgileri.Controls.Add(this.tbOtobusAdi);
            this.gbOtobusBilgileri.Controls.Add(this.label3);
            this.gbOtobusBilgileri.Controls.Add(this.tbKoltukAdedi);
            this.gbOtobusBilgileri.Controls.Add(this.tbKoltukDuzeni);
            this.gbOtobusBilgileri.Controls.Add(this.tbBagajHacmi);
            this.gbOtobusBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbOtobusBilgileri.Location = new System.Drawing.Point(36, 301);
            this.gbOtobusBilgileri.Name = "gbOtobusBilgileri";
            this.gbOtobusBilgileri.Size = new System.Drawing.Size(711, 210);
            this.gbOtobusBilgileri.TabIndex = 5;
            this.gbOtobusBilgileri.TabStop = false;
            this.gbOtobusBilgileri.Text = "Otobüs Bilgileri";
            // 
            // btOtobusTemizle
            // 
            this.btOtobusTemizle.Font = new System.Drawing.Font("Candara", 9.5F);
            this.btOtobusTemizle.Location = new System.Drawing.Point(605, 137);
            this.btOtobusTemizle.Name = "btOtobusTemizle";
            this.btOtobusTemizle.Size = new System.Drawing.Size(89, 28);
            this.btOtobusTemizle.TabIndex = 9;
            this.btOtobusTemizle.Text = "Temizle";
            this.btOtobusTemizle.UseVisualStyleBackColor = true;
            this.btOtobusTemizle.Click += new System.EventHandler(this.btOtobusTemizle_Click);
            // 
            // btOtobusGuncelle
            // 
            this.btOtobusGuncelle.Font = new System.Drawing.Font("Candara", 9.5F);
            this.btOtobusGuncelle.Location = new System.Drawing.Point(510, 136);
            this.btOtobusGuncelle.Name = "btOtobusGuncelle";
            this.btOtobusGuncelle.Size = new System.Drawing.Size(89, 28);
            this.btOtobusGuncelle.TabIndex = 8;
            this.btOtobusGuncelle.Text = "Güncelle";
            this.btOtobusGuncelle.UseVisualStyleBackColor = true;
            this.btOtobusGuncelle.Click += new System.EventHandler(this.btOtobusGuncelle_Click);
            // 
            // btOtobusSil
            // 
            this.btOtobusSil.Font = new System.Drawing.Font("Candara", 9.5F);
            this.btOtobusSil.Location = new System.Drawing.Point(415, 136);
            this.btOtobusSil.Name = "btOtobusSil";
            this.btOtobusSil.Size = new System.Drawing.Size(89, 28);
            this.btOtobusSil.TabIndex = 7;
            this.btOtobusSil.Text = "Sil";
            this.btOtobusSil.UseVisualStyleBackColor = true;
            this.btOtobusSil.Click += new System.EventHandler(this.btOtobusSil_Click);
            // 
            // btOtobusEkle
            // 
            this.btOtobusEkle.Font = new System.Drawing.Font("Candara", 9.5F);
            this.btOtobusEkle.Location = new System.Drawing.Point(320, 136);
            this.btOtobusEkle.Name = "btOtobusEkle";
            this.btOtobusEkle.Size = new System.Drawing.Size(89, 28);
            this.btOtobusEkle.TabIndex = 6;
            this.btOtobusEkle.Text = "Ekle";
            this.btOtobusEkle.UseVisualStyleBackColor = true;
            this.btOtobusEkle.Click += new System.EventHandler(this.btOtobusEkle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Otomasyon.Properties.Resources.islem_icon;
            this.pictureBox1.Location = new System.Drawing.Point(36, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 8F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(517, 523);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Hulusi Bindebir * hulusi-bindebir.com";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 549);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbOtobusBilgileri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOtobusler);
            this.Name = "Form3";
            this.Text = "Otobüs İşlemleri";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtobusler)).EndInit();
            this.gbOtobusBilgileri.ResumeLayout(false);
            this.gbOtobusBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOtobusler;
        private System.Windows.Forms.TextBox tbOtobusID;
        private System.Windows.Forms.TextBox tbOtobusAdi;
        private System.Windows.Forms.TextBox tbKoltukAdedi;
        private System.Windows.Forms.TextBox tbKoltukDuzeni;
        private System.Windows.Forms.TextBox tbBagajHacmi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbOtobusBilgileri;
        private System.Windows.Forms.Button btOtobusTemizle;
        private System.Windows.Forms.Button btOtobusGuncelle;
        private System.Windows.Forms.Button btOtobusSil;
        private System.Windows.Forms.Button btOtobusEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}