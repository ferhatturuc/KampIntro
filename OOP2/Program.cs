using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Ferhat";
            //musteri1.Soyadi = "Turuç";
            //musteri1.Id= 1;
            //musteri1.TcNo = "33333333";
            //musteri1.SirketAdi = "?";

            //Gerçek Müşteri - Tüzel Müşteri  birbirine benziyor diye birbirinin yerine kullanılamaz.
            //SOLID Liskov prensibi
            
            //Gerçek Müşteri
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "4862348";
            musteri1.Adi = "Ferhat";
            musteri1.Soyadi = "Turuç";
            musteri1.TcNo = "1234567890";

            //Tüzel Müşteri
            TuzelMusteri musteri2 = new TuzelMusteri
            {
                Id = 2,
                MusteriNo = "123456",
                VergiNo = "12345",
                SirketAdi = "Jandarma"
            };

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            musteri3.MusteriNo = "13465";
            musteri3.Id = 3;

            musteri4.MusteriNo = "1234574";
            musteri4.Id = 4;
            
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
            customerManager.Add(musteri3);
            customerManager.Add(musteri4);
        }
    }
}