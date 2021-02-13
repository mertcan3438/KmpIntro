using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    //Method injection
    class BasvuruManager
    {
        public object Logger { get; private set; }

        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //
            krediManager.Hesapla();
            foreach (var loggerservice in loggerServices)
            {
                loggerservice.Log();
            }
        }
        public void KrediOnBılgılendirmesiYap(List<IKrediManager> krediler) 
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

        internal void BasvuruYap(EsnafKredisiManager esnafKredisiManager, List<ILoggerServices> list)
        {
           
        }
    }
}
