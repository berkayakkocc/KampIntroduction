using System;

namespace Donguler101
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] takimlar = { "Fenerbahce", "Galatasaray", "Besiktas", "Hamsispor" };
            var teamName="Takım Adı : ";
            for (int i = 0; i < takimlar.Length; i++)
            {
                Console.WriteLine(teamName+takimlar[i]);
            }

            Console.WriteLine("For Bitti");


            foreach (var takim in takimlar)
            {
                Console.WriteLine(takim);
            }
        }
    }
}
