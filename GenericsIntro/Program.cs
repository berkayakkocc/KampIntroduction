using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();

            names.Add("Berkay");//Add methodunu çağırıyor
            Console.WriteLine(names.Count);//değişkenin içini saydırıyo

            names.Add("Ugur");
            Console.WriteLine(names.Count);

            names.Add("Serhat");
            Console.WriteLine(names.Count);

            foreach (var name in names.Items)
            {
                Console.WriteLine(name);//tum elemanı yazdırıyor
            }
        }
    }
}
