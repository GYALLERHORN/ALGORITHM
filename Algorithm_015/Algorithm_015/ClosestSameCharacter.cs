namespace Algorithm_015
{
    public class ClosestSameCharacter
    {
        public int[] solution(string s)
        {
            int[] answer = new int[s.Length]; // s길이만큼 공간 배졍

            int index = -1;

            for (int i = 0; i < s.Length; i++) // s길이만큼 반복
            {
                index = -1;
                for (int j = i - 1; j >= 0; j--) // i번째 반복중일 때, i부터 0까지 감소하며 반복. i = 0일때는 반복하지 못한다. 이 코드 때문에 "가장 가까운"이 가능하다.
                {
                    if (s[j] == s[i]) // j번째 요소와 i번째 요소가 같다면
                    {
                        index = i - j; // index는 두 인덱스 간 간격의 차다.
                        break; // j가 더 감소하면서 또다른 동일 요소를 찾지 못하도록 break
                    }
                }
                answer[i] = index; // answer에 0번째 인덱스부터 순서대로 배정한다.
            }
            return answer;
        }
    }
}
