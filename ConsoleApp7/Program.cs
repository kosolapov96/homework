using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                String numberTask = "  2) ";
                double a = 1, b = 2, c = 3, d = 4, result;
                result = (a / c) * (b / d) - (a * b - c) / (c * d);
                Console.WriteLine(numberTask + result);
            }

            {
                String numberTask = " 11) ";
                double x = 2, y = 4, result;
                result = Math.Pow((1 + 1 / x * x), x) - 12 * (x * x) * y;
                Console.WriteLine(numberTask + result);
            }

            {
                String numberTask = " 13) ";
                double x = 5, y = 4, result;
                result = (Math.Cos(x) / (Math.PI - 2 * x)) + 16 * x * Math.Cos(x * y) - 2;
                Console.WriteLine(numberTask + result);
            }

            {
                String numberTask = " 18) ";
                double x = 2.5, result;
                result = Math.Sin(Math.Sqrt(x + 1)) + Math.Sin(Math.Sqrt(x - 1));
                Console.WriteLine(numberTask + result);
            }

            {
                String numberTask = " 22) ";
                double x = 1.3, result;
                result = Math.Pow(Math.E, x) - x - 2 + (1 + x) * (1 + x);
                Console.WriteLine(numberTask + result);
            }
        }
    }
}
