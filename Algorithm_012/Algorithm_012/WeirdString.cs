using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_012
{
    public class WeirdString
    {
        public string solution(string s)
        {
            string answer = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                answer += i % 2 == 0 ? char.ToUpper(s[i]) : char.ToLower(s[i]);
            }
            return answer;
        }
    }
}
