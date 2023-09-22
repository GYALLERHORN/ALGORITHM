using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm_015
{
    public class SortStringMyself
    {
        public string[] solution(string[] strings, int n)
        {
            string[] answer = new string[] { };

            answer = strings.OrderBy(item => item[n]).ThenBy(item => item).ToArray();
            // OrderBy한 틀 안에서 ThenBy(새로운 기준으로 다시한번 오름차순 정렬)한다.
            // OrderBy([정렬 대상] => [정렬 방법(기준?)])
            return answer;
        }
    }
}
