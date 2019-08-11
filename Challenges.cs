using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{//if you do not need to store data no need to create object?
    class  Challenges
    {
        public int firstAnswer { get; }
        public Player CurrentPlayer { get; set; }
        //public string FirstAnswer { get; set; }//not needed? clean up.
        //public int Tokens {get; set; }

        public Challenges(Player player, Write write)
        {
            CurrentPlayer = player;//how????

            answer();
            //SecondChan(write);


        }

        public Challenges(Write write, Player player)
        {
            //CurrentPlayer = player;
            SecondChan(write,player);
            
        }

        public static void SecondChan(Write write, Player player) //turn questions to list?...research list
        {
            //CurrentPlayer = player;
            
            write.SecondChan();
            int secondAnswer;
            Console.WriteLine("Enter your answer:");
            secondAnswer = Convert.ToInt32(Console.ReadLine());//wrong input format. completely stuck.

            while (true)
            {
                //int secondAnswer;
                //Console.WriteLine("Enter your answe:");
                //Console.ReadLine();

                //if (secondAnswer == 1)
                //{
                //    Console.WriteLine("You have barely escaped!\n\nBe on the lookout, they will surely seek revenge...");
                //    player.Tokens += 50;//todo look further
                //    Console.WriteLine("\n\nYou now have: {0} tokens", player.Tokens);
                //    Console.ReadLine();
                //}
            }


        }




        public void answer()
        
        {
            int firstAnswer;


            while (true)
            {
                Console.WriteLine("Enter your answer");
                
                firstAnswer = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (firstAnswer == 3)
                {
                    Console.WriteLine("You have barely escaped!\n\nBe on the lookout, they will surely seek revenge...");
                    CurrentPlayer.Tokens += 50;//todo look further
                    Console.WriteLine("\n\nYou now have: {0} tokens",CurrentPlayer.Tokens);
                    Console.ReadLine();
                    
                    break;

                }
                else
                {
                    // todo: break when Tokens <= 0;
                   
                    CurrentPlayer.Tokens -= 50;
                    Console.WriteLine("Incorrect, you have lost 50 Tokens. You have {0} Tokens left....try  again.\n[1] Void\n[2] Private\n[3]Public", CurrentPlayer.Tokens);//implement a forloop for tokens?
                    
                    
                   

                    if (CurrentPlayer.Tokens == 0) 
                    {
                        
                    }
                    


                }
                
                
            }

            
        }

    }
}


   
    

