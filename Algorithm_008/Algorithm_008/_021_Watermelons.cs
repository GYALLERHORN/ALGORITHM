using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_008
{
    public class _021_Watermelons
    {
        public string solution(int n)
        {
            StringBuilder sb = new StringBuilder();
            string answer = "";
            for (int i = 0; i < n/2; i++)
            {
                sb.Append("수박");
            }
            if (n % 2 == 1)
            {
                sb.Append("수");
            }
            answer = sb.ToString();
            return answer;
        }
    }
}
