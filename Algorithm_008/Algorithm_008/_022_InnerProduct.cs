using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_008
{
    public class _022_InnerProduct
    {
        public int solution(int[] a, int[] b)
        {
            int answer = 0;
            for (int i = 0; i < a.Length; i++)
            {
                answer += a[i] * b[i];
            }
            return answer;
        }
        //public int solution(int[] a, int[] b)
        //{ 두 배열의 동일한 인덱스 간에 한해 적용되는 LINQ의 Zip메서드
        //    return a.Zip(b, (t1, t2) => t1 * t2).Sum(); 
        //}
    }
}
