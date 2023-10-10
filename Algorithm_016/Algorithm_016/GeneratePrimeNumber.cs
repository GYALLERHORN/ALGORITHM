using System;

namespace Algorithm_016
{
    internal class GeneratePrimeNumber
    {
        public int solution(int[] nums)
        {
            int answer = 0;
            int generatedNum;

            for (int i = 0; i < nums.Length - 2; i++)
                for (int j = i + 1; j < nums.Length - 1; j++)
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        generatedNum = nums[i] + nums[j] + nums[k];
                        for (int aliquot = 2; aliquot <= generatedNum; aliquot++)
                        {
                            if (generatedNum % aliquot == 0 && aliquot != generatedNum)
                            {
                                break;
                            }
                            if (aliquot == generatedNum)
                            {
                                answer++;
                            }
                        }
                    }

            return answer;
        }
    }
}
