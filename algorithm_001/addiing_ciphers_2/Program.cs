namespace algorithm_001
{
    internal class Adding_Ciphers
    {
        //123을 각 자릿수 숫자를 다 더한 값 : 1 + 2 + 3 = 6 어떻게 하지?
        public class Solution
        {
            public int Main(int n)
            {
                string[] ciphers = n.ToString().Split("");
                int answer = 0;
                for (int i = 0; i < ciphers.Length; i++)
                {
                    answer += int.Parse(ciphers[i]);
                }
                return answer;
            }
        }
    }
}