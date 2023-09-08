using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_009
{
    public class DescendingString
    {
        public string solution(string s) // 그냥 문자 하나하나를 char로 따고 그걸 ASCII 10진법으로 바꾸면..?
        {
            List<char> sArray = new List<char>();

            foreach (char c in s)
            {
                sArray.Add(c);
            }
            var arr = from c in sArray
                      orderby c 




            string answer = "";
            return answer;
        }
    }
}
