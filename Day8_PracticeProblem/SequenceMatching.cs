using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day8_PracticeProblem
{
    public class SequenceMatching
    {
        public void MethodSequence()
        {
            string input1 = "hello_world";    // Match
            string input2 = "helloWorld";     // No match
            string input3 = "hello_World";    // No match
            string input4 = "hello__world";   // No match
            string input5 = "mansi_mohan";   // Match
            string input6 = "Mansi_Mohan";   // No match

            string pattern = @"[a-z]+(_[a-z]+)+";

            Console.WriteLine("Matching pattern: " + pattern);
            Console.WriteLine();

            MatchString(input1, pattern);
            MatchString(input2, pattern);
            MatchString(input3, pattern);
            MatchString(input4, pattern);
            MatchString(input5, pattern);
            MatchString(input6, pattern);
        }

        public static void MatchString(string input, string pattern)
        {
            bool isMatch = Regex.IsMatch(input, pattern);

            Console.WriteLine("Input: " + input);
            Console.WriteLine("Match: " + isMatch);
            Console.WriteLine();
        }
    }
}
