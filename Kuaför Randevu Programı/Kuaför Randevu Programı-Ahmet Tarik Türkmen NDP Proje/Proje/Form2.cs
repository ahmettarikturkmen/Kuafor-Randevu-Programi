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

namespace Proje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form2_Load); //Load olayına Form2_Load adlı bir olay işleyicisi ekler.Form yüklendiğinde Form2_Load metodu çalıştırılacaktır.
        }



        private void geriButon_Click_1(object sender, EventArgs e)
        {
            this.Close(); // Form2'yi kapatır
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde list box'ı günceller
            RefreshListBox();


        }

        public class DosyaIslemleri
        {
            private string dosyaYolu = "personeller.txt";
            //dosyaya yazma
            public void PersonelEkle(Personel personel)
            {
                using (StreamWriter writer = new StreamWriter(dosyaYolu, true))
                {
                    writer.WriteLine($"{personel.Ad},{personel.Soyad},{personel.Telefon},{personel.UzmanlikAlani}");
                }
            }
            //dosya okuma
            public List<Personel> TumPersonelleriGetir()
            {
                List<Personel> personeller = new List<Personel>();

                if (File.Exists(dosyaYolu))
                {
                    string[] satirlar = File.ReadAllLines(dosyaYolu);
                    foreach (string satir in satirlar)
                    {
                        string[] parcalar = satir.Split(',');
                        if (parcalar.Length == 4)
                        {
                            Personel personel = new Personel(parcalar[0], parcalar[1], parcalar[2], parcalar[3]);
                            personeller.Add(personel);
                        }
                    }
                }

                return personeller;
            }
            //berber silme
            public void PersonelSil(Personel personel)
            {
                List<string> satirlar = File.ReadAllLines(dosyaYolu).ToList();
                satirlar.RemoveAll(x => x.StartsWith($"{personel.Ad},{personel.Soyad},{personel.Telefon},{personel.UzmanlikAlani}"));
                File.WriteAllLines(dosyaYolu, satirlar.ToArray());
            }

            //berber güncelleme
            public void PersonelGuncelle(Personel guncellenecekPersonel)
            {
                List<string> satirlar = File.ReadAllLines(dosyaYolu).ToList();

                for (int i = 0; i < satirlar.Count; i++)
                {
                    string[] parcalar = satirlar[i].Split(',');
                    if (parcalar.Length == 4 && parcalar[0] == guncellenecekPersonel.Ad && parcalar[1] == guncellenecekPersonel.Soyad)
                    {
                        satirlar[i] = $"{guncellenecekPersonel.Ad},{guncellenecekPersonel.Soyad},{guncellenecekPersonel.Telefon},{guncellenecekPersonel.UzmanlikAlani}";
                        break;
                    }
                }

                File.WriteAllLines(dosyaYolu, satirlar.ToArray());
            }

        }

        

        private void RefreshListBox()
        {
            // ListBox'ı günceller
            listBoxPersonel.Items.Clear();
            DosyaIslemleri dosyaIslemleri = new DosyaIslemleri();
            List<Personel> personeller = dosyaIslemleri.TumPersonelleriGetir();
            foreach (Personel personel in personeller)
            {
                listBoxPersonel.Items.Add(personel);
            }
        }

        private void personelEkle_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği bilgileri alır
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string telefon = txtTelefon.Text;
            string uzmanlikAlani = txtUzmanlikAlani.Text;

            // Bu bilgilerle yeni bir Personel nesnesi oluşturur
            Personel yeniPersonel = new Personel(ad, soyad, telefon, uzmanlikAlani);

            // DosyaIslemleri sınıfını kullanarak personeli metin dosyasına ekler
            DosyaIslemleri dosyaIslemleri = new DosyaIslemleri();
            dosyaIslemleri.PersonelEkle(yeniPersonel);

            // İşlem tamamlandığında list box'u günceller
            RefreshListBox();

            // İşlem tamamlandığında kullanıcıya bilgi verir
            MessageBox.Show("Personel başarıyla eklendi.");
        }

        private void personelSil_Click(object sender, EventArgs e)
        {
            // Seçilen personeli alır
            if (listBoxPersonel.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silmek istediğiniz personeli seçin.");
                return;
            }

            Personel secilenPersonel = listBoxPersonel.SelectedItem as Personel;

            // DosyaIslemleri sınıfını kullanarak personeli siler
            DosyaIslemleri dosyaIslemleri = new DosyaIslemleri();
            dosyaIslemleri.PersonelSil(secilenPersonel);

            // İşlem tamamlandığında list box'u günceller
            RefreshListBox();

            // İşlem tamamlandığında kullanıcıya bilgi verir
            MessageBox.Show("Personel başarıyla silindi.");
        }

        private void listBoxPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ListBox'tan seçilen personeli alır
            Personel secilenPersonel = (Personel)listBoxPersonel.SelectedItem;

            if (secilenPersonel != null)
            {
                // Seçilen personelin bilgilerini TextBox'lara yükler
                txtAd.Text = secilenPersonel.Ad;
                txtSoyad.Text = secilenPersonel.Soyad;
                txtTelefon.Text = secilenPersonel.Telefon;
                txtUzmanlikAlani.Text = secilenPersonel.UzmanlikAlani;
            }

        }

        private void personelGuncelleButon_Click(object sender, EventArgs e)
        {
            // Seçilen personelin adını, soyadını, telefonunu ve uzmanlık alanını alır
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string telefon = txtTelefon.Text;
            string uzmanlikAlani = txtUzmanlikAlani.Text;

            // ListBox'tan seçilen personeli alır
            Personel secilenPersonel = (Personel)listBoxPersonel.SelectedItem;

            if (secilenPersonel != null)
            {
                // Yeni Personel nesnesini oluşturur
                Personel yeniPersonel = new Personel(ad, soyad, telefon, uzmanlikAlani);

                // ListBox'tan ve personeller.txt dosyasından seçilen personeli siler
                listBoxPersonel.Items.Remove(secilenPersonel);
                DosyaIslemleri dosyaIslemleri = new DosyaIslemleri();
                dosyaIslemleri.PersonelSil(secilenPersonel);

                // Yeni Personel nesnesini personeller.txt dosyasına ekler
                dosyaIslemleri.PersonelEkle(yeniPersonel);

                // ListBox'ı ve personeller.txt dosyasını günceller
                RefreshListBox();

                // Kullanıcıya bilgi verir
                MessageBox.Show("Personel başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}
