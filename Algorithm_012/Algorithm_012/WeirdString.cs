namespace Algorithm_012
{
    public class WeirdString
    {
        public string solution(string s) // 문제 이해하는데 한참걸렸네 (나쁜말)
        {
            string answer = string.Empty;

            string[] splitArr = s.Split(' ');

            for (int i = 0; i < splitArr.Length; i++)
            {
                for (int j = 0; j < splitArr[i].Length; j++)
                {
                    answer += j % 2 == 0 ? char.ToUpper(splitArr[i][j]) : char.ToLower(splitArr[i][j]);
                }
                if (i < splitArr.Length - 2)
                {
                    answer += " ";
                }
            }
            return answer;
        }
    }
}
