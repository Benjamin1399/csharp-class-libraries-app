using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class ConsoleOperations
    {
        public static int GetIntInput(string message)
        {
            int number = 0;
            string input = "";

            bool isIntValid = false;

            do
            {
                Console.Write(message);
                input = Console.ReadLine();

                isIntValid = int.TryParse(input, out number);

            } while (isIntValid == false);

            return number;
        }

        public static string GetStringInput(string message)
        {
            string text = "";

            Console.Write(message);
            text = Console.ReadLine();

            return text;

        }
    }
}
