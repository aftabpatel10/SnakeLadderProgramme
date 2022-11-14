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
            Console.WriteLine("Welcome To Snake Ladder Programme");
            int position = 0;
            Console.WriteLine($"Game at initial position : {position}");

           
            {

                while (position >= 0 && position < 100)
                {
                    Random random = new Random();
                    int diceoutput = random.Next(1, 7);
                    Console.WriteLine("Dice Output is ;" + diceoutput);
                    position = position + diceoutput;
                    Console.WriteLine("Position :" + position);

                    Random random2 = new Random();
                    Console.WriteLine("Checking For Options");
                    int dicecount = random.Next(1, 4);
                    switch (dicecount)
                    {
                        case 1:
                            Console.WriteLine("Ladder");
                            position += position;
                            break;
                        case 2:
                            Console.WriteLine("Snake");
                            position -= position;
                            break;
                        default:
                            Console.WriteLine("No Play");
                            position = position;
                            break;
                    }
                    Console.WriteLine($"rollingdice : {dicecount}");
                    Console.ReadLine();
                }

                
            }

            
        }
    }
}
