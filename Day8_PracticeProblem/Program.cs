using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_PracticeProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MatchingString matchingString = new MatchingString();
            matchingString.MethodString();

            SequenceMatching sequenceMatching = new SequenceMatching();
            sequenceMatching.MethodSequence();
            Console.ReadLine();
        }
    }
}
