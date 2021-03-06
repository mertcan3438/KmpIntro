﻿using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
        
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseloggerService = new DatabaseLoggerService();
            ILoggerService filelogerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            List<ILoggerServices> list = new List<ILoggerServices>();

            basvuruManager.BasvuruYap(new EsnafKredisiManager(), list);

            List<IKrediManager> krediler = new List<IKrediManager>() {tasitKrediManager };

            //basvuruManager.KrediOnBılgılendirmesiYap(krediler);
        }
    }
}
