using System;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Ferhat");

            List<string> liste = new List<string>();
            Console.WriteLine(liste.Count);

            //foreach (var isim in isimler)
            //{
            //    Console.WriteLine(isim);
            //}

            Console.WriteLine("Hello, World!");
        }
    }
}