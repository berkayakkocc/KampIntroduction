﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName=="Berkay"&&gamer.LastName=="Akkoç"&&gamer.BirthdayYear==1997&&gamer.IdentityNumber==123456)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
