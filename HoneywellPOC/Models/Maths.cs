using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoneywellPOC.Models
{
    public class Maths
    {
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Substract(double a, double b)
        {
            return a - b;
        }

        public double Divide(double a, int b)
        {
            if (b == 0)
            {
                return 0;
            }
            else
            {
                return a / b;
            }

        }
    }
}
