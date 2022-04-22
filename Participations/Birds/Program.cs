//Participation 13.2 - Birds Classes
using System;
using System.Collections.Generic;

namespace Birds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Penguin penguin1 = new Penguin();
            Penguin penguin2 = new Penguin();
            List<Penguin> penguins = new List<Penguin>();
            penguins.Add(penguin1);
            penguins.Add(penguin2);
            
            Robin robin1 = new Robin();
            Robin robin2 = new Robin();
            List<Robin> robins = new List<Robin>();
            robins.Add(robin1);
            robins.Add(robin2);

            foreach (Penguin penguin in penguins)
            {
                foreach (var prop in penguin.GetType().GetProperties())
                {
                    Console.WriteLine($"What is penguin {penguins.IndexOf(penguin) + 1}'s {prop.Name}?");
                    if (prop.Name == "EggCount")
                    {

                    }
                    if (prop.PropertyType == typeof(string))
                    {
                        prop.SetValue(penguin, Console.ReadLine());
                    }
                    else if (prop.PropertyType == typeof(int))
                    {
                        prop.SetValue(penguin, Convert.ToInt32(Console.ReadLine()));
                    }
                    else if (prop.PropertyType == typeof(double))
                    {
                        prop.SetValue(penguin, Convert.ToDouble(Console.ReadLine()));
                    }
                    else if (prop.PropertyType == typeof(bool))
                    {
                        Console.WriteLine("Is it a male? True or false");
                        prop.SetValue(penguin, Convert.ToBoolean(Console.ReadLine()));
                        if (penguin.Gender == false)
                        {
                            penguin.LayEggs(1);
                        }
                    }
                }
            }
            
            Console.WriteLine($"Under water minutes for this penguin: {penguin1.CalculateUnderwater()}");
            Console.WriteLine($"The number of eggs for this penguin: {penguin1.GetEggs(penguin1.Gender)}");
            Console.WriteLine($"Under water minutes for this penguin: {penguin2.CalculateUnderwater()}");
            Console.WriteLine($"The number of eggs for this penguin: {penguin2.GetEggs(penguin2.Gender)}");


            foreach (Robin robin in robins)
            {
                foreach (var prop in robin.GetType().GetProperties())
                {
                    Console.WriteLine($"What is robin {robins.IndexOf(robin) + 1}'s {prop.Name}?");
                    if (prop.PropertyType == typeof(string))
                    {
                        prop.SetValue(robin, Console.ReadLine());
                    }
                    else if (prop.PropertyType == typeof(int))
                    {
                        prop.SetValue(robin, Convert.ToInt32(Console.ReadLine()));
                    }
                    else if (prop.PropertyType == typeof(double))
                    {
                        prop.SetValue(robin, Convert.ToDouble(Console.ReadLine()));
                    }
                    else if (prop.PropertyType == typeof(bool))
                    {
                        Console.WriteLine("Is it a male? True or false");
                        prop.SetValue(robin, Convert.ToBoolean(Console.ReadLine()));
                    }
                }
            }
            
        }
    }
}
