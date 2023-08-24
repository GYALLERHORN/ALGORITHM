using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_001
{
    internal class Adding_Ciphers
    {
        //123을 각 자릿수 숫자를 다 더한 값 : 1 + 2 + 3 = 6 어떻게 하지?
        public class Solution
        {
            public int solution(int n)
            {
                char[] ciphers = n.ToString().ToCharArray();
                // ToArray는 기존의 배열(컬랙션)을 새로운 배열로 복사한다.
                // 그래서 ToString()으로 만든 문자열을 배열화하는 방법으로는 ToCharArray()가 맞다.
                int answer = 0;
                for (int i = 0; i < ciphers.Length; i++)
                {
                    int a = int.Parse(ciphers[i].ToString());
                    answer += a;
                }
                return answer;
            }
        }
    }
}
