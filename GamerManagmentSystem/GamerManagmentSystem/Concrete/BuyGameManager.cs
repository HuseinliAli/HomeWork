using GamerManagmentSystem.Abstract;
using GamerManagmentSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerManagmentSystem.Concrete
{
    public class BuyGameManager : IGameSellService
    {
        public void GameBuy(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName+" is added to "+gamer.FirstName+"`s account");
        }
    }
}
