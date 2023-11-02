using System;

namespace Algorithm_017
{
    public class Babbling
    {
        public int solution(string[] babbling)
        {
            int answer = 0;

            string[] pronuns = new string[4] { "aya", "ye", "woo", "ma" }; // 옹알이 가능한 발음

            for (int bab = 0; bab < babbling.Length; bab++) // 확인 대상 단어 한개씩 순회
            {
                for (int i = 0; i < pronuns.Length; i++)
                {
                    string cantSpeak = pronuns[i] + pronuns[i]; 

                    if (babbling[bab].Contains(cantSpeak)) // 옹알이 발음이 연속된 단어가 2개 연속된 경우
                    {
                        babbling[bab] = "X"; // 대상에서 제외 => 값을 X로 전환
                        continue;
                    }

                    babbling[bab] = babbling[bab].Replace(pronuns[i], "O"); // 발음 가능한 부분이 있는 경우, 그 부분을 O로 전환
                }

                foreach (char c in babbling[bab]) // 대상 언어를 알파벳 한개씩 나눠서 순회
                {
                    if (c != 'O') // 알파벳 중 O이 아닌 알파벳이 있을 경우(발음 가능한 단어 외의 요소가 있는 경우)
                    {
                        babbling[bab] = "X"; // 대상에서 제외 => 값을 X로 전환
                        continue;
                    }
                }
                if (babbling[bab].Contains("O")) answer++; // 위 과정을 거치면 순수하게 O만 포함한 단어를 찾을 수 있다.
            }
            return answer;
        }
    }
}
