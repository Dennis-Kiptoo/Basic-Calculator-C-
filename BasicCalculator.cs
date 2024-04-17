using System;
namespace Kiptoo
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter modulus of the operation you want to perform");
            Console.WriteLine("1.Addition {+}");
            Console.WriteLine("2.Subtraction {-}");
            Console.WriteLine("3.Multiplication {*}");
            Console.WriteLine("4.Division {/}");

            Console.WriteLine("Enter the first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operation you want to perform");

            char operation = Console.ReadKey().KeyChar;


            Console.WriteLine();

            double result = 0;
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Invalid denominator cannot be zero");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Operation");
                    break;
            }


            Console.WriteLine($"Your results are {result}");



        }
        

       
    }
}
        