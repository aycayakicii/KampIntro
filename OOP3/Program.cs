﻿using System;
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
            EsnafKredisiManager esnafKredisiManager = new EsnafKredisiManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();
            //SmsLoggerService smsLoggerService = new SmsLoggerService();    BURADA TANIMLAMASZSAK AŞAĞIDA NEW DİYE YAZABİLİRİZ.

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKredisiManager, 
                new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() });
            
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
