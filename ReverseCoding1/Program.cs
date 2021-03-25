using System;

namespace ReverseCoding1
{
    public class Program
    {
        // https://edabit.com/challenge/bqveyPRgcWZM7XzMQ
        // SOLVED

        static void Main(string[] args)
        {
            CodeReverser codeReverser = new("A4B5C2"); // "A4B5C2" ➞ "AAAABBBBBCC"
            codeReverser.CharToIntArray();
            codeReverser.CharToNewString();
            Console.WriteLine(codeReverser.MultiplyCharsByInts());
        }
    }
}
