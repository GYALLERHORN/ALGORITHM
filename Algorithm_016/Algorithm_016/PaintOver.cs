using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_016
{
    internal class PaintOver
    {
        public int solution(int n, int m, int[] section)
        {
            int answer = 0;

            int paintPosition = 0; // 0부터 시작하는 것에 대한 의미를 다르게 받아들여야 한다.
            for (int i = 0; i < section.Length; i++)
            {
                if (paintPosition < section[i])
                {
                    paintPosition = section[i] + (m - 1);
                    answer++;
                }
            }
            return answer;
        }
    }
}
