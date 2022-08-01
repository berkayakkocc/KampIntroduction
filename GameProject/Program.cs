using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamer = new GamerManager(new NewEStateUserValidation());
            gamer.Add(new Gamer
            {
                FirstName = "Berkay",
                LastName = "Akkoç",
                BirthdayYear = 1997,
                IdentityNumber = 123456
            });
        }
    }
}
