namespace Algorithm_010
{
    public class AdditionofMatrix
    {
        public int[,] solution(int[,] arr1, int[,] arr2)
        {
            int[,] answer = new int[arr1.GetLength(0), arr1.GetLength(1)]; // GetLength(행렬의 해당 차원) : n차원 인덱스의 길이를 반환한다.

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    answer[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            return answer;
        }
    }
}
