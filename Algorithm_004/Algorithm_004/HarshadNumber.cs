using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_004
{
    public class Solution
    {
        public bool solution(int x)
        {
            int y = x;
            int remainderSum = 0;
            while (true)
            {
                remainderSum += x % 10;
                Console.WriteLine(remainderSum);
                if (x < 10)
                {
                    break;
                }
                x /= 10;
            }

            bool answer = false;
            if (y % remainderSum == 0)
            {
                answer = true;
            }
            Console.WriteLine(y);
            Console.WriteLine(remainderSum);
            return answer;
        }
    }
}
