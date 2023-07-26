using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";

            //array - dizi
            string[] kurslar = new string[]
            {
                "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya Başlangıç İçin Temel Kurs",
                "Java","Python"
            };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("\n");

            //kurslar = kursları dolaş kurs = kurslar[0] gibi 
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}, Hello, World!",i);
            }

            Console.ReadLine();
        }
    }
}