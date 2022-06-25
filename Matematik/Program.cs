using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(3, 5);

            dortIslem.Cikarma(5, 3);
            dortIslem.Cikarma(3, 5);
            dortIslem.Bolme(8, 4);
            dortIslem.Bolme(3, 2);
            dortIslem.Carpma(8, 4);
        }
    }
}
