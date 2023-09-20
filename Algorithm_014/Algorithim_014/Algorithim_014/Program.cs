using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_014
{
    public class Program
    {
        static void Main()
        {
            CaesarCipher cipher = new CaesarCipher();
            string str = cipher.solution("A z Z", 2);
            Console.WriteLine(str);
        }
    }
}
