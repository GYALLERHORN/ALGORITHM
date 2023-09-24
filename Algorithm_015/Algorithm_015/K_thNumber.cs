using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_015
{
    public class K_thNumber
    {
        public int[] solution(int[] array, int[,] commands)
        {
            List<int> arr = new List<int>();
            
            int[] tempArr = new int[] { };

            int k = 0;

            for (int count = 0; count < commands.GetLength(0); count++)
            {
                int tempArrLgth = commands[count, 1] - commands[count, 0] + 1;
                tempArr = new int[tempArrLgth];
                Array.Copy(array, commands[count, 0] - 1, tempArr, 0, tempArrLgth);

                tempArr = tempArr.OrderBy(x => x).ToArray();

                k = tempArr[commands[count, 2] - 1];

                arr.Add(k);
            }
            int[] answer = arr.ToArray();
            return answer;
        }
    }
}
