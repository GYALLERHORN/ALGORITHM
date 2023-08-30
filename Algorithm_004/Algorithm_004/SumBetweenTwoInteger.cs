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
            int fixeda = a;

            long answer = 0;
            int i = 0;
            long sum = 0;
            while (i <= Math.Abs(fixeda - b))
            {
                sum += a;

                if (a != b)
                {
                    if (a - b < 0)
                    {
                        a += (a - b) / (a - b); // 틀렸음
                    }
                    else
                    {
                        a -= (a - b) / (a - b);
                    }
                }

                i++;
            }

            answer = sum;

            return answer;
        }
    }
}
