using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_010
{
    public class Operator
    {
        static void Main(string[] args)
        {
            AdditionofMatrix mat = new AdditionofMatrix();

            int[,] ints2 = new int[,] { { 2, 3 }, { 4, 5 } };
            int[,] ints = new int[,] { { 1, 2 },{ 3, 4 } };

            ints = mat.solution(ints2, ints);
            Console.WriteLine(ints[1,1]);
        }
    }
}
