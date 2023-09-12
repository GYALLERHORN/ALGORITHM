using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Algorithm_009
{
    public class _025_CalculatinInsufficientAmount
    {
        public long solution(int price, long money, int count) // 정직하다!
        {
            long totalFee = 0;
            for (int i = 1; i <= count; i++)
            {
                totalFee += price * i;
            }
            if (totalFee <= money)
            {
            return 0;

            }
            return totalFee - money;
        }
    }
}
