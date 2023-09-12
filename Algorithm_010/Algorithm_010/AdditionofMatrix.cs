﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_010
{
    public class AdditionofMatrix
    {
        public int[,] solution(int[,] arr1, int[,] arr2)
        {
            int[,] answer = new int[arr1.GetLength(0), arr1.GetLength(1)];

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.WriteLine($"{arr1[i, j] + arr2[i, j]}");
                    answer[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            return answer;
        }
    }
}