//10.1 participation

using System;
using System.Collections.Generic;

namespace ClassGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstName = new string[3];
            string[] lastName = new string[3];

            for (int i = 0; i < firstName.Length; i++)
            {
                Console.WriteLine("Please input the earner's first name.");
                firstName[i] = Console.ReadLine().Trim();

                Console.WriteLine("Please input the earner's last name.");
                lastName[i] = Console.ReadLine().Trim();
            }

            Dictionary<int, string> salesPeople = new Dictionary<int, string>();
            bool isNumber = false;
            int employeeNumber = 0;
            for (int i = 0; i < firstName.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Please enter {firstName[i]} {lastName[i]}'s employee number.");
                    isNumber = int.TryParse(Console.ReadLine(), out employeeNumber);
                } while (!isNumber);

                salesPeople.Add(employeeNumber, firstName[i] + " " + lastName[i]);
            }

            List<double> earnings = new List<double>();
            // or you could do foreach (var salesPerson in salesPeople)
            double earned = 0;
            foreach (KeyValuePair<int, string> salesPerson in salesPeople)
            {

                do
                {
                    Console.WriteLine($"What is {salesPerson.Value}'s yearly earnings?");
                    isNumber = double.TryParse(Console.ReadLine(), out earned);
                } while (!isNumber);

                earnings.Add(earned);
            }

            double sum = 0;
            foreach (double earning in earnings)
            {
                sum += earning;
            }

            Console.WriteLine($"The average earnings are: {sum / salesPeople.Count} ");

            Console.ReadKey();
        }
    }
}
