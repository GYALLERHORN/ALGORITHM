using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm_016
{
    internal class HallOfHonor
    {
        public int[] solution(int k, int[] score)
        {
            var answer = new List<int>();
            var hOH = new List<int>(); // k개 한정으로 넣을 명예의 전당

            for (int i = 0; i < score.Length; i++)
            {
                hOH.Add(score[i]); // i일차 점수 추가
                hOH = hOH.OrderByDescending(o => o).Take(k).ToList(); // hOH 내림차순 정렬=>0~k번째 인덱스까지만 챙겨서 할당
                int lowestScore = hOH.Min(); // hOH 내 최솟값
                answer.Add(lowestScore);
            }

            return answer.ToArray();
        }
    }
}
