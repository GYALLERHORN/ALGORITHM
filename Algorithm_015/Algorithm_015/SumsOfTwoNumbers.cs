namespace Algorithm_015
{
    public class SumsOfTwoNumbers
    {
        public int[] solution(int[] numbers)
        {
            int[] answer = new int[] { };
            
            List<int> tempArr = new List<int>();

            // 더하고
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
            // 담고
                    tempArr.Add(numbers[i] + numbers[j]);
                }
            }
            // .Contains(sum) 이라는 함수가 있다. 해당 배열에 sum이라는 요소가 포함되어 있는지 논리판단한다. 이 함수로 중복확인 과정을 간소화할 수 있다.

            // 오름차순 정렬하기
            tempArr = tempArr.OrderBy(x => x).ToList();

            // 중복확인하고
            answer = tempArr.Distinct().ToArray();
            
            return answer;
        }
    }
}
