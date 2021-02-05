using System;

namespace Dongıer
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım yetiştirici geliştirme kampı";
            string kurs2 = "proğramlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Pyton";
            string kurs5 = "c++";

            //array-dizi
            string[] kurslar = new string[] { "proğramlamaya başlangıç için temel kurs", "proğramlamaya başlangıç için temel kurs", "Java","pyton","c#" };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
  
            }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu footer");
        }
    }
}
