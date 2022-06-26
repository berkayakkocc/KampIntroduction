using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Amaç :array new alır iken sıfırlanır ve degerler null olur.
            //string[] takimlar = new string[] { "FENERBAHÇE", "Galatasaray", "Beşiktaş", "Trabzonspor" };
            //Console.WriteLine(takimlar[0]);
            //Console.WriteLine(takimlar[1]);
            //Console.WriteLine(takimlar[2]);
            //Console.WriteLine(takimlar[3]);
            //takimlar = new string[4];
            //takimlar[4] = "Başakşehir";


            //Console.WriteLine(takimlar[4]);
            //Console.WriteLine(takimlar[0]);

            List<string> takimlar = new List<string> { "FENERBAHÇE", "Galatasaray", "Beşiktaş", "Trabzonspor" };
            Console.WriteLine(takimlar[0]);
            Console.WriteLine(takimlar[1]);
            Console.WriteLine(takimlar[2]);
            Console.WriteLine(takimlar[3]);
            takimlar.Add("Başakşehir");
            Console.WriteLine(takimlar[4]);
            Console.WriteLine(takimlar[0]);

        }
    }
}
