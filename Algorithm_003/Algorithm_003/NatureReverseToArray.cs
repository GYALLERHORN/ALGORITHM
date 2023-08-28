using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_003
{
        public class _007Solution // 좀 맛있게 짰는데?
        {
        public static int[] solution(long n)
        {
            long length = n.ToString().Length; // 매개변수의 길이 (123 : 3)
            int[] answer = new int[length]; // 그 길이만큼 자리 만들어주고

            for (int i = 0; i < length; i++) // 그 길이동안
            {
                long m = n % 10; // 10나눈 나머지를
                answer[i] = (int)m; // i번째 자리에 할당한다.
                n = n / 10; // 1의 자리부터 한칸 씩 지우면서 반복
            }

            return answer;
        }

    }
}
