using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{//if you do not need to store data no need to create object?
    class Challenges
    {
        public Player CurrentPlayer { get; set; }
        //public string FirstAnswer { get; set; }//not needed? clean up.
        //public int Tokens {get; set; }

        public Challenges(Player player)
        {
            CurrentPlayer = player;//how????
            
            answer();
           
        }
        
        public static void LuigiQuestion(Player p)//turn questions to list?...research list
        {
            // ask specific luigi quesiton
            // p.Tokens
        }
        
        public void answer()
        {
            string firstAnswer;


            while (true)
            {
                Console.WriteLine("Enter your answer");
                firstAnswer = Console.ReadLine();
                Console.Clear();
                if (firstAnswer == "Mario")
                {
                    Console.WriteLine("Correct");
                    CurrentPlayer.Tokens += 50;//todo look further
                    Console.WriteLine("You now have: {0} tokens",CurrentPlayer.Tokens);
                    Console.ReadLine();
                    
                    break;

                }
                else
                {
                    // todo: break when Tokens <= 0;
                   
                    CurrentPlayer.Tokens -= 50;
                    Console.WriteLine("Incorrect, you have lost 50 Tokens. You have {0} Tokens left....Type your answer again.", CurrentPlayer.Tokens);//implement a forloop for tokens?
                    
                    
                   

                    if (CurrentPlayer.Tokens == 0) 
                    {
                        
                    }
                    


                }
                
                
            }

            
        }

    }
}


   
    

