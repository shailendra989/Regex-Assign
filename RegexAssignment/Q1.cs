using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssignment
{
    internal class Q1
    {

         public static void Matches()
        {
            string input = "abbb"; // change this to test different strings

            Regex regex = new Regex(@"a[b]{2,3}");
            Match match = regex.Match(input);

            if (match.Success)
            {
                Console.WriteLine("Match found: " + match.Value);
            }
            else
            {
                Console.WriteLine("No match found.");
            }
        }
    }
}
