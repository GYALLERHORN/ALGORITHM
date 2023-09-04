using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_006
{
    public class Operator
    {
        static void Main(string[] args)
        {
            //DividedNumberArray divided = new DividedNumberArray();
            //int[] ints = new int[] { 2, 7, 8, 4,5,6,30,12};
            //ints = divided.solution(ints, 11);
            //foreach (int i in ints)
            //{
            //    Console.WriteLine(i);
            //}

            string s = "1234567890";
            string s1 = s.Substring(s.Length - 5, 4);
            Console.WriteLine(s1);
            Solution3 solution3 = new Solution3();
            string ans = solution3.solution("673426234f");
            Console.WriteLine(ans);
        }
    }
}
