using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            string separator = "--------";
            RequirementCreditManager requirementCreditManager = new RequirementCreditManager();
            requirementCreditManager.Calculate();

            CarCreditManager carCreditManager = new CarCreditManager();
            carCreditManager.Calculate();

            HomeCreditManager homeCreditManager = new HomeCreditManager();
            homeCreditManager.Calculate();
            
            Console.WriteLine("Manager instance end");
            Console.WriteLine(separator);
            Console.WriteLine(separator);
            Console.WriteLine("Interface object start");
            Console.WriteLine(separator);
            //Interfacelerde managerların referans numarasını tutabiliyor.

            ICreditManager requirement = new RequirementCreditManager();
        

            ICreditManager car = new CarCreditManager();
           

            ICreditManager home = new HomeCreditManager();

            AppealManager appealManager = new AppealManager();
            appealManager.DoAppeal(home);
            appealManager.DoAppeal(car);
            appealManager.DoAppeal(requirement);

            //  Warningg!!!!!
            //  ICreditManageri implemente ettiğimiz için 3 ekrandaki methodları da kullanabiliyoruz.
            // Hangi referans ad ile çağırır isek onun managerindaki methodu kullanmaktayız.
           
        }
    }
}
