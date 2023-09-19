using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithim_014
{
    public class MinimumRectangle
    {
        public int solution(int[,] sizes) // int[Width, Height]라고 합시다
        {
            int answer = 0;

            int temp = 0;

            for (int i = 0; i < sizes.GetLength(0); i++) // 배열을 돌면서
            {
                if (sizes[i, 0] < sizes[i, 1]) // Width < Height면 자리 바꾸기
                {
                    temp = sizes[i, 0];
                    sizes[i, 0] = sizes[i, 1];
                    sizes[i, 1] = temp;
                }
            } // 이 과정으로 전부 Width >= Height가 됩니다.

            int maxWidth = sizes[0,0];
            int maxHeight = sizes[0,1];

            for (int i = 1; i < sizes.GetLength(0); i++)
            {
                maxWidth = sizes[i, 0] > maxWidth ? sizes[i,0] : maxWidth;
            }
            for (int i = 1; i < sizes.GetLength(0); i++)
            {
                maxHeight = sizes[i, 1] > maxHeight ? sizes[i, 1] : maxHeight;
            }
            answer = maxWidth * maxHeight;

            return answer;
        }
    }
}
