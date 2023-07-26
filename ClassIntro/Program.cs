using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs
            {
                KursAdi = "C#",
                Egitmen = "Engin Demirog",
                IzlenmeOrani = 72
            };

            Kurs kurs2 = new Kurs
            {
                KursAdi = "Java",
                Egitmen = "Engin Demirog",
                IzlenmeOrani = 69
            };

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Ferhat Turuç";
            kurs3.IzlenmeOrani = 47;

            Console.WriteLine("Kurs adı : " + kurs1.KursAdi + " " + " Eğitmen :" + kurs1.Egitmen);
            Console.WriteLine("\n");
            Kurs[] kurslar = new Kurs[]
            {
                kurs1,
                kurs2,
                kurs3
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine("Kurs adı : " + kurs.KursAdi + " : " + " Eğitmen :"+ kurs.Egitmen);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Hello, World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
