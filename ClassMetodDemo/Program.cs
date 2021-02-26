using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.id = 1;
            musteri1.adi = "Muhammet Emin";
            musteri1.soyadi = "Aslangil";
            musteri1.telNo = "1234567889";

            MusteriManager.MusteriEkle(musteri1);
            MusteriManager.MusteriListele(musteri1);
            MusteriManager.MusteriSil(musteri1);
            
        }
    }
}
