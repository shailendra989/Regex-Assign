using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssignment
{
    internal class Q3

    {
        public static void FindTag()
        {
            string input = "<p>The <code>Regex</code> is a compiled representation of a regular expression.</p>";
            Regex regex = new Regex("<[^>]+>");
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
