﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Mangers
{
    public interface IEmployeeManager
    {
        decimal GetBonus();
        decimal GetPay();
    }
}
