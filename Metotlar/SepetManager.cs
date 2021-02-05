using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("tebrikler.  Sepete eklendi!  :"+urun.Adi);

        }
        public void Ekle2(string urunadi,string aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("tebrikler.  Sepete eklendi!  :" + urunadi);
        }
    }
}
