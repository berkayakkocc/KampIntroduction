using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //Constructor : Bir kere çalışır
        public MyList()//Constructor
        {
            items = new T[0];
        }
        public void Add(T item) 
        {
            T[] tempArray = items;//geçici bir diziye atıyor
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];//geçici dizinin uzunlugu kadar itemsı alıp eşitliyor
            }
           
            items[items.Length - 1] = item;
        }

        public int Count 
        { get { return items.Length; }  }//itemsın uzunlugunu gönderiyor

        public T[] Items { get { return items; }  }
    }
}
