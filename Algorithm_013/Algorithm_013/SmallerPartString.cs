using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_013
{
    public class SmallerPartString
    {
        public int solution(string t, string p)
        {
            int answer = 0;

            for (int i = 0; i < t.Length - (p.Length - 1); i++)
            {
                string str = t.Substring(i, p.Length);
                answer += long.Parse(str) <= long.Parse(p) ? 1 : 0;
            }
            return answer;
        }
    }
}
