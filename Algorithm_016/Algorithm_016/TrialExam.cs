using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm_016
{
    public class TrialExam
    {
        public int[] solution(int[] problemAnswers)
        {
            int[] scores = new int[] { 0, 0, 0 }; // 각 응시자의 점수

            int[][] examineePatterns = new int[][] // 응시자의 찍기 패턴
            {
                new int []{ 1, 2, 3, 4, 5 },
                new int []{ 2, 1, 2, 3, 2, 4, 2, 5 },
                new int []{ 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 }
            };

            int[] examineeTrialIndexes = new int[] { 0, 0, 0 }; // 응시자의 찍기 패턴 번호

            int problemIndex = 0; // 문제 번호

            while (problemIndex < problemAnswers.Length) // 주어진 문제 수만큼 반복
            {
                for (int i = 0; i < scores.Length; i++) // 응시자 수만큼 반복
                {
                    if (examineeTrialIndexes[i] == examineePatterns[i].Length) // 응시자가 찍는 번호가 패턴의 끝에 왔으면
                    {
                        examineeTrialIndexes[i] = 0; // 다시 번호를 0으로 돌려서 패턴의 처음부터 찍도록 한다.
                    }
                    if (examineePatterns[i][examineeTrialIndexes[i]] == problemAnswers[problemIndex]) // 찍은 번호가 정답이면
                    {
                        scores[i]++; // 점수 +1
                    }
                    examineeTrialIndexes[i]++; // 다음 찍기 번호
                }
                problemIndex++;
            }

            int highestScore = scores.Max(); // 점수 최댓값
            var rankerList = new List<int>(); // 최고 득점자 그룹

            for (int i = 0; i < scores.Length; i++) // 응시자 수만큼 반복
            {
                if (scores[i] == highestScore) // 응시자 점수가 최고점이면
                {
                    rankerList.Add(i + 1); // 그룹에 추가
                }
            }

            return rankerList.ToArray();
        }
    }
}