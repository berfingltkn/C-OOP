using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkGame
{
    interface IGamerService 
    {
       void Added(Gamer gamer);
       void Update();
       void Delete();
               
    }
}
