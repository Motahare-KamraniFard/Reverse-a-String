using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_a_String.Logic
{
    public static class ReverseString
    {
        public static string Reverse(string input)
        {

            // This method reverses a string using a List<char>.
            // It converts the string to a char array, reverses the array,
            // and then converts it back to a string.
            // Finally, it returns the reversed string.
            if (string.IsNullOrWhiteSpace(input))
                Console.WriteLine("Input string cannot be null, empty, or whitespace.");

            List<char> charList = new List<char>(input.ToCharArray());
            charList.Reverse();
            return new string(charList.ToArray());

        }
    }
}
