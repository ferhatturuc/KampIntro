using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService= new SmsLoggerService();


            List<IKrediManager> krediler = new List<IKrediManager>()
            {
                ihtiyacKrediManager ,
                tasitKrediManager,
                konutKrediManager,
                esnafKrediManager };
            
           
            List<ILoggerService> loggers = new List<ILoggerService>
            {
                new DatabaseLoggerService(),
                new FileLoggerService(),
                new SmsLoggerService()
            };

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager, new DatabaseLoggerService());
            //basvuruManager.BasvuruYap(tasitKrediManager, databaseLoggerService);
            //basvuruManager.BasvuruYap(konutKrediManager, fileLoggerService);
            //basvuruManager.BasvuruYap(esnafKrediManager, smsLoggerService);

            basvuruManager.BasvuruYap(
                new IhtiyacKrediManager(),
                new List<ILoggerService> 
                { 
                    new DatabaseLoggerService(), 
                    new SmsLoggerService() 
                });

            basvuruManager.BasvuruYap(new EsnafKrediManager(), loggers);
            Console.WriteLine("-----------------");
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}