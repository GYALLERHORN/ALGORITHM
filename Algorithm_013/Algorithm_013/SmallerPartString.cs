namespace Algorithm_013
{
    public class SmallerPartString
    {
        public int solution(string t, string p)
        {
            int answer = 0;

            for (int i = 0; i < t.Length - (p.Length - 1); i++) // p의 길이를 감안해서 t에서 뽑아낼 문자열 개수를 이렇게 계산했다.
            {
                string str = t.Substring(i, p.Length);
                answer += long.Parse(str) <= long.Parse(p) ? 1 : 0;
            }
            return answer;
        }
    }
}
