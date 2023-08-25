using System;

namespace Algorithm_002
{
    public class Operate
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Operating Code");

            FindRemainder findRemainder = new FindRemainder();
            ArrayOfGapX arrayOfGapX = new ArrayOfGapX();

            int a = findRemainder.solution(7);

            // Console.WriteLine(a);

            long[] items = arrayOfGapX.solution(10000000,1000);
            foreach (long i in items)
            {
                Console.WriteLine(i);
            }
        }
    }
}