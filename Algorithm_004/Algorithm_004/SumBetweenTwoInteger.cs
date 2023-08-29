using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_004
{
    public class Solution1
    {
        public long solution(int a, int b)
        {
            if (a == b)
            {
                return a;
            }

            long answer = 0;
            int i = 0;
            int sum = 0;
            while (i <= Math.Abs(a - b))
            {
                sum += a;
                a += Math.Abs(a - b) / (a - b); // 틀렸음

                i++;
            }
            answer = sum;

            return answer;
        }
    }
}
