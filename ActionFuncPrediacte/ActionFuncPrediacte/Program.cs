using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ActionFuncPredicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Action<string, string> printFullName = (fn, ln) => {Console.WriteLine("Full Name is:" + fn + " " + ln);};
            //Console.WriteLine("Enter first name:");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("Enter last name:");
            //string lastName = Console.ReadLine();
            //printFullName(firstName, lastName);

            //Console.ReadKey();


            //Action<double, double, double> printMulti = (n1,n2,n3) => { Console.WriteLine("{0}*{1}*{2}={3} : ",n1,n2,n3,(n1*n2*n3)); };
            //Console.WriteLine("Enter first number:");
            //double firstNum = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number:");
            //double secondNum = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter third number:");
            //double thirdNum = double.Parse(Console.ReadLine());
            //printMulti(firstNum, secondNum, thirdNum);

            //Console.ReadKey();


            //Func<double, double, double> Multi = (a,b) => a*b;
            //Console.WriteLine("Enter first number:");
            //double firstNum = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number:");
            //double secondNum = double.Parse(Console.ReadLine());

            //double thirdNum = Multi(firstNum, secondNum);
            //Console.WriteLine("after multiplyin {0} and {1} = {2}" , firstNum, secondNum, thirdNum);

            //Console.ReadKey();


            Predicate<int> isEven = (number) => number % 2 == 0;
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            if(isEven(num))
            {
                Console.WriteLine($"{num} is an even number");
            }
            else
            {
                Console.WriteLine($"{num} is an odd number");
            }

            Console.ReadKey();
        }
    }
}
