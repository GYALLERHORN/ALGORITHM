using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_003
{
    public class Operator
    {
        static void Main(string[] args)
        {
            int[] ans = _7Solution.solution(123);
            foreach (int i in ans)
            {
            Console.WriteLine(i);

            }

            long u = _9Solution.solution(10000);
            Console.WriteLine(u);
        }

    }
}