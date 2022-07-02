using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class CraftCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Craft Credit is calculated");
        }

        public void Do()
        {
            throw new NotImplementedException();
        }
    }
}
