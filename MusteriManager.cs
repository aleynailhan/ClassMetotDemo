using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musterii)
        {
            Console.WriteLine("Musteri " + musterii.Adi + musterii.Soyadi + " eklendi");
            Console.WriteLine("-------------------------------------");
        }

        public void Listele(Musteri[] musteriler)
            {

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi + " " + musteri.Soyadi);
            }
            Console.WriteLine("Müşteriler Listelendi");
        }
        public void Sil(Musteri musterii)
        {
            Console.WriteLine("Müşteriler silindi"+ musterii.Id+ musterii.Adi+ musterii.Soyadi);
        }
    }
}
