using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_007
{
    public  class _019_RemoveMinimum
    {
        public int[] solution(int[] arr)
        {
            List<int> answer = new List<int>();

            foreach (int i in arr)
            {
                answer.Add(i);
            }
            answer.Remove(arr.Min());

            if (arr.Length <= 1)
            {
                answer.Add(-1);
            }
            return answer.ToArray();
        }
    }
}
