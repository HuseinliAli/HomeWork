using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoAbstract.Abstract;

namespace DemoAbstract.Concrete
{
    internal class CustomerCheckManager : ICustomerCheckService
    {
        public bool ChechIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
