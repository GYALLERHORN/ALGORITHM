using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_002
{
    internal class ArrayOfGapX
    {
        public long[] solution(long x, int n)
        {
            long[] answer;
            answer = new long[n];
            int i = 0;
            long y = x;
                while (i < n)
                {
                    answer[i++] = x;
                    x = x + y;
                }
            return answer;
        }
    }
}
