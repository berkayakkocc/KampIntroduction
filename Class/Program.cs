using System;

namespace Class101
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "berkay";
            int yas = 25;
            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "Yazılıma Giriş";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 90;
            
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Mobil";
            kurs2.Egitmen = "Veli Bacık";
            kurs2.IzlenmeOrani = 80;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = ".NET";
            kurs3.Egitmen = "İsa Doğan";
            kurs3.IzlenmeOrani = 100;

            // Console.WriteLine(kurs1.KursAdi+" : "+kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" : "+kurs.Egitmen);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
