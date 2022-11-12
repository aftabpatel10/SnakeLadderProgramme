using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int position = 0;
            Console.WriteLine($"Game at initial position : {position}");

            Random random = new Random();
            int diceoutput = random.Next(1, 7);
            Console.WriteLine($"rollingdice :{diceoutput}");
            Console.ReadLine();
        }
    }
}
