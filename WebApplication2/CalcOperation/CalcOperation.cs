using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.CalcOperation
{
    public class CalcOperation
    {
        public static double Total(int value1, int value2, string calc) //make this class a static double 
        {
            double total = 0; //shuold be a double
            switch (calc)
            {
                case "+":
                    total = value1 + value2;
                    break;
                case "-":
                    total = value1 - value2;
                    break;
                case "*":
                    total = value1 * value2;
                    break;
                case "/":
                    total = value1 / value2;
                    break;
                default:
                    total = 0;
                    break;
            }
            return total; //not sure what content(total) was maybe I missed something
        }
    }
}
