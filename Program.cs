using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri must1 = new Musteri();
            must1.Adi = "Semih";
            must1.Soyadi = "Şahin";
            must1.Mail = "semihsahin@hotmail.com";
            must1.Aciklama = "Doktor";

            Musteri must2 = new Musteri();
            must2.Adi = "Gözde";
            must2.Soyadi = "Şair";
            must2.Mail = "sairgozde@gmail.com";
            must2.Aciklama = "Öğretmen";

            Musteri must3 = new Musteri();
            must3.Adi = "Veli";
            must3.Soyadi = "Demir";
            must3.Mail = "veli_demir@hotmail.com";
            must3.Aciklama = "Serbest Meslek";

            Musteri must4 = new Musteri();
            must4.Adi = "Nur";
            must4.Soyadi = "İnci";
            must4.Mail = "incinur@gmail.com";
            must4.Aciklama = "Arkeolog";

            //Musteri[] musteriler = new Musteri[] {must1, must2, must3, must4,};

            //foreach (var MusteriAlias in musteriler)
            //{
            //    Console.WriteLine(MusteriAlias.Adi);
            //    Console.WriteLine(MusteriAlias.Soyadi);
            //}

            MusteriManager musterimanager = new MusteriManager();

            musterimanager.Ekle(must1);
            Console.WriteLine("------------------------------------------------------------");
            musterimanager.Sil(must3);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Müşteri Listesi");
            Console.WriteLine("***************");
           musterimanager.Listeleme(must1);
            musterimanager.Listeleme(must2);
            musterimanager.Listeleme(must3);
            musterimanager.Listeleme(must4);
        }
    }
}
