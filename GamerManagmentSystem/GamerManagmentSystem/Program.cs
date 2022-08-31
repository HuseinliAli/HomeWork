using GamerManagmentSystem.Abstract;
using GamerManagmentSystem.Concrete;
using GamerManagmentSystem.Entities;
using System;

namespace GamerManagmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseGamerService baseGamerService = new EmpityGamerManager();

            baseGamerService.Save(
                new Gamer
                {
                    DateOfBirth = new DateTime(2004, 7, 31),
                    FirstName = "Ali",
                    LastName = "Huseynli",
                    NationalityID = "az1221312"
                });

            baseGamerService.Update(
                new Gamer
                {
                    FirstName = "Ab"
                });
            baseGamerService.Delete(
                new Gamer
                {
                    FirstName = "Ali"
                });

            Game game = new();
            game.ID=1;
            game.GameName="God of War";

            Gamer gamer = new();
            gamer.ID=1;
            gamer.FirstName="Elconi";
            gamer.LastName="Bahmanov";
            gamer.DateOfBirth=new DateTime(2003, 12, 21);

            BuyGameManager buy = new();

            buy.GameBuy(game, gamer);
        }
    }
}
