namespace Algorithm_016
{
    internal class ColaProblem
    {
        public int solution(int a, int b, int n)
        {
            int answer = 0;
            int temp;
            while (n >= a)
            {
                temp = n / a * b;
                answer += temp;
                n = temp + n % a;
            }
            return answer;
        }
    }
}
