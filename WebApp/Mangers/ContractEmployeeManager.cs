using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Mangers
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        decimal IEmployeeManager.GetBonus()
        {
            return 5;
        }

        decimal IEmployeeManager.GetPay()
        {
            return 12;
        }
    }
}