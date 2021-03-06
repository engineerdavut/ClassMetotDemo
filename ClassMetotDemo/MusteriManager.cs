using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi . " + musteri.MusteriAdi);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi . " + musteri.MusteriAdi);
        }
    }
}
