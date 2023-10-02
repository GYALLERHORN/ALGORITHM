using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_016
{
    public class Program
    {
        static void Main(string[] args)
        {
            CardBundle cardBundle = new CardBundle();
            string[] card1 = new string[] { "i", "water", "drink" };
            string[] card2 = new string[] { "want", "to" };
            string[] goal = new string[] { "i", "want", "to", "drink", "water" };

            string answer = cardBundle.solution(card1, card2, goal);
            Console.WriteLine(answer);
        }
    }
}