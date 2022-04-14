//12.1 participation
using System;
using System.Collections.Generic;

namespace SumOf3
{
    internal class Program
    {
        static double GlobalVariable;
        static void Main(string[] args)
        {
            DisplayHeader();
            Console.WriteLine("Please set a gloabal variable");
            GlobalVariable = ValidateNumber(Console.ReadLine());
            List<double> numbers = new List<double>();

            Console.WriteLine("Please enter a number");
            numbers.Add(ValidateNumber(Console.ReadLine()));

            Console.WriteLine("Please enter another number");
            numbers.Add(ValidateNumber(Console.ReadLine()));

            Console.WriteLine("Please enter one more number");
            numbers.Add(ValidateNumber(Console.ReadLine()));

            Console.WriteLine($"{Add(numbers):n2}");
            Console.WriteLine($"The numbers multiplied by the constant {GlobalVariable} is {GlobalVariable * Add(numbers):n2}");
            //or 
            //double sumNum = Add(numbers);
            //Console.WriteLine($"{sumNum:n2}");


            Console.ReadKey();
        }
        static void DisplayHeader()
        {
            string title = "---Sum of 3 Numbers---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);
        }
        static double ValidateNumber(string number)
        {
            bool isNumber = false;
            double validNumber = 0;
            do
            {
                isNumber = double.TryParse(number, out validNumber);

                if (!isNumber)
                {
                    Console.WriteLine("Please enter a valid number");
                    isNumber = double.TryParse(Console.ReadLine(), out validNumber);
                }
            } while (!isNumber);

            return validNumber;
        }
        static double Add(List<double> nums)
        {
            double sum = 0;
            foreach (double num in nums)
            {
                sum += num;
            }

            return sum;
        }
    }
}
