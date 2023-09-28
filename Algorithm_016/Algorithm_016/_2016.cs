using System;
using System.Globalization;

namespace Algorithm_016
{
    internal class _2016
    {
        public string solution(int a, int b)
        {
            DateTime dateTime = new DateTime(2016, a, b);
            string answer = "";
            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    answer = "SUN";
                    break;
                    case DayOfWeek.Monday:
                    answer = "MON";
                    break;
                    case DayOfWeek.Tuesday:
                    answer = "TUE";
                    break;
                    case DayOfWeek.Wednesday:
                    answer = "WED";
                    break;
                    case DayOfWeek.Thursday:
                    answer = "THU";
                    break;
                    case DayOfWeek.Friday:
                    answer = "FRI";
                    break;
                    case DayOfWeek.Saturday:
                    answer = "SAT";
                    break;
            }
            return answer;
        }
    }
}
