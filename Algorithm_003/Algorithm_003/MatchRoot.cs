using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_003
{
    public class _9Solution
    {
        public static long solution(long n)
        {
            double root = Math.Sqrt(n); // 매개변수의 제곱근을 구한다. 유리수형의 수가 나올 수 있다.

            long answer = 0;

            if (root % 1 == 0) // root를 정수라고 할 수 있다면?
            {
                answer = ((long)root + 1) * ((long)root + 1); // answer는 root+1의 제곱이다.
            }
            else
            {
                answer = -1; // 아니면 -1이고
            }

            return answer;
        }
    }
}
