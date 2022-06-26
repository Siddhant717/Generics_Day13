using System;

namespace GenericsPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find maximum number");
            int answer = MaximumNumberCheck.MaximumIntegerNumber(223, 323, 443);                    
            Console.WriteLine(answer);
        }
    }
}
