using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_009
{
    public class _024_DescendingString
    {
        public string solution(string s) // 그냥 문자 하나하나를 char로 따고 그걸 ASCII 10진법으로 바꾸면..?
        {
            List<char> sArray = new List<char>(); // 그냥 LINQ랑 stringBuilder를 썼다는 점에 의미를 둔다

            foreach (char c in s)
            {
                sArray.Add(c);
            }
            var arr = from c in sArray
                      orderby c descending
                      select c;

            StringBuilder sb = new StringBuilder();
            foreach (char c in arr)
            {
                sb.Append(c);
            }

            string answer = sb.ToString();
            return answer;
        }
    }
}
