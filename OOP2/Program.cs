using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Adi = "Ayca";
            musteri1.Id = 1233;

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 3456;
            musteri2.SirketAdi = "MCO";

            Musteri musteri3 = new Musteri();
            Musteri musteri4 = new Musteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);

        }
    }
}
