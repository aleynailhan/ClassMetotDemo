using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Adi = "aleyna";
            musteri.Soyadi = "ilhan";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "berfin";
            musteri2.Soyadi = "atar"; 

            MusteriManager mn = new MusteriManager();
            mn.Ekle(musteri);
            mn.Ekle(musteri2);

            Musteri[] musteriler = new Musteri[]
            {
                musteri,musteri2
            };
            mn.Listele(musteriler);
            
           
           
        }
    }
}
