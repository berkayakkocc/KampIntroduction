using System;

namespace KampIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;

            double dolarDun = 17.35;
            double dolarBugun = 16.45;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış");
            }
            else
            {
                Console.WriteLine("Stabil");
            }

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Sisteme Giriş Yaptı");
            }
            else
            {
                Console.WriteLine("Sisteme Giriş Yapmadı");
            }
        }
    }
}
