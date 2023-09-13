namespace Algorithm_010
{
    public class StringBasic
    {
        public bool solution(string s)
        {
            bool answer = false;

            if (s.Length == 4 || s.Length == 6)
            {
                answer = int.TryParse(s, out int i);
            }
            return answer;
        }
    }
}
