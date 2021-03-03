using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenligi
            //do not repeat yourself - Kendini tekrarlama
            string kategoriEtiketi = "kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("artış");
            }
            else
            {
                Console.WriteLine("eşittir");
            }

            if (sistemeGirisYapmismi==true)
            {
                Console.WriteLine("Kulllanıcı Ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);


        }
    }
}
