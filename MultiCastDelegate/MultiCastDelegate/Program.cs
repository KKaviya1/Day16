using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegate
{
    internal class Program
    {
        public delegate void CalcDel(double num1, double num2);
        static void Main(string[] args)
        {
            Calculation cal = new Calculation();
            CalcDel objDel = new CalcDel(cal.Add);
            Console.WriteLine("After adding one method in invocation list:");
            objDel(10.2, 13.52);
            objDel += new CalcDel(cal.Diff);
            Console.WriteLine("After adding two methods");
            objDel(32, 42.6);
            objDel = new CalcDel(cal.Add);
            Console.WriteLine("After adding three methods");
            objDel(34, 52.9);
            objDel -= new CalcDel(cal.Diff);
            Console.WriteLine("After removing Diff as well");
            objDel(23, 63.5);



            Console.ReadKey();  
        }
    }
}
