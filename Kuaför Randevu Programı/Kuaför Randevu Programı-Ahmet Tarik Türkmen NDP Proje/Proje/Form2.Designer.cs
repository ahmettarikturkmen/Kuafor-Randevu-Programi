namespace Proje
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.geriButon = new System.Windows.Forms.Button();
            this.personelEkle = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtUzmanlikAlani = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxPersonel = new System.Windows.Forms.ListBox();
            this.personelSil = new System.Windows.Forms.Button();
            this.personelGuncelleButon = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // geriButon
            // 
            this.geriButon.Image = global::Proje.Properties.Resources.projeUndo;
            this.geriButon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.geriButon.Location = new System.Drawing.Point(12, 12);
            this.geriButon.Name = "geriButon";
            this.geriButon.Size = new System.Drawing.Size(110, 71);
            this.geriButon.TabIndex = 0;
            this.geriButon.Text = "GERİ";
            this.geriButon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.geriButon.UseVisualStyleBackColor = true;
            this.geriButon.Click += new System.EventHandler(this.geriButon_Click_1);
            // 
            // personelEkle
            // 
            this.personelEkle.Image = global::Proje.Properties.Resources.projeAdd_User_Male;
            this.personelEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.personelEkle.Location = new System.Drawing.Point(32, 256);
            this.personelEkle.Name = "personelEkle";
            this.personelEkle.Size = new System.Drawing.Size(129, 65);
            this.personelEkle.TabIndex = 3;
            this.personelEkle.Text = "Berber Ekle";
            this.personelEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.personelEkle.UseVisualStyleBackColor = true;
            this.personelEkle.Click += new System.EventHandler(this.personelEkle_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(201, 110);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(141, 22);
            this.txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(201, 138);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(141, 22);
            this.txtSoyad.TabIndex = 5;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(201, 166);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(141, 22);
            this.txtTelefon.TabIndex = 6;
            // 
            // txtUzmanlikAlani
            // 
            this.txtUzmanlikAlani.Location = new System.Drawing.Point(201, 194);
            this.txtUzmanlikAlani.Name = "txtUzmanlikAlani";
            this.txtUzmanlikAlani.Size = new System.Drawing.Size(141, 22);
            this.txtUzmanlikAlani.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Berber Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Berber Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Berber Telefonu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Berber  Uzmanlık Alanı";
            // 
            // listBoxPersonel
            // 
            this.listBoxPersonel.FormattingEnabled = true;
            this.listBoxPersonel.ItemHeight = 16;
            this.listBoxPersonel.Location = new System.Drawing.Point(467, 113);
            this.listBoxPersonel.Name = "listBoxPersonel";
            this.listBoxPersonel.Size = new System.Drawing.Size(379, 308);
            this.listBoxPersonel.TabIndex = 12;
            // 
            // personelSil
            // 
            this.personelSil.Image = global::Proje.Properties.Resources.projeDenied;
            this.personelSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.personelSil.Location = new System.Drawing.Point(167, 256);
            this.personelSil.Name = "personelSil";
            this.personelSil.Size = new System.Drawing.Size(132, 65);
            this.personelSil.TabIndex = 13;
            this.personelSil.Text = "Berber Sil";
            this.personelSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.personelSil.UseVisualStyleBackColor = true;
            this.personelSil.Click += new System.EventHandler(this.personelSil_Click);
            // 
            // personelGuncelleButon
            // 
            this.personelGuncelleButon.Image = global::Proje.Properties.Resources.projeRegistration;
            this.personelGuncelleButon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.personelGuncelleButon.Location = new System.Drawing.Point(305, 256);
            this.personelGuncelleButon.Name = "personelGuncelleButon";
            this.personelGuncelleButon.Size = new System.Drawing.Size(132, 65);
            this.personelGuncelleButon.TabIndex = 14;
            this.personelGuncelleButon.Text = "Berber Güncelle";
            this.personelGuncelleButon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.personelGuncelleButon.UseVisualStyleBackColor = true;
            this.personelGuncelleButon.Click += new System.EventHandler(this.personelGuncelleButon_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ad Soyad     -    Telefon    -     Uzmanlık Alanı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "BERBER LİSTESİ";
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 464);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.personelGuncelleButon);
            this.Controls.Add(this.personelSil);
            this.Controls.Add(this.listBoxPersonel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUzmanlikAlani);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.personelEkle);
            this.Controls.Add(this.geriButon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel İşlemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geriButon;
        private System.Windows.Forms.Button personelEkle;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtUzmanlikAlani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxPersonel;
        private System.Windows.Forms.Button personelSil;
        private System.Windows.Forms.Button personelGuncelleButon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList ımageList1;
    }
}