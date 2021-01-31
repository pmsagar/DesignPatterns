using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Mangers
{
    public class EmployeeManager : IEmployeeManager
    {
        decimal IEmployeeManager.GetBonus()
        {
            return 10;
        }

        decimal IEmployeeManager.GetPay()
        {
            return 8;
        }
    }
}