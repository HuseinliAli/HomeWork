using GamerManagmentSystem.Abstract;
using GamerManagmentSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerManagmentSystem.Concrete
{
    public class GamerManager : BaseGamerService
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Save(Gamer gamer)
        {
            if(_gamerCheckService.CheckIfRealGamer(gamer))
            {
                base.Save(gamer);
            }
            else
            {
                throw new Exception("Not a valid gamer");
            }
        }
    }
}
