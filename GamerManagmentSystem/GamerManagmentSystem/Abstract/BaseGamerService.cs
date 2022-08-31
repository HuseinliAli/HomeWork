using GamerManagmentSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerManagmentSystem.Abstract
{
    public abstract class BaseGamerService : IGamerService
    {
        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" is removed from database");
        }

        public virtual void Save(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" is added to database");
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+"`s information is updated");
        }
    }
}
