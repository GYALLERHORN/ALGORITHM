using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_003
{
    public class _010Solution
    {
        public static long solution(long n) // 조금만 더 배열 관련 함수를 알았더라면.. 이렇게 길어지지 않았겠지?
        {
            int length = n.ToString().Length;
            long[] arr = new long[length];
            for (int i = 0; i < length; i++)
            {
                long j = n % 10;
                n /= 10;
                arr[i] = j;
            } // 매개변수를 배열로 바꾸는 과정

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        long temp = arr[i];
                        arr[i]= arr[j];
                        arr[j]= temp;
                    }
                }
            } // 배열의 요소들을 내림차순으로 바꾸는 과정 136389 316389 613389 613389 813369 913368 / 931368 931368 961338 981336 / 983136 983136 986133 / 986313 986313/ 986331 완성!

            long answer = 0;

            for (int i = 1; i <= length; i++)
            {
                answer += arr[i - 1] * (long)Math.Pow(10, length - i);
            } // 각 배열 요소들에 맞게 10의 n제곱 후 answer에 추가

            return answer;
        }
    }
}
