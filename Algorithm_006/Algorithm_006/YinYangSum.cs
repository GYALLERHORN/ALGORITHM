using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_006
{
    public class Solution2
    {
        public int solution(int[] absolutes, bool[] signs)
        {
            int answer = 0;

            for (int i = 0; i < signs.Length; i++)
            {
                if (signs[i])
                {
                    answer += absolutes[i];
                }
                else
                {
                    answer -= absolutes[i];
                }
            }
            return answer;
        }
    }
}
