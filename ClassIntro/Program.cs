using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            string adi = "mustafa";
            int yas = 36;
            Console.WriteLine("Hello World!");
            Kurs kurs1 = new Kurs();

            kurs1.kursAdi = "c#";
            kurs1.Egitmen = "Mustafa";
            kurs1.IzlenmeOrani = 100;


            Kurs kurs2 = new Kurs();

            kurs2.kursAdi = "java";
            kurs2.Egitmen = "engin";
            kurs2.IzlenmeOrani = 150;


            Kurs kurs3 = new Kurs();

            kurs3.kursAdi = "python";
            kurs3.Egitmen = "eymen";
            kurs3.IzlenmeOrani = 35;

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3};

            foreach (var x in kurslar)
            {
                Console.WriteLine(x.kursAdi+ " : " +x.Egitmen);
            }

        }

    }
    class Kurs
    {
        public string kursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }


    }

}
