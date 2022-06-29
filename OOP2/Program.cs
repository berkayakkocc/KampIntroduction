using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCustomer customer1 = new RealCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "123456789";
            customer1.TCNo = "2222222222";
            customer1.FirstName = "Berkaycan";
            customer1.LastName = "AKKOÇ";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "234567892";
            customer2.CompanyName = "Intel";
            customer2.TaxNo = "333333333";
            
        }
    }
}
