using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssignment
{

    class Q2
    {
         public  static void LowerCase()
        {
            string input = "This_is_a_test_string_with_lowercase_letters_joined_by_underscores";
            string pattern = @"[a-z]+(_[a-z]+)*";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
