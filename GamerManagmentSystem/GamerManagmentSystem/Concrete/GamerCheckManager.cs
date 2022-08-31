using GamerManagmentSystem.Abstract;
using GamerManagmentSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerManagmentSystem.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealGamer(Gamer gamer)
        {
            return true;
        }
    }
}
