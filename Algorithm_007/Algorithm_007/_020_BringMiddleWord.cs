using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_007
{
    public class _020_BringMiddleWord
    {
        public string solution(string s)
        {
            string answer = "";


            if (s.Length % 2 == 1)
            {
                answer = s[s.Length / 2].ToString();
            }
            else
            {
                answer = s[s.Length / 2 - 1].ToString();
                answer += s[s.Length / 2].ToString(); 
            }

            return answer;
        }
    }
}
