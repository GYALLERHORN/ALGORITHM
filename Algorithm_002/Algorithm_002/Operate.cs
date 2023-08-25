using System;

namespace Algorithm_002
{
    public class Operate
    {
        static void Main(string[] args)
        {
            FindRemainder findRemainder = new FindRemainder();
            Console.WriteLine(" Operating Code");

            int a = findRemainder.solution(7);
            int b = findRemainder.solution(344);
            int c = findRemainder.solution(5712);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}