using System;

namespace Algorithm_017
{
    internal class LottoPrizes
    {
        public int[] solution(int[] lottos, int[] win_nums)
        {
            int[] answer = new int[2] {7,7 }; // 우선 최고,최저 순위를 7,7로 한다. 한개 맞거나 다 틀리는 경우 둘 다 6등이기 때문

            for (int i = 0; i < lottos.Length; i++) // 6번 돈다
            {
                if (lottos[i] == 0) // 로또번호가 0이면
                {
                    answer[0]--; // 정답일 가능성이 있는 번호다. 최고등수에서 1빼고
                    continue; // 어차피 써넣은 번호가 0이니 밑의 반복문에는 접근할 필요도 없다. 
                }
                for (int j = 0; j < win_nums.Length; j++) // 6번 돈다.
                {
                    if (lottos[i] == win_nums[j]) // 로또번호와 정답번호가 같으면
                    {
                        answer[0]--; // 최고등수도 하나 오르고
                        answer[1]--; // 최저등수도 하나 오른다.
                    }
                }
            }

            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] == 7) answer[i] = 6; // 최고(최저)등수가 7이라면 그건 6등을 의미한다.
            }

            return answer;
        }
    }
}
