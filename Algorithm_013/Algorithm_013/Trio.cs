﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_013
{
    public class Trio
    {
        public int solution(int[] number)
        {
            int answer = 0;

            for (int i = 0; i < number.Length; i++)
            {
                for (int j = i + 1; j < number.Length; j++)
                {
                    for (int k = j + 1; k < number.Length; k++)
                    {
                        answer += number[i] + number[j] + number[k] == 0 ? 1 : 0;
                    }
                }
            }
            return answer;
        }
    }
}