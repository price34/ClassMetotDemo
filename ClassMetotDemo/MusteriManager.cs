using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(string musteriAdi, string musteriSoyadi, int hesapNo)
        {
            Console.WriteLine(musteriAdi + " " + musteriSoyadi + " adlı şahıs; " + hesapNo + " hesap numarası ile yeni müşteri olarak eklendi!");
        }

        public void Sil(Musteri m)
        {
            Console.WriteLine(m.hesapNo + " hesap numaralı, " + m.musteriAdi + " " + m.musteriSoyadi + " adlı müşteri silindi!");
        }

        public void Listele(Musteri m)
        {
            Console.WriteLine("Listelenen müşteri Bilgisi aşağıdaki gibidir!" + "\nAd - Soyad: " + m.musteriAdi + " " + m.musteriSoyadi + "\nHesap No: " + m.hesapNo + "\nBakiye: " + m.musteriBakiye + "TL");
        }
    }
}
