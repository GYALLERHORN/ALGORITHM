using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_001
{
    internal class Average
    {
        public class Solution
        {
            public double solution(int[] arr)
            {
                double answer = 0;
                double total = 0; // arr의 모든 원소를 다 더할 값 total
                for (int i = 0; i < arr.Length; i++) // arr 길이만큼 반복하며
                {
                    total += arr[i]; // total에 arr의 첫번째 원소부터 다 더하고
                }
                answer = total / arr.Length; // 다 더한 값을 arr길이만큼 나눈다.
                return answer;
            } // ?? 이게 아무래도 최선인데?
             // 아니 배열형 변수 내장 메서드에 Average()가 있었네..ㅡㅡ
        }
    }
}
