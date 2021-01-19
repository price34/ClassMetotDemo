using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.hesapNo = 458796;
            musteri1.musteriAdi = "Enes";
            musteri1.musteriSoyadi = "Öztürk";
            musteri1.musteriBakiye = 17800;

            Musteri musteri2 = new Musteri();
            musteri2.hesapNo = 257963;
            musteri2.musteriAdi = "Salih";
            musteri2.musteriSoyadi = "Sağ";
            musteri2.musteriBakiye = 2100;

            Musteri musteri3 = new Musteri();
            musteri3.hesapNo = 367408;
            musteri3.musteriAdi = "Fatih";
            musteri3.musteriSoyadi = "Kaşık";
            musteri3.musteriBakiye = 320950;


            Musteri[] musteriler = new Musteri[]
            {
                musteri1,
                musteri2,
                musteri3,
            };


            //Müşteri Listeleme
            MusteriManager managerList = new MusteriManager();
            managerList.Listele(musteri1);

            Console.WriteLine("---------------------");
            
            //Müşteri Ekleme
            MusteriManager managerAdd = new MusteriManager();
            managerAdd.Ekle("Emre", "IŞIK", 548933);

            Console.WriteLine("---------------------");

            //Müşteri Silme
            MusteriManager managerDelete = new MusteriManager();
            managerDelete.Sil(musteri3);
        }
    }
}
