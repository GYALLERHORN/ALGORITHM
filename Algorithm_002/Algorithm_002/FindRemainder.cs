using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_002
{
    internal class FindRemainder
    {
        public int solution(int n)
        {
            int answer = 0;
            for (int i = n - 1; i > 1; i--)
            {
                if (n % i == 1)
                {
                    answer = i;
                }
            }
            return answer;
        }
    }
}
