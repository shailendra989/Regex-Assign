using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssignment
{
     public class Q4
    {
         public static void OccPattern()
        {
            string pattern = @"fox(es)?";
            string s = @"foxes are omnivorous mammals belonging to several genera
                     of the family Canidae fox.";
            Regex regex = new Regex(pattern);
            int count = regex.Matches(s).Count;
            Console.WriteLine("There are {0} occurrences.", count);
        }
    }
}
