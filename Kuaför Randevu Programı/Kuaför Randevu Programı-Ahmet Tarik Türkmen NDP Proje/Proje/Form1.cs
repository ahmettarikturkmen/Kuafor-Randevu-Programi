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
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Net.NetworkInformation;

namespace Proje
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        BindingList<Randevu> list = new BindingList<Randevu>();

        private void Form1_Load(object sender, EventArgs e)
        {
            // ComboBox'a berberler dizisini ekler
            string[] berberler = { };

            cmbBerber.Items.AddRange(berberler);

            // Personel verilerini personeller.txt dosyasından alarak hizmetComboBoxa ekler
            string dosyaYolu = "personeller.txt";
            if (File.Exists(dosyaYolu))
            {
                string[] personelSatirlar = File.ReadAllLines(dosyaYolu);
                foreach (string satir in personelSatirlar)
                {
                    string[] parcalar = satir.Split(',');
                    // ad, soyad, telefon ve uzmanlık alanı 4 parça
                    if (parcalar.Length == 4) 
                    {
                        string ad = parcalar[0]; 
                        // Eğer bu uzmanlık alanı daha önce eklenmemişse ekler
                        if (!cmbBerber.Items.Contains(ad)) 
                        {
                            cmbBerber.Items.Add(ad);
                        }
                    }
                }
            }

            // DataGridView'in veri kaynağı olarak BindingList kullanır
            dataGridView1.DataSource = list;
            dataGridView1.Columns["Ucret"].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns["Ucret"].HeaderText = "Ücret";

            // BindingList değişiklikleri
            list.ListChanged += List_ListChanged;

            // randevular.txt dosyasını yükler
            LoadRandevular();
        }

        private void LoadRandevular()
        {
            string dosyaYolu = "randevular.txt";
            if (File.Exists(dosyaYolu))
            {
                string[] randevuSatirlar = File.ReadAllLines(dosyaYolu);
                foreach (string satir in randevuSatirlar)
                {
                    string[] parcalar = satir.Split(',');
                    if (parcalar.Length == 8 || parcalar[4].ToLower() == "true")
                    {
                        string id = parcalar[0];
                        string ad = parcalar[1];
                        string telefon = parcalar[2];
                        DateTime tarih = DateTime.Parse(parcalar[3]);
                        bool ogrenci = bool.Parse(parcalar[4]);
                        string berber = parcalar[5];
                        string hizmet = parcalar[6];
                        decimal ucret = decimal.Parse(parcalar[7]);

                        Randevu randevu = new Randevu(id, ad, telefon, tarih, ogrenci, berber, hizmet, ucret);
                        list.Add(randevu);

                     
                    }
                }
            }

        }

        

        private void SaveRandevular()
        {
            string dosyaYolu = "randevular.txt";
            using (StreamWriter sw = new StreamWriter(dosyaYolu))
            {
                foreach (Randevu randevu in list)
                {
                    sw.WriteLine($"{randevu.Id},{randevu.Ad},{randevu.Telefon},{randevu.Tarih},{randevu.Ogrenci},{randevu.Berber},{randevu.Hizmet},{randevu.Ucret}");
                }
            }
        }

        private void List_ListChanged(object sender, ListChangedEventArgs e)
        {
            SaveRandevular();
        }
            /*
              **Dosya Okuma ve Yazma:**
        - `LoadRandevular` metodu, `randevular.txt` dosyasını okuyarak BindingList'e veri yükler.
        - `SaveRandevular` metodu, BindingList'teki verileri `randevular.txt` dosyasına yazar.

             **BindingList Değişiklikleri İzleme:**
        - `List_ListChanged` olayı, BindingList'teki değişiklikleri izler ve her değişiklikte `SaveRandevular` metodunu çağırarak dosyaya yazar.

             **Ekleme, Silme ve Güncelleme İşlemleri:**
        - `btnEkle_Click`, `btnSil_Click` ve `btnGuncelle_Click` metotları, BindingList'e ekleme, silme ve güncelleme işlemlerini gerçekleştirir.

                Bu kod, DataGridView'de yapılan ekleme, silme ve güncelleme işlemlerini otomatik olarak `randevular.txt` dosyasına yansıtır. 
        Bu şekilde randevu bilgileri her zaman güncel tutulur.*/


        private void btnEkle_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string ad = txtAdSoyad.Text;
            string telefon = txtTelefon.Text;
            bool ogrenci = chkOgrenci.Checked;
            DateTime tarih = dtpDogumTarih.Value;
            string berber = cmbBerber.Text;
            string hizmet = hizmetComboBox.Text;
            decimal ucret = 0;

            // Aynı telefon numarasına sahip bir randevu olup olmadığını kontrol et
            bool telefonMevcut = list.Any(r => r.Telefon == telefon);
            if (telefonMevcut)
            {
                MessageBox.Show("Bu telefon numarasına sahip bir kullanıcı zaten mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Mevcut telefon varsa işlemi durdur
            }

            // Aynı ID'ye sahip bir randevu olup olmadığını kontrol et
            bool idMevcut = list.Any(r => r.Id == id);
            if (idMevcut)
            {
                MessageBox.Show("Bu ID ye sahip bir kullanıcı zaten mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Mevcut id varsa işlemi durdur
            }


            string dosyaYolu = "hizmetler.txt";
            if (File.Exists(dosyaYolu))
            {
                string[] hizmetSatirlar = File.ReadAllLines(dosyaYolu);
                foreach (string satir in hizmetSatirlar)
                {
                    string[] parcalar = satir.Split(',');
                    if (parcalar.Length == 2 && parcalar[0] == hizmet)
                    {
                        ucret = Convert.ToDecimal(parcalar[1]);
                        if (ogrenci)
                        {
                            ucret *= 0.8m; // %20 indirim
                        }
                        break;
                    }
                }
            }

            Randevu yeniRandevu = new Randevu(id, ad, telefon, tarih, ogrenci, berber, hizmet, ucret);
            list.Add(yeniRandevu);

            SaveRandevular();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Randevu secilenRandevu = selectedRow.DataBoundItem as Randevu;

                if (secilenRandevu != null && list.Contains(secilenRandevu))
                {
                    list.Remove(secilenRandevu);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Randevu secilenRandevu = selectedRow.DataBoundItem as Randevu;

                if (secilenRandevu != null)
                {
                    secilenRandevu.Ad = txtAdSoyad.Text;
                    secilenRandevu.Telefon = txtTelefon.Text;
                    secilenRandevu.Ogrenci = chkOgrenci.Checked;
                    secilenRandevu.Tarih = dtpDogumTarih.Value;
                    secilenRandevu.Berber = cmbBerber.Text;
                    secilenRandevu.Hizmet = hizmetComboBox.Text;

                    decimal ucret = 0;
                    string dosyaYolu = "hizmetler.txt";
                    if (File.Exists(dosyaYolu))
                    {
                        string[] hizmetSatirlar = File.ReadAllLines(dosyaYolu);
                        foreach (string satir in hizmetSatirlar)
                        {
                            string[] parcalar = satir.Split(',');
                            if (parcalar.Length == 2 && parcalar[0] == secilenRandevu.Hizmet)
                            {
                                ucret = Convert.ToDecimal(parcalar[1]);
                                if (secilenRandevu.Ogrenci)
                                {
                                    ucret *= 0.8m; // %20 indirim
                                }
                                break;
                            }
                        }
                    }

                    secilenRandevu.Ucret = ucret;
                    dataGridView1.Refresh();
                }
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView hücresine tıklandığında çalışır ve o hücreye ait satırdaki verileri ilgili form kontrollerine doldurur.
            if (e.RowIndex >= 0)
            {
                txtId.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtAdSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells["Ad"].Value.ToString();
                txtTelefon.Text = dataGridView1.Rows[e.RowIndex].Cells["Telefon"].Value.ToString();
                cmbBerber.Text = dataGridView1.Rows[e.RowIndex].Cells["Berber"].Value.ToString();
                hizmetComboBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Hizmet"].Value.ToString();
                dtpDogumTarih.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells["Tarih"].Value;
                chkOgrenci.Checked = (bool)dataGridView1.Rows[e.RowIndex].Cells["Ogrenci"].Value;
            }
        }

       

        private void personelButon_Click_1(object sender, EventArgs e)
        {
            
            this.Hide(); // Form1'i gizler
            Form2 yeniForm = new Form2();
            yeniForm.ShowDialog(); // Yeni formu modal olarak gösterir
            this.Show(); // Form2 kapandıktan sonra Form1'i tekrar gösterir
            
        }

        private void yenileButon_Click(object sender, EventArgs e)
        {
            // TextBox'ların içeriğini temizler
            txtId.Clear();
            txtAdSoyad.Clear();
            txtTelefon.Clear();

            // ComboBox'ları seçili olmaktan çıkarır
            cmbBerber.SelectedIndex = -1;
            hizmetComboBox.SelectedIndex = -1;

            // ComboBox'a berberlerin ekler
            string[] berberler = { };

            cmbBerber.Items.Clear();

            cmbBerber.Items.AddRange(berberler);

            // Personel verilerini personeller.txt dosyasından alarak hizmetComboBox a ekler
            string dosyaYolu = "personeller.txt";
            if (File.Exists(dosyaYolu))
            {
                string[] personelSatirlar = File.ReadAllLines(dosyaYolu);
                foreach (string satir in personelSatirlar)
                {
                    string[] parcalar = satir.Split(',');
                    if (parcalar.Length == 4) //  ad, soyad, telefon ve uzmanlık alanı 4 parça
                    {
                        string ad = parcalar[0]; 
                        if (!cmbBerber.Items.Contains(ad)) // Eğer bu uzmanlık alanı daha önce eklenmemişse ekler
                        {
                            cmbBerber.Items.Add(ad);
                        }
                    }
                }
            }

            // ComboBox'a hizmetlerin eklenmesi
            string[] hizmetler = { };

            hizmetComboBox.Items.Clear();
            hizmetComboBox.Items.AddRange(hizmetler);

            // Personel verilerini personeller.txt dosyasından alarak hizmetComboBox a ekler
            string dosyaYolu2 = "hizmetler.txt";
            if (File.Exists(dosyaYolu2))
            {
                string[] hizmetSatirlar = File.ReadAllLines(dosyaYolu2);
                foreach (string satir in hizmetSatirlar)
                {
                    string[] parcalar = satir.Split(',');
                    if (parcalar.Length == 2) // Ad ve ücret olarak iki parça
                    {
                        string ad = parcalar[0];
                        string ucret = parcalar[1];
                        string hizmetBilgisi = $"{ad}";
                        if (!hizmetComboBox.Items.Contains(hizmetBilgisi)) // Eğer bu hizmet daha önce eklenmemişse ekler
                        {
                            hizmetComboBox.Items.Add(hizmetBilgisi);
                        }
                    }
                }
            }

            // DataGridView'in veri kaynağı olarak BindingList kullanılması
            dataGridView1.DataSource = list;

        }

        private void hizmetIslemleriButon_Click(object sender, EventArgs e)
        {
            this.Hide(); // Form1'i gizler
            Form3 yeniForm = new Form3();
            yeniForm.ShowDialog(); // Yeni formu modal olarak gösterir
            this.Show(); // Form2 kapandıktan sonra Form1'i tekrar gösterir

        }

        
    }
}
