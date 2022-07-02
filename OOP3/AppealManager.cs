using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class AppealManager
    {
        public void DoAppeal(ICreditManager credit)
        {
            // Appeal Info

            
            credit.Calculate();
           
        }
        public void GetPriorKnowledge(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
                
            }
        }
    }
}
