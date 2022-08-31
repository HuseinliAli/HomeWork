using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAbstract.Abstract
{
    public interface ICustomerCheckService
    {
        bool ChechIfRealPerson(Customer customer);
    }
}
