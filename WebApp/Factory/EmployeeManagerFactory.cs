using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Mangers;

namespace WebApp.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int employyeType)
        {
            IEmployeeManager returnValue = null;
            if (employyeType == 1)
            {
                returnValue = new EmployeeManager();
            }
            else if (employyeType == 2)
            {
                returnValue = new ContractEmployeeManager();
            }
            return returnValue;
        }
    }
}