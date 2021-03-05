using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Mustafa";
            musteri1.Soyadi = "Celik";
            musteri1.TcNo = "1111111111";



            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54123";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "123456789";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(musteri4); 


        }
    }
}
