using System.Text;

namespace Algorithm_014
{
    public class CaesarCipher
    {
        public string solution(string s, int n) // ASCII코드로 해결
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in s) // s의 문자 c를 하나씩 가져와서
            {
                char temp = c; // 반복변수에는 할당 못하니 임시temp에 할당하고
                if (c != 32) // c가 공백일 경우를 제외한 상태에서
                {
                    temp = (char)((int)temp + n); // temp에 형변환을 거쳐 n을 더한다. 
                    if ((char.IsUpper(c) && temp > 90) || (char.IsLower(c) && temp > 122)) // c=대문자 && temp가 Z를 넘어감 || c=소문자 && temp가 z를 넘어감 이면
                    {
                        temp = (char)((int)temp - 26); // temp에 형변환을 거쳐 26을 뺀다.
                    }
                }
                sb.Append(temp); // 그렇게 나온 temp를 차곡차곡 모은다.
            }

            string answer = sb.ToString();

            return answer;
        }
    }
}
