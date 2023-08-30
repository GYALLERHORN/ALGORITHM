using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_004
{
    public class Operator
    {
        static void Main(string[] args)
        {
            //Solution s = new Solution();
            //bool b = s.solution(12);
            //Console.WriteLine(b);

            Solution1 s = new Solution1();
            long i = s.solution(-10000000,-9999970);
            Console.WriteLine(i);
        }
    }

}
