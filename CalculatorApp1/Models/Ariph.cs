using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp1.Models
{
    static class Ariph
    {
        public static double Calculation(double a, double b, string c)
        {
                switch (c)
                {
                    case "*": return a * b;
                    case "/": return Math.Round(a / b, 5);                     
                    case "+": return a + b;
                    case "-": return a - b;
                    default: return 0;

                }

        }

        public static double CalculationOneElement(double a, string c)
        {
            switch (c)
            {
                case "1/x": return Math.Round(1 / a,5);
                case "x²": return a * a;
                case "√x": return Math.Round(Math.Sqrt(a), 5);
                default: return 0;
            }
        }
    }
}
