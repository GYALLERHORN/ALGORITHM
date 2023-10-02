using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_016
{
    internal class CardBundle
    {
        public string solution(string[] cards1, string[] cards2, string[] goal)
        {
            string answer = "Yes";

            // 각 배열의 요소를 순서대로 비교하고, 하나라도 다른 순간 바로 No반환

            int cards1card = 0;
            int cards2card = 0;

            for (int i = 0; i < goal.Length; i++)
            {
                if (cards1card < cards1.Length && cards1[cards1card] == goal[i])
                {
                    cards1card++;
                    continue;
                }
                else if (cards2card < cards2.Length && cards2[cards1card] == goal[i])
                {
                    cards2card++;
                    continue;
                }
                else
                {
                    return "No";
                }
            }

            return answer;
        }
    }
}
