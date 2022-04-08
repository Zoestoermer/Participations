//11.1 participation
using System;

namespace GetDoubleInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double userInput = GetDoubleInput("Enter a number to be multiplied by 5");
            MultiplyBy5(userInput);

            Console.ReadKey();
        }

        private static void MultiplyBy5(double userInput)
        {
            Console.WriteLine($"{userInput} x 5 = {userInput*5}");
        }

        private static double GetDoubleInput(string message)
        {
            double result = 0;
            bool isNum = false;
            do
            {
                Console.WriteLine(message);
                isNum = double.TryParse(Console.ReadLine(), out result);

            }while (!isNum);

            return result;
        }
    }
}
