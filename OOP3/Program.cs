using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();        
            IKrediManager tasitKrediManager = new TasitKrediManager();         
            IKrediManager konutKrediManager = new KonutKrediManager();


            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileBaseLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager,new List<ILoggerService> { new SmsLoggerService(), new DataBaseLoggerService() });

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);



        }
    }
}
