using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_015
{
    public class FoodFight
    {
        public string solution(int[] food)
        {
            string answer = "";

            for (int i = 1; i < food.Length; i++) // 음식 갯수에 따라 왼쪽 푸파 선수의 음식을 순서대로 나열
            {
                int temp = food[i] / 2;
                for (int j = 0; j < temp; j++)
                {
                    answer += i;
                }
            }

            char[] chaArr = answer.ToCharArray();
            Array.Reverse(chaArr); // 오른쪽 음식은 왼쪽꺼 Reverse

            answer = answer + "0" + new string(chaArr); // 왼쪽꺼 + 물 + 오른쪽꺼

            return answer;
        }
    }
}
