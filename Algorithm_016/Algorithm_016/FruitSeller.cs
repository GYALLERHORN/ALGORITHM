using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm_016
{
    public class FruitSeller
    {
        public int solution(int k, int m, int[] score)
        {
            int answer = 0;

            score = score.OrderByDescending(x => x).ToArray();
            Queue<int> fruitsList = new Queue<int>();
            foreach (var fruit in score) // 우선 높은 점수 과일을 빼갈 수 있도록 준비
            {
                fruitsList.Enqueue(fruit);
            }

            List<int> fruitsBox = new List<int>(); // 과일을 담을 상자

            for (int i = 0; i < score.Length; i++) // 갖고 있는 과일 갯수 만큼 반복
            {
                fruitsBox.Add(fruitsList.Dequeue()); // 점수 큰 순대로 나열된 과일들 중 높은 점수 순대로 빼서 상자에 담고
                if (fruitsBox.Count == m) // 상자가 꽉 차면
                {
                    answer += fruitsBox.Min() * m; // 그 상자의 점수를 매겨서 answer에 가산하고
                    fruitsBox.Clear(); // 상자 비우기
                }
            }

            return answer;
        }
    }
}
