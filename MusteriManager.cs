using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) {
            Console.WriteLine("Müşteri başarıyla eklendi:" + " " + musteri.Adi + " " + "/" + " " + musteri.Mail);
        }
        public void Sil(Musteri musteri) {
            Console.WriteLine("Müşteri başarıyla silindi:" + " " + musteri.Adi + "/" + musteri.Mail);
        }
        
        public void Listeleme(Musteri musteri) {           
           
            Console.WriteLine(musteri.Adi + "--" + musteri.Soyadi + "--" + musteri.Mail + "--" + musteri.Aciklama);
           
        }
    
    }
}
