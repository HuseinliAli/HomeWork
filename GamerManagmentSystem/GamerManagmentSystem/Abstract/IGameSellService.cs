using GamerManagmentSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerManagmentSystem.Abstract
{
    public interface IGameSellService
    {
        void GameBuy(Game game, Gamer gamer);
    }
}
