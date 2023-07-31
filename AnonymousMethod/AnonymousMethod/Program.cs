using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
    internal class Program
    {
        public delegate void WelDel(string name);
        static void Main(string[] args)
        {
            // Anonymous method***

            //WelDel objDel = delegate (string name)
            //{
            //    Console.WriteLine("Welcome to Anonymous method Mr.\\ Ms." + name);

            //};
            //objDel("Viya");



            //normal method***

            //WelDel objDel = new WelDel(OurMethod);
            //objDel("Normal method");

            //lambda***

            WelDel objDel = (string name) => Console.WriteLine("welcome to lambdas " + name);
            objDel("Viya");


            Console.ReadKey();  
        }
    }
}
