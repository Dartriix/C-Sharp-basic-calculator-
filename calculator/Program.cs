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


            while (true)
            {


                Console.Write("\nEnter the first number: ");
                double num1;

                if (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("\nPlease enter a valid number.\nTry again");
                    Console.ReadLine();
                    continue;
                }

                Console.Write("\nEnter Operator ");
                string OP = Console.ReadLine();

                if (OP != "+" && OP != "-" && OP != "*" && OP != "/")
                {
                    Console.WriteLine("\nPlease Enter a valid Operator.\nTry again");
                    continue;
                }


                Console.Write("\nEnter the second number: ");
                double num2;

                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("\nPlease enter a valid number.\nTry again");
                    Console.ReadLine();
                    continue;
                }
                if (OP == "/" && num2 == 0)
                {
                    Console.WriteLine("\nYou cannot divide by zero.\nTry again");
                    continue;
                }

                if (OP == "+")
                {
                    double result = num1 + num2;
                    Console.WriteLine("\nThe answer is " + result.ToString());
                }
                else if (OP == "-")
                {
                    double result = num1 - num2;
                    string resultString = "\nThe answer is " + result.ToString();
                    Console.WriteLine(resultString);
                    Console.ReadLine();
                }
                else if (OP == "/")
                {
                    Console.WriteLine("\nThe answer is " + num1 / num2);
                }
                else if (OP == "*")
                {
                    Console.WriteLine("\nThe answer is " + num1 * num2);
                }

                while (true)
                {
                    Console.WriteLine("1. To continue");
                    Console.WriteLine("2. To exit");
                    Console.Write("\nchoose 1 / 2 : ");
                    string user_input = Console.ReadLine();

                    if (user_input == "1")
                    {
                        break;
                    }
                    else if (user_input == "2")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("\nPlease Enter a valind option.");
                        continue;
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
