using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Bulaşık Makinesi";
            urun1.Fiyat = 5000;
            urun1.Aciklama = "Beyaz Eşya";
            
            Urun urun2 = new Urun();
            urun2.Adi = "Çamaşır Makinesi";
            urun2.Fiyat = 6500;
            urun2.Aciklama = "Beyaz Eşya";
            Urun[] urunler = { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
            }

            Console.WriteLine("---------Metotlar---------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
        }
    }
}

// do not repeat yourself
// dry
// clean code
// best practices

