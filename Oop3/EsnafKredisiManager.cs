﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class EsnafKredisiManager : IKrediManager
    {
        public void BişeyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı");
        }
    }
}
