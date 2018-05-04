using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.CalcOperation
{
    public class CalcOperation
    {
        public  Total(int value1, int value2, string calc)
        {
            int total = 0;
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
            return Content(total);
        }
    }
}
