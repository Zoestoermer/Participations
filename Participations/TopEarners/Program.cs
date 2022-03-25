using System;
using System.Collections.Generic;

namespace TopEarners
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = "---Top Earners___";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, (Console.CursorTop));
            Console.WriteLine(title);

            string[] firstName = new string[3];
            string[] lastName = new string[3];

            Console.WriteLine("The top three earners in the company are:\n\r");
            for (int i = 0; i <= firstName.Length; i++)
            {
                Console.WriteLine($"Salesperson {1 + 1} first name: ");
                firstName[i] = Console.ReadLine().Trim();
                Console.WriteLine($"Salesperson {i + 1} last name: ");
                lastName[i] = Console.ReadLine().Trim();
            }

            List<double> thisYearsEarnings = new List<double>();
            for (int i = 0; i <= lastName.Length; i++)
            {
                bool isNUmber = false;
                double earning;
                do
                {
                    Console.WriteLine($"What are {firstName[i]} {lastName[i]}'s earnings this year?");
                    isNUmber = double.TryParse(Console.ReadLine(), out earning);
                } while (!isNUmber);

                thisYearsEarnings.Add(earning);
            }

            double sum = 0; 
            for (int i = 0; i < thisYearsEarnings.Count; i++)
            {
                sum += thisYearsEarnings[i];
            }

            Dictionary<int, string> employees = new Dictionary<int, string>();
            for (int i = 0; i<= firstName.Length; i++)
            {
                var fullName = firstName[i] + " " + lastName[i];
                Console.WriteLine($"What is {fullName}'s employee number?");
                var employeeNumber = Convert.ToInt32(Console.ReadLine());
                
                if (employees.ContainsKey(employeeNumber))
                {
                    Console.WriteLine($"Employee nuk=mber: {employeeNumber} already exists");
                }
                else
                {
                    employees.Add(employeeNumber, fullName);
                }
                
            }

            Console.ReadKey();
        }
    }
}
