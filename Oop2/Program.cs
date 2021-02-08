using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kenan Atasoy
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Kenan";
            musteri1.Soyadi = "Atasoy";
            musteri1.TcNo = "345355334324";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "5656564";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "45545435";

            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}
