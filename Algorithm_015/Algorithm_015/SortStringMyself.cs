using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_015
{
    public class SortStringMyself
    {
        public string[] solution(string[] strings, int n)
        {
            string[] answer = new string[] { };

            answer = strings.OrderBy(item => item[n]).ThenBy(item => item).ToArray();

            return answer;
        }
    }
}
