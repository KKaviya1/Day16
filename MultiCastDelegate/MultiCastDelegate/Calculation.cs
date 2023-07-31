using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegate
{
    public class Calculation
    {
        public void Add(double num1, double num2)
        {
            double result = num1 + num2;
            Console.WriteLine("Result:" + result);
        }

        public void Diff(double num1, double num2)
        {
            double result = num1 - num2;
            Console.WriteLine("Result:" + result);
        }

        public void Div(double num1, double num2)
        {
            double result = num1 / num2;
            Console.WriteLine("Result:" + result);
        }

        public void Multi(double num1, double num2)
        {
            double result = num1 * num2;
            Console.WriteLine("Result:" + result);
        }

        public void Avg(double num1, double num2)
        {
            double result = (num1 + num2)/2;
            Console.WriteLine("Result:" + result);
        }

    }
}
