using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkGame
{
    class UserValidationManager : IUserValudationService
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.Name == "Berfin" && gamer.Surname == "Gultekin" && gamer.DateTime==2002 &&gamer.ID==10) 
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
