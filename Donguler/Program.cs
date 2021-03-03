using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "programlamaya baslangıc ıcın temel kurs";
            string kurs3 = "java";
            string kurs4 = "python";


            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı" ,
                "programlamaya baslangıc ıcın temel kurs", "java" ,"python","c++"};

           

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }


            Console.WriteLine("for bitti.....");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            
            


            Console.WriteLine("sayfa sonu");
        }
    }
}
