namespace Algorithm_015
{
    public class StringWihNUmberandWord
    {
        public int solution(string s)
        {
            int answer = 0;

            string[] wordArr = new string[10] { "zero", "one", "two","three", "four", "five", 
                "six", "seven", "eight", "nine" };

            for (int i = 0; i < wordArr.GetLength(0); i++) // 0~9 반복
            {
                s = s.Replace(wordArr[i], i.ToString()); // 영단어가 있으면 교체
            }
            answer = int.Parse(s);
            return answer;
        }
    }
}
