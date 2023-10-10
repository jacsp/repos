using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions
{
    public static class Extensions
    {
        // Needs to be a static class
        // Even thoguh it doesn't take any parameter, it still needs to know that it extends the string class
        public static string Capitalize(this string input)
        {
            // Handle strings that are null or empty
            if (string.IsNullOrEmpty(input)) return input;

            // Convert to upper case. Since strings are just arrays of characters
            // we can just use ToUpper() on the first index of the string
            // and then concatenate with the rest of the string
            return char.ToUpper(input[0]) + input.Substring(1);
        }
    }
}
