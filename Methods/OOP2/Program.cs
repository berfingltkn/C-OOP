using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //berfin gultekin icin 
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Adi = "Berfin";
            musteri1.Soyadi = "Gultekin";
            musteri1.ID =1;
            musteri1.TcNo = "12345678910";
            musteri1.MusteriNo = "12365478910";

            //kodlama.io icin
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.ID = 2;
            musteri2.MusteriNo = "22365478910";
            musteri2.VergiNo = "0123456789";
            musteri2.SirketAdi = "Kodlama.io";

            //Gercek Musteri - Tuzel Musteri
            //SOLID

            //Aşağıdaki kısım önemli : Musteri class ı hem GercekMusteri nin classını tutabiliyor,
            //hemde  TuzelMusterinin referansını tutabilir. Çünkü bu classla rMusteriden kalıtılmıştır.


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();



            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

        }
    }
}
