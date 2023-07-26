using System;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin","Murat","Ferhat","Semih","Faruk"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine("------------");

            //foreach (var isim in isimler)
            //{
            //    Console.WriteLine(isim);
            //}
            //Console.WriteLine("------------");
            ////new ile yeni bir adres atadık böylece dizideki 0 1 2 3
            //isimler = new string[6];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine("------------");
            //foreach (var isim in isimler)
            //{
            //    Console.WriteLine(isim);
            //}

            List<string> isimler2 = new List<string> {"Engin", "Murat", "Ferhat", "Semih", "Faruk" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[4]);
            Console.WriteLine("------------");
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[5]);
            Console.WriteLine(isimler2[0]);
            Console.WriteLine("------------");
            foreach (var isim in isimler2)
            {
                Console.WriteLine(isim);
            }




        }
    }
}