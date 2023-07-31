using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    //delegates can represent instance method
    //& static method but the signature must watch

    public delegate void OurDelegate(string name);
    internal class Program
    {
        public static void Welcome(string n)
        {
            Console.WriteLine("Welcome to Delegate: " +n);

        }
        public void MyMethod(string msg)
        {
            Console.WriteLine("Message for you: " +msg);
        }
        static void Main(string[] args)
        {
            OurDelegate ourDelegate = new OurDelegate(Welcome);
            ourDelegate("Viya Gandhi");
            Program obj = new Program();
            OurDelegate ourDelegate1 = new OurDelegate(obj.MyMethod);
            ourDelegate("Let us Begin");


            Console.ReadKey();
        }
    }
}
