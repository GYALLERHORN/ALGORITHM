using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_016
{
    public class TrialExam
    {
        public int[] solution(int[] answers)
        {
            int[] rank = new int[] { };

            int examinee1Score = 0;
            int examinee2Score = 0;
            int examinee3Score = 0;

            int[] examinee1Pattern = new int[] { 1, 2, 3, 4, 5 };
            int[] examinee2Pattern = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] examinee3Pattern = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

            int examinee1PatCycle = 1;
            int examinee2PatCycle = 1;
            int examinee3PatCycle = 1;


            for (int i = 0; i < rank.Length; i++)
            {

            }

            return rank;
        }
    }
}
