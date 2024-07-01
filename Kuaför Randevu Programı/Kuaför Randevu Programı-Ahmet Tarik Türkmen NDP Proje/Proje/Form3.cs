/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Proje
**				ÖĞRENCİ ADI............: Ahmet Tarık Türkmen
**				ÖĞRENCİ NUMARASI.......: G221210087
**              DERSİN ALINDIĞI GRUP...: 2.Öğretim C Grubu
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proje.Form2;

namespace Proje
{
    public partial class Form3 : Form
    {
        

        public Form3()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form3_Load); // Form Load olayını bağlar
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            // ListBox'ı günceller
            hizmetlerListBox.Items.Clear();
            DosyaIslemleri dosyaIslemleri = new DosyaIslemleri();
            List<Hizmet> hizmetler = dosyaIslemleri.TumHizmetleriGetir();
            foreach (Hizmet hizmet in hizmetler)
            {
                hizmetlerListBox.Items.Add(hizmet);
            }
        }

        private void geriButon_Click(object sender, EventArgs e)
        {
            this.Close(); // Form3'ü kapatır
        }


        
        
        public class DosyaIslemleri
        {
            private string dosyaYolu = "hizmetler.txt";

            public void HizmetEkle(Hizmet hizmet)
            {
                using (StreamWriter writer = new StreamWriter(dosyaYolu, true))
                {
                    writer.WriteLine($"{hizmet.Ad},{hizmet.Ucret}");
                }
            }

            public List<Hizmet> TumHizmetleriGetir()
            {
                List<Hizmet> hizmetler = new List<Hizmet>();

                if (File.Exists(dosyaYolu))
                {
                    string[] satirlar = File.ReadAllLines(dosyaYolu);
                    foreach (string satir in satirlar)
                    {
                        string[] parcalar = satir.Split(',');
                        if (parcalar.Length == 2)
                        {
                            Hizmet hizmet = new Hizmet(parcalar[0], parcalar[1]);
                            hizmetler.Add(hizmet);
                        }
                    }
                }

                return hizmetler;
            }

            public void HizmetSil(Hizmet hizmet)
            {
                List<string> satirlar = File.ReadAllLines(dosyaYolu).ToList();
                satirlar.RemoveAll(x => x.StartsWith($"{hizmet.Ad},{hizmet.Ucret}"));
                File.WriteAllLines(dosyaYolu, satirlar.ToArray());
            }

        }

        private void hizmetEkle_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği bilgileri alır
            string ad = hizmetAdi.Text;
            string ucret = hizmetUcreti.Text;

            // Bu bilgilerle yeni bir Hizmet nesnesi oluşturur
            Hizmet yeniHizmet = new Hizmet(ad, ucret);

            // DosyaIslemleri sınıfını kullanarak hizmeti metin dosyasına ekler
            DosyaIslemleri dosyaIslemleri = new DosyaIslemleri();
            dosyaIslemleri.HizmetEkle(yeniHizmet);

            // İşlem tamamlandığında list box'u günceller
            RefreshListBox();

            // İşlem tamamlandığında kullanıcıya bilgi verir
            MessageBox.Show("Hizmet başarıyla eklendi.");

            // Textbox'ları temizler
            hizmetAdi.Text = "";
            hizmetUcreti.Text = "";
        }

        private void hizmetSil_Click(object sender, EventArgs e)
        {
            // Seçilen hizmeti alır
            if (hizmetlerListBox.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silmek istediğiniz hizmeti seçin.");
                return;
            }

            Hizmet secilenHizmet = hizmetlerListBox.SelectedItem as Hizmet;

            // DosyaIslemleri sınıfını kullanarak hizmeti siler
            DosyaIslemleri dosyaIslemleri = new DosyaIslemleri();
            dosyaIslemleri.HizmetSil(secilenHizmet);

            // İşlem tamamlandığında list box'u günceller
            RefreshListBox();

            // İşlem tamamlandığında kullanıcıya bilgi verir
            MessageBox.Show("Hizmet başarıyla silindi.");
        }

        private void hizmetGuncelle_Click(object sender, EventArgs e)
        {
            // Seçilen hizmetin adını ve ücretini alır
            string ad = hizmetAdi.Text;
            string ucret = hizmetUcreti.Text;

            // ListBox'tan seçilen hizmeti alır
            Hizmet secilenHizmet = (Hizmet)hizmetlerListBox.SelectedItem;

            if (secilenHizmet != null)
            {
                // Yeni Hizmet nesnesini oluşturur
                Hizmet yeniHizmet = new Hizmet(ad, ucret);

                // ListBox'tan ve hizmetler.txt dosyasından seçilen hizmeti siler
                hizmetlerListBox.Items.Remove(secilenHizmet);
                DosyaIslemleri dosyaIslemleri = new DosyaIslemleri();
                dosyaIslemleri.HizmetSil(secilenHizmet);

                // Yeni Hizmet nesnesini hizmetler.txt dosyasına ekler
                dosyaIslemleri.HizmetEkle(yeniHizmet);

                // ListBox'ı ve hizmetler.txt dosyasını günceller
                RefreshListBox();

                // Kullanıcıya bilgi verir
                MessageBox.Show("Hizmet başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listBoxHizmetler_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ListBox'tan seçilen hizmeti alır
            Hizmet secilenHizmet = (Hizmet)hizmetlerListBox.SelectedItem;

            if (secilenHizmet != null)
            {
                // Seçilen hizmetin bilgilerini TextBox'lara yükler
                hizmetAdi.Text = secilenHizmet.Ad;
                hizmetUcreti.Text = secilenHizmet.Ucret;
            }
        }



    }
}
