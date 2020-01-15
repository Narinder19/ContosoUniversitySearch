using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Managers;
using Web.Manages;

namespace Web.Factory
{
    public class EmployeeMangerFactory
    {
        public IEmployeeManagers GetEmployeeManger(int employeeTypeID)
        {
            IEmployeeManagers returnValue = null;
            if (employeeTypeID == 1)
            {
                returnValue = new PermanentEmployeeManager();
            }
            else if (employeeTypeID == 2)
            {
                returnValue = new ContractEmplyeeManager();
            }
            return returnValue;
        }
    }
}
