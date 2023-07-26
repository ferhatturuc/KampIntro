using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //değer tutucu, alias(kategori etiketi)
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 27;
            double dolarBugun = 26.23;

            if (sistemeGirisYapmisMi == false)
            {
                Console.WriteLine("Giriş yapınız");
            }
            else
            {
                Console.WriteLine("Kullanıcı ayarları");
            }

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Dolar düştü"); 
            }
            else if(dolarDun < dolarBugun)
            {
               Console.WriteLine("Dolar yükseldi");
            }
            else
            {
                Console.WriteLine("Dolar değişmedi");
            }
            //Do not repeat yourself - Kendini tekrarlama
            Console.WriteLine(kategoriEtiketi);
        }
    }
}