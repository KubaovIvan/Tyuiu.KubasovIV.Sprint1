﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KubasovIV.Sprint1.Task7.V13.Lib
{
    public class DataService : ISprint1Task7V13
    {
        public double Calculate(double x, double y)
        {
            double res = (Math.Pow(y, 2) - Math.Cos(Math.Pow(x, 2)) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(y, 2)) + 12);
            double result = Math.Round(res, 3);
            return result;
        }
    }
}
