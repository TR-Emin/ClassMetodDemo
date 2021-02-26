using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class MusteriManager
    {

        public static void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("\n\n   Müşteri Ekleniyor");
            Console.WriteLine("Müşteri adı-soyadı : "+musteri.adi+" "+musteri.soyadi+"\nMüşteri telefon no : "+musteri.telNo+ "\nMüşteri Id: " + musteri.id+"\nİşlem başarılı.. Müşteri eklendi");
        }

        public static void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("\n\n   Müşteri Siliniyor");
            Console.WriteLine("Müşteri adı-soyadı : " + musteri.adi + " " + musteri.soyadi + "\nMüşteri telefon no : " + musteri.telNo + "\nMüşteri Id: " + musteri.id+ "\nİşlem başarılı.. Müşteri silindi");

            musteri.adi = "";
            musteri.soyadi = "";
            musteri.telNo = "";
            //System.GC.SuppressFinalize(musteri);

        }

        public static void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("\n\n   Müşteri Listeleniyor");
            Console.WriteLine("Müşteri Adı: "+musteri.adi+"\nMüşteri Soyadı:"+musteri.soyadi+"\nMüşteri Telefon Numarası: "+musteri.telNo+"\nMüşteri Id: "+musteri.id+ "\nİşlem başarılı.. Müşteri listelendi");
        }

    }
}
