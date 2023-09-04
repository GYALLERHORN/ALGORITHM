using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_006
{
    public class Solution3
    {
        
        public string solution(string phone_number)
        {
            string answer = "";

            for (int i = 0; i < phone_number.Length; i++)
            {
                if (i < phone_number.Length - 4)
                {
                    answer += "*";
                }
                else
                {
                answer += phone_number[i];
                }
            }
            return answer;
        }
    }
}
