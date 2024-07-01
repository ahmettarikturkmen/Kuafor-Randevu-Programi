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
    public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }

        public Kisi(string ad, string soyad, string telefon)
        {
            Ad = ad;
            Soyad = soyad;
            Telefon = telefon;
        }
    }
}
