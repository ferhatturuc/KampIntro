using System;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);
            //int,decimal,float,double,bool = değer tipi

            int[] sayilar1 = new int[] {10, 20, 30};
            int[] sayilar2 = new int[] {100, 200, 300 };

            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]+" "+ sayilar1[1]+" " + sayilar1[2]);
            //array,class,interface = referans tipi
            //bellekte stack ve heap alanları var 
            //değer tipleri stack te referans tipleri ise heap te gerçekleşir 
        }
    }
}