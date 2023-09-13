namespace Algorithm_011
{
    public class GCDandLCM
    {
        public int[] solution(int n, int m)
        {
            int[] answer = new int[2];

            int min = Math.Min(n, m);
            int max = Math.Max(n, m);

            int gcd = min;

            while (true) //최대공약수 만들기 : 유클리드 호제법
            {
                gcd = max % min;
                if (gcd == 0)
                {
                    break;
                }
                max = min;
                min = gcd;
            }

            answer = new int[2] { min, n * m / min };

            return answer;
        }
    }
}
