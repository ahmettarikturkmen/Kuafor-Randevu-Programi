namespace Proje
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.geriButon = new System.Windows.Forms.Button();
            this.hizmetAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hizmetUcreti = new System.Windows.Forms.TextBox();
            this.hizmetlerListBox = new System.Windows.Forms.ListBox();
            this.hizmetGuncelle = new System.Windows.Forms.Button();
            this.hizmetSil = new System.Windows.Forms.Button();
            this.hizmetEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // geriButon
            // 
            this.geriButon.Image = global::Proje.Properties.Resources.projeUndo;
            this.geriButon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.geriButon.Location = new System.Drawing.Point(12, 12);
            this.geriButon.Name = "geriButon";
            this.geriButon.Size = new System.Drawing.Size(110, 70);
            this.geriButon.TabIndex = 1;
            this.geriButon.Text = "Geri";
            this.geriButon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.geriButon.UseVisualStyleBackColor = true;
            this.geriButon.Click += new System.EventHandler(this.geriButon_Click);
            // 
            // hizmetAdi
            // 
            this.hizmetAdi.Location = new System.Drawing.Point(122, 147);
            this.hizmetAdi.Name = "hizmetAdi";
            this.hizmetAdi.Size = new System.Drawing.Size(182, 22);
            this.hizmetAdi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hizmet Adi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hizmet Ücreti:";
            // 
            // hizmetUcreti
            // 
            this.hizmetUcreti.Location = new System.Drawing.Point(122, 188);
            this.hizmetUcreti.Name = "hizmetUcreti";
            this.hizmetUcreti.Size = new System.Drawing.Size(182, 22);
            this.hizmetUcreti.TabIndex = 4;
            // 
            // hizmetlerListBox
            // 
            this.hizmetlerListBox.FormattingEnabled = true;
            this.hizmetlerListBox.ItemHeight = 16;
            this.hizmetlerListBox.Location = new System.Drawing.Point(432, 131);
            this.hizmetlerListBox.Name = "hizmetlerListBox";
            this.hizmetlerListBox.Size = new System.Drawing.Size(294, 244);
            this.hizmetlerListBox.TabIndex = 6;
            // 
            // hizmetGuncelle
            // 
            this.hizmetGuncelle.Image = global::Proje.Properties.Resources.projeSynchronize;
            this.hizmetGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hizmetGuncelle.Location = new System.Drawing.Point(295, 254);
            this.hizmetGuncelle.Name = "hizmetGuncelle";
            this.hizmetGuncelle.Size = new System.Drawing.Size(131, 61);
            this.hizmetGuncelle.TabIndex = 17;
            this.hizmetGuncelle.Text = "Hizmet Güncelle";
            this.hizmetGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hizmetGuncelle.UseVisualStyleBackColor = true;
            this.hizmetGuncelle.Click += new System.EventHandler(this.hizmetGuncelle_Click);
            // 
            // hizmetSil
            // 
            this.hizmetSil.Image = global::Proje.Properties.Resources.projeCancel;
            this.hizmetSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hizmetSil.Location = new System.Drawing.Point(158, 254);
            this.hizmetSil.Name = "hizmetSil";
            this.hizmetSil.Size = new System.Drawing.Size(131, 61);
            this.hizmetSil.TabIndex = 16;
            this.hizmetSil.Text = "Hizmet Sil";
            this.hizmetSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hizmetSil.UseVisualStyleBackColor = true;
            this.hizmetSil.Click += new System.EventHandler(this.hizmetSil_Click);
            // 
            // hizmetEkle
            // 
            this.hizmetEkle.Image = global::Proje.Properties.Resources.projeAdd;
            this.hizmetEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hizmetEkle.Location = new System.Drawing.Point(21, 254);
            this.hizmetEkle.Name = "hizmetEkle";
            this.hizmetEkle.Size = new System.Drawing.Size(131, 61);
            this.hizmetEkle.TabIndex = 15;
            this.hizmetEkle.Text = "Hizmet Ekle";
            this.hizmetEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hizmetEkle.UseVisualStyleBackColor = true;
            this.hizmetEkle.Click += new System.EventHandler(this.hizmetEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hizmet   -   Ücret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "HİZMET LİSTESİ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hizmetGuncelle);
            this.Controls.Add(this.hizmetSil);
            this.Controls.Add(this.hizmetEkle);
            this.Controls.Add(this.hizmetlerListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hizmetUcreti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hizmetAdi);
            this.Controls.Add(this.geriButon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hizmet İşlemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geriButon;
        private System.Windows.Forms.TextBox hizmetAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hizmetUcreti;
        private System.Windows.Forms.ListBox hizmetlerListBox;
        private System.Windows.Forms.Button hizmetGuncelle;
        private System.Windows.Forms.Button hizmetSil;
        private System.Windows.Forms.Button hizmetEkle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}