namespace Algorithm_011
{
    public class ReverseTernaryScale
    {
        public int solution(int n) // 진짜 수준낮은 코드다.
        {
            int answer = 0;

            List<int> arr = new List<int>();

            while (true)
            {
                if (n < 3)
                {
                    return n;
                }
                arr.Insert(0,n%3);
                n = n / 3;
                if (n < 3)
                {
                    arr.Insert(0,n);
                    break;
                }
            }

            for (int i = 0; i <= arr.Count -1; i++)
            {
                answer += (int)Math.Pow(3,i) * arr[i];
            }

            return answer;
        }
    }
}
