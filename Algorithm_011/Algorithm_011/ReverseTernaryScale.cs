using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_011
{
    public class ReverseTernaryScale
    {
        public int solution(int n)
        {
            StringBuilder ternaryStr = new StringBuilder();

            while (true)
            {
                ternaryStr.Append(n%3);
                n = n / 3;
                if (n < 3)
                {
                    ternaryStr.Append(n);
                    break;
                }
            }

            int answer = 0;

            string sbToStr = ternaryStr.ToString();

            //for (int i = 0; i <= sbToStr.Length -1; i++)
            //{
            //    answer += 1 * 3 ^ i * sbToStr[i];
            //}
            return answer;
        }
    }
}
