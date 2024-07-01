namespace Proje
{
    partial class form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.cmbBerber = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDogumTarih = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.chkOgrenci = new System.Windows.Forms.CheckBox();
            this.personelButon = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.hizmetComboBox = new System.Windows.Forms.ComboBox();
            this.yenileButon = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.hizmetIslemleriButon = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBerber
            // 
            this.cmbBerber.FormattingEnabled = true;
            this.cmbBerber.Location = new System.Drawing.Point(185, 187);
            this.cmbBerber.Name = "cmbBerber";
            this.cmbBerber.Size = new System.Drawing.Size(225, 24);
            this.cmbBerber.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(185, 103);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(225, 22);
            this.txtId.TabIndex = 1;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(185, 131);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(225, 22);
            this.txtAdSoyad.TabIndex = 2;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(185, 159);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(225, 22);
            this.txtTelefon.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Müşteri ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Müşteri Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Müşteri Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Berber";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(690, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tarih";
            // 
            // dtpDogumTarih
            // 
            this.dtpDogumTarih.Location = new System.Drawing.Point(757, 148);
            this.dtpDogumTarih.Name = "dtpDogumTarih";
            this.dtpDogumTarih.Size = new System.Drawing.Size(200, 22);
            this.dtpDogumTarih.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1092, 216);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // btnEkle
            // 
            this.btnEkle.Image = global::Proje.Properties.Resources.projeAdd_properties;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEkle.Location = new System.Drawing.Point(622, 199);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(145, 66);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Randevu Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Image = global::Proje.Properties.Resources.projeDelete_Document;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.Location = new System.Drawing.Point(773, 199);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(145, 66);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Randevu Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Image = global::Proje.Properties.Resources.projeEdit_Property;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuncelle.Location = new System.Drawing.Point(924, 199);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(145, 66);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "Randevu Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // chkOgrenci
            // 
            this.chkOgrenci.AutoSize = true;
            this.chkOgrenci.Location = new System.Drawing.Point(185, 259);
            this.chkOgrenci.Name = "chkOgrenci";
            this.chkOgrenci.Size = new System.Drawing.Size(170, 20);
            this.chkOgrenci.TabIndex = 14;
            this.chkOgrenci.Text = "Öğrenci %20 İNDİRİM !!!";
            this.chkOgrenci.UseVisualStyleBackColor = true;
            // 
            // personelButon
            // 
            this.personelButon.Image = global::Proje.Properties.Resources.proje40Person_Male_Skin_Type_4;
            this.personelButon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.personelButon.Location = new System.Drawing.Point(673, 36);
            this.personelButon.Name = "personelButon";
            this.personelButon.Size = new System.Drawing.Size(138, 75);
            this.personelButon.TabIndex = 15;
            this.personelButon.Text = "Personel İşlemleri";
            this.personelButon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.personelButon.UseVisualStyleBackColor = true;
            this.personelButon.Click += new System.EventHandler(this.personelButon_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Hizmet";
            // 
            // hizmetComboBox
            // 
            this.hizmetComboBox.FormattingEnabled = true;
            this.hizmetComboBox.Location = new System.Drawing.Point(185, 217);
            this.hizmetComboBox.Name = "hizmetComboBox";
            this.hizmetComboBox.Size = new System.Drawing.Size(225, 24);
            this.hizmetComboBox.TabIndex = 16;
            // 
            // yenileButon
            // 
            this.yenileButon.Image = global::Proje.Properties.Resources.projeRestart;
            this.yenileButon.Location = new System.Drawing.Point(356, 50);
            this.yenileButon.Name = "yenileButon";
            this.yenileButon.Size = new System.Drawing.Size(54, 47);
            this.yenileButon.TabIndex = 18;
            this.yenileButon.UseVisualStyleBackColor = true;
            this.yenileButon.Click += new System.EventHandler(this.yenileButon_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "MÜŞTERİ RANDEVU OLUŞTUR";
            // 
            // hizmetIslemleriButon
            // 
            this.hizmetIslemleriButon.Image = global::Proje.Properties.Resources.projeBarber_Chair;
            this.hizmetIslemleriButon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hizmetIslemleriButon.Location = new System.Drawing.Point(886, 36);
            this.hizmetIslemleriButon.Name = "hizmetIslemleriButon";
            this.hizmetIslemleriButon.Size = new System.Drawing.Size(140, 75);
            this.hizmetIslemleriButon.TabIndex = 20;
            this.hizmetIslemleriButon.Text = "Hizmet İşlemleri";
            this.hizmetIslemleriButon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hizmetIslemleriButon.UseVisualStyleBackColor = true;
            this.hizmetIslemleriButon.Click += new System.EventHandler(this.hizmetIslemleriButon_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "YENİLE";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1112, 536);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.hizmetIslemleriButon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.yenileButon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hizmetComboBox);
            this.Controls.Add(this.personelButon);
            this.Controls.Add(this.chkOgrenci);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpDogumTarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cmbBerber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kuaför Randevu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBerber;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDogumTarih;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.CheckBox chkOgrenci;
        private System.Windows.Forms.Button personelButon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox hizmetComboBox;
        private System.Windows.Forms.Button yenileButon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button hizmetIslemleriButon;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label8;
    }
}

