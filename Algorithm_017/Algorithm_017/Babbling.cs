using System;

namespace Algorithm_017
{
    public class Babbling
    {
        public int solution(string[] babbling)
        {
            int answer = 0;

            string[] pronuns = new string[4] { "aya", "ye", "woo", "ma" };

            for (int bab = 0; bab < babbling.Length; bab++)
            {
                for (int i = 0; i < pronuns.Length; i++)
                {
                    string cantSpeak = pronuns[i] + pronuns[i];

                    if (babbling[bab].Contains(cantSpeak))
                    {
                        babbling[bab] = "X";
                        continue;
                    }

                    babbling[bab] = babbling[bab].Replace(pronuns[i], "O");
                }

                foreach (char c in babbling[bab])
                {
                    if (c != 'O')
                    {
                        babbling[bab] = "X";
                        continue;
                    }
                }
                if (babbling[bab].Contains("O")) answer++;
            }
            return answer;
        }
    }
}
