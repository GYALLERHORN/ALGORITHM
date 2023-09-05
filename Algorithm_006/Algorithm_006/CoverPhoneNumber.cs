using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_006
{
    public class Solution3
    {
        
        public string solution(string phone_number)
        {
            string answer = "";

            answer = phone_number.Substring(phone_number.Length - 4); // 일단 answer에 전화번호의 뒷 4자리만 할당한다.
            answer = answer.PadLeft(phone_number.Length, '*'); // answer의 문자열 길이를 전화번호 길이만큼 자리를 두고 빈 인덱스에는 *를 넣는다.

            return answer;
        }
    }
}
