using System;

namespace GenericsPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find maximum number-");
            int answer = MaximumNumberCheck.MaximumIntegerNumber(220, 320, 440);
            Console.WriteLine(answer);
        }
    }
}
