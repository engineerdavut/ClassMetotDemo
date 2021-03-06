using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "oguz";
            musteri1.MusteriSoyad = "kara";
            musteri1.MusteriLimit = 7000;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "mahmut";
            musteri2.MusteriSoyad = "tebesir";
            musteri2.MusteriLimit = 2000;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdi = "berk";
            musteri3.MusteriSoyad = "parali";
            musteri3.MusteriLimit = 50000;


            Musteri[] musteriler = new Musteri[] { musteri1,musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi);
                Console.WriteLine(musteri.MusteriSoyad);
                Console.WriteLine(musteri.MusteriLimit);
                Console.WriteLine("-------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriSil(musteri3);
        }
    }
}
