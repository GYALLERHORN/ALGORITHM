using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_007
{
    public class _018_NotExistNUmberAddition
    {
        public int solution(int[] numbers)
        {
            int answer = 45;
            foreach (int n in numbers)
            {
                answer -= n;
            }
            return answer;
        }
    }
}
