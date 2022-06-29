using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class CorporateCustomer:Customer
    {
       
        public string TaxNo { get; set; }//vergi numarası
        public string CompanyName { get; set; }
    }
}
