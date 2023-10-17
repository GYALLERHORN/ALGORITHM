using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_017
{
    internal class WeaponofTemplar
    {
        public int solution(int number, int limit, int power)
        {
            int answer = 0;

            for (int i = 1; i <= number; i++)
            {
                int aliquotCount = 0;

                if ((float)Math.Sqrt(i) % 1 == 0)
                {
                    aliquotCount++;
                }

                for (int j = 1; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        aliquotCount += 2;
                    }
                }

                if (aliquotCount > limit)
                {
                    aliquotCount = power;
                }

                answer += aliquotCount;
            }

            return answer;
        }
    }
}
