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
            int player1 = 0, player2 = 0, selectplayer = 1 ;
            Console.WriteLine($"Game at initial position : {player1}");
            int count = 0, count1 = 0;

           
            {

                while (player2 < 100 && player1 < 100)
                {
                    Random random = new Random();
                    
                    //count++;
                    if (selectplayer == 1)
                    {
                        int diceoutput = random.Next(1, 7);
                        {
                            if(player1 < 100 && player1 >= 0)
                            {
                                Console.WriteLine("player1 DiceValue is :" +diceoutput);
                                Random random1 = new Random();
                                Console.WriteLine("Checking For Options");
                                int option = random1.Next(1, 4);
                                switch(option)
                                
                            
                        }
                    }
                    //Console.WriteLine("Dice Output is ;" + diceoutput);
                    //position = position + diceoutput;
                    //Console.WriteLine("Position :" + position);

                    //Random random2 = new Random();
                    //Console.WriteLine("Checking For Options");
                    //int dicecount = random.Next(1, 4);
                    //switch (dicecount)
                    
                                      case 1:
                                         Console.WriteLine("Ladder");
                                         player1 += diceoutput;
                                         selectplayer = 1;
                            if (position >= 100)
                            {
                                player1 -= diceoutput;
                            }   
                            //Console.WriteLine("Position :" +position);
                            break;
                                        case 2:
                                            Console.WriteLine("Snake");
                            player1 -= diceoutput;
                                selectplayer = 2;
                            if (player1 < 0)
                            {
                                player1 = 0;
                            }
                            //Console.WriteLine("Position :" +position);
                            break;
                            default:
                            Console.WriteLine("No Play");
                            //position = position;
                            //Console.WriteLine("Position :" +position);
                            break;
                    
                    Console.WriteLine("Player1 Current position :" +player1);
                        if(player1 < 0)
                        {
                            player1 = 0;
                        }
                                count++;
                }
                Console.WriteLine("No Of Times Dice Thrown is :" +position);
                Console.ReadLine();
                
            }

            
        }
    }
}
