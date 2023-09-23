using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkGame
{

    //MicroService--> GamerManager içinde başka bir service kullanıcaz.
    class GamerManager:IGamerService
    {
        IUserValudationService _userValudationService;

        public GamerManager(IUserValudationService userValudationService)
        {
            _userValudationService = userValudationService;
        }

        public void Added(Gamer gamer)
        {
            if (_userValudationService.Validation(gamer)==true)
            {
                Console.WriteLine("Registration successfull");
            }
            else
            {
                Console.WriteLine("Registration failed.");
            }
            
        }

        public void Update()
        {
            Console.WriteLine("Update.");
        }

        public void Delete()
        {
            Console.WriteLine("Delete.");
        }

    }
}
