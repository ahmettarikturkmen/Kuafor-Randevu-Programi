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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public class Randevu
    {
        public string Id { get; set; }
        public string Ad { get; set; }
        public string Telefon { get; set; }
        public DateTime Tarih { get; set; }
        public bool Ogrenci { get; set; }
        public string Berber { get; set; }
        public string Hizmet { get; set; }
        public decimal Ucret { get; set; }


        public Randevu(string id, string ad, string telefon, DateTime tarih, bool ogrenci, string berber, string hizmet, decimal ucret)
        {
            Id = id;
            Ad = ad;
            Telefon = telefon;
            Tarih = tarih;
            Ogrenci = ogrenci;
            Berber = berber;
            Hizmet = hizmet;
            Hizmet = hizmet;
            Ucret = ucret;
        }
    }
}
