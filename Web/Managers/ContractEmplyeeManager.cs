using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Manages;

namespace Web.Managers
{
    public class ContractEmplyeeManager : IEmployeeManagers
    {
        public decimal GetBonus()
        {
            return 5;
        }

        public decimal GetPay()
        {
            return 12;
        }
    }
}
