using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
   public class DortIslem
    {
        public void Topla(int sayi1,int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Sonuç : "+sonuc);
        }
        public void Cikarma(int sayi1,int sayi2)
        {
            if (sayi1>sayi2)
            {
                int sonuc = sayi1 - sayi2;
                Console.WriteLine("Sonuç : " + sonuc);

            }
            else
            {
                int sonuc = sayi1 - sayi2;
                Console.WriteLine("Sonuç : " + sonuc);

            }
            
        }
        public void Bolme(double sayi1,double sayi2)
        {
            if (sayi1>sayi2)
            {
                double sonuc = sayi1 / sayi2;
                Console.WriteLine("Sonuç : " + sonuc);
            }
            else
            {
                double sonuc = sayi2 / sayi1;
                Console.WriteLine("Sonuç : " + sonuc);
            }
        }
        public void Carpma(int sayi1,int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine("Sonuç : " + sonuc);
        }
    }
}
