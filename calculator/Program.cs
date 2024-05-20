using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result;
            string answer;

                Console.WriteLine("We are going to make a calculator using C#");
            Console.WriteLine("Enter first number");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What operations you want to perform?");

            Console.WriteLine("Enter 'a' for Add , 's' for subtract,'m' for multiply,'d' for divide");
            
            answer = Console.ReadLine();
            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else 
            {
                result = num1 / num2;
            }

            Console.WriteLine("The result is " + result);
            Console.WriteLine("Thank you for using calculator");

            Console.ReadKey();
        }
    }
}
