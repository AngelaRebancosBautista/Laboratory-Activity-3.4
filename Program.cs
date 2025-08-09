using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> birthYearInputs = new List<string>();
            List<int> birthYears = new List<int>();
            int currentYear = DateTime.Now.Year;

            Console.WriteLine("Enter 5 birth years");
            for (int i = 0; i < 5; i++)
            {
                bool isValid = false;
                while (!isValid)
                {
                    Console.Write($"Person {i + 1} birth year: ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int year) &&
                        year > 1900 &&
                        year <= currentYear)
                    {
                        birthYears.Add(year);
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid year between 1902 and current year.");
                    }
                }
            }
            Console.WriteLine("\nAge Classification:");
            foreach (int birthYear in birthYears)
            {
                int age = currentYear - birthYear;
                string classification;
                if (age < 18)
                {
                    classification = "Minor";
                }
                else if (age >= 18 && age < 65)
                {
                    classification = "Adult";
                }
                else
                {
                    classification = "Senior";
                }
                Console.WriteLine($"{birthYear}: Age {age} - {classification}");
            }
        }
    }
}
                
            
        


    

