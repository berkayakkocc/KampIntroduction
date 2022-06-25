using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
   public class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi : "+ urun.Adi);
        }
        public void Ekle2(string adi,double fiyat,string aciklama,int stokAdedi)
        {
            Console.WriteLine("Sepete Eklendi : " + adi);
        }
    }
}
