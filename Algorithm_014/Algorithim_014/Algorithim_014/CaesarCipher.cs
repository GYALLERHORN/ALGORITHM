using System.Text;

namespace Algorithm_014
{
    public class CaesarCipher
    {
        public string solution(string s, int n)
        {

            StringBuilder sb = new StringBuilder();

            foreach (char c in s)
            {
                char temp = c;
                if (c != 32)
                {
                    temp = (char)((int)temp + n);
                    if ((char.IsUpper(c) && temp > 90) || (char.IsLower(c) && temp > 122))
                    {
                        temp = (char)((int)temp - 26);
                    }
                }
                sb.Append(temp);
            }

            string answer = sb.ToString();

            return answer;
        }
    }
}
