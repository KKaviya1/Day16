using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace ArithmeticOperations
 {
        //Define the delegate
        delegate int ArithmeticOperation(int a, int b);

        class Program
        {
            static int Add(int a, int b)
            {
                return a + b;
            }

            static int Subtract(int a, int b)
            {
                return a - b;
            }

            static int Multiply(int a, int b)
            {
                return a * b;
            }

            static int Divide(int a, int b)
            {
                if (b == 0)
                {
                    Console.WriteLine("Division by zero is not allowed.");
                    return 0;
                }

                return a / b;
            }

            static void Main(string[] args)
            {
                ArithmeticOperation addDelegate = Add;
                ArithmeticOperation subtractDelegate = Subtract;
                ArithmeticOperation multiplyDelegate = Multiply;
                ArithmeticOperation divideDelegate = Divide;

                Console.WriteLine("Enter two integers:");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Choose an arithmetic operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");

                int choice = int.Parse(Console.ReadLine());

                int result = 0;

                switch (choice)
                {
                    case 1:
                        result = addDelegate(num1, num2);
                        break;
                    case 2:
                        result = subtractDelegate(num1, num2);
                        break;
                    case 3:
                        result = multiplyDelegate(num1, num2);
                        break;
                    case 4:
                        result = divideDelegate(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        return;
                }

                Console.WriteLine($"Result: {result}");
                Console.ReadLine();
            }

        }

 }



