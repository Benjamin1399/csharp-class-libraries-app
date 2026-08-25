using PersonLibrary;
using PersonLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            string firstName = ConsoleOperations.GetStringInput("Enter first name: ");
            string lastName = ConsoleOperations.GetStringInput("Enter last name: ");

            int yearBorn = ConsoleOperations.GetIntInput("Enter your birth year: ");

            int age = PersonCalculations.CalculateAge(yearBorn);

            person.FirstName = firstName;
            person.LastName = lastName;
            person.Age = age;

            Console.WriteLine($"You are {person.FirstName} {person.LastName} and you are {person.Age} years old.");

            Console.ReadLine();
        }
    }
}
