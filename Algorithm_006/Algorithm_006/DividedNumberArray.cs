using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_006
{
    public class DividedNumberArray
    {
        public int[] solution(int[] arr, int divisor)
        {
            int[] answer;
            List<int> result = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % divisor == 0)
                {
                    result.Add(arr[i]);
                }
            }
            if (result.Count == 0)
            {
                result.Add(-1);
            }
            answer = result.ToArray();

            for (int i = 0; i < answer.Length - 1; i++)
            {
                for (int j = i+1; j < answer.Length; j++)
                {
                    if (answer[i] > answer[j])
                    {
                        int temp = answer[i];
                        answer[i] = answer[j];
                        answer[j] = temp;
                    }
                }
            }
            return answer;
        }
    }
}
