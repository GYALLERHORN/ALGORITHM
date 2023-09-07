using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_008
{
    public class CountofAliquotAndSum
    {
        public int solution(int left, int right)
        {
            int answer = 0;

            for (int i = left; i <= right; i++)
            {
                int aliquotCount = 0;
                if ((float)Math.Sqrt(i) % 1f == 0f)
                {
                    aliquotCount++;
                }
                for (int j = 1; j < Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        aliquotCount += 2;
                    }
                }
                if (aliquotCount % 2 == 0)
                {
                    answer += i;
                }
                else
                {
                    answer -= i;
                }
            }
            return answer;
        }
    }
}
