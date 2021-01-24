using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            int fiyati = 14;
            string aciklama = "amasya elması";

            String[] meyveler = new string[] { };

            Product product1 = new Product();
            product1.Adi = "Çilek";
            product1.Aciklama = "dağ çileği";
            product1.Fiyati = 15;

            Product product2 = new Product();
            product2.Adi = "Elma";
            product2.Aciklama = "amasya elması";
            product2.Fiyati = 20;

            Product[] products = new Product[] {product1,product2 };

            foreach (var product in products) 
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine("---------------------");
            };

         
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 13,12);
            sepetManager.Ekle2("Üzüm", "Yeşil armut", 13,9);
            sepetManager.Ekle2("KArpuz", "Yeşil armut", 13,8);

        }
    }
}
