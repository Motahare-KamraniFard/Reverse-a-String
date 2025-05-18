using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Reverse_a_String.Logic;

namespace Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This program reverses a string entered by the user.
            // It uses a List<char> to store the characters of the string,
            // then reverses the list and converts it back to a string.
            // Finally, it prints the reversed string to the console.
            // The program is written in C# and uses the .NET framework.
            // The program is designed to be run in a console application.
            // The program is simple and easy to understand, making it a good example for beginners.
            do
            {
                Console.WriteLine("Do you want to reverse a string? (y/n)");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "y")
                {
                    Console.WriteLine("enter a string to reverse:");
                    string input = Console.ReadLine();
                    string result = ReverseString.Reverse(input);
                    Console.WriteLine($"Reversed string: {result}");
                }
                else if (answer.ToLower() == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                }
            } while (true);

        }
    }
}
