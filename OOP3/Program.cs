using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //string separator = "--------";
            //RequirementCreditManager requirementCreditManager = new RequirementCreditManager();
            //requirementCreditManager.Calculate();

            //CarCreditManager carCreditManager = new CarCreditManager();
            //carCreditManager.Calculate();

            //HomeCreditManager homeCreditManager = new HomeCreditManager();
            //homeCreditManager.Calculate();

            //Console.WriteLine("Manager instance end");
            //Console.WriteLine(separator);
            //Console.WriteLine(separator);
            //Console.WriteLine("Interface object start");
            //Console.WriteLine(separator);
            ////Interfacelerde managerların referans numarasını tutabiliyor.

            ICreditManager requirement = new RequirementCreditManager();


            ICreditManager car = new CarCreditManager();


            ICreditManager home = new HomeCreditManager();

            ICreditManager craft = new CraftCreditManager();

            AppealManager appealManager = new AppealManager();
            DatabaseLoggerService databaseLoggerService = new DatabaseLoggerService();
            FileLoggerService fileLoggerService = new FileLoggerService();
            SmsLoggerService smsLoggerService = new SmsLoggerService();
            List<ILoggerService> allLoggersService = new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService(), new SmsLoggerService() };
            

            //appealManager.DoAppeal(home);
            //appealManager.DoAppeal(car);
           appealManager.DoAppeal(requirement,new List<ILoggerService> { databaseLoggerService,smsLoggerService});
            appealManager.DoAppeal(car, new List<ILoggerService> { fileLoggerService,smsLoggerService});
            appealManager.DoAppeal(craft,new  List<ILoggerService>{ smsLoggerService,databaseLoggerService,fileLoggerService});
            appealManager.DoAppeal(craft, allLoggersService);
            //  Warningg!!!!!
            //  ICreditManageri implemente ettiğimiz için 3 ekrandaki methodları da kullanabiliyoruz.
            // Hangi referans ad ile çağırır isek onun managerindaki methodu kullanmaktayız.

            List<ICreditManager> credits = new List<ICreditManager>() { requirement,car};
           // appealManager.GetPriorKnowledge(credits);

           
        }
    }
}
