using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] {"Elma","Karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2= new Urun();
            urun2.Adi = "Cilek";
            urun2.Fiyati = 20;
            urun2.Aciklama = "Köy çileği";

            Urun urun3 = new Urun()
            {
                Adi= "Karpuz",
                Fiyati = 10,
                Aciklama = "Adana Karpuzu"
            };

            Urun[] urunler = new Urun[] {urun1,urun2,urun3};

            //type-safe -- tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürün Adı : " + urun.Adi + "  " + " Fiyatı :"+urun.Fiyati );
            }

            Console.WriteLine("\n-----------------");
            foreach (var urun in urunler)
            {
                Console.WriteLine("Ürün Adı : " + urun.Adi + "  " + " Fiyatı :" + urun.Fiyati);
            }

            Console.WriteLine("\n");

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");
            }
            Console.WriteLine("\n Hello, World! \n");
            Console.WriteLine("---------Metotlar----------");
            Console.WriteLine("\n");
            
            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            Console.WriteLine("-----------------");
            sepetManager.EkleAlternatif("Armut","Ayıların Sevdiği Armut",11, 10);
            sepetManager.EkleAlternatif("Elma", "Yeşil Elma", 9, 8);
            sepetManager.EkleAlternatif("Şeftali", "Tüysüz Şeftali", 15, 11);

        }
    }
}
//Dont repeat yourself - DRY - Clean Code - Best Practice