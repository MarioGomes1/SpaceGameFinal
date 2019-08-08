using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class Challenges
    {

        public string FirstAnswer { get; set; }
        public int Tokens { get; set; }

        public Challenges(Player player, string ans)
        {
            this.Tokens = player.Tokens;
            answer(ans);
        }

        //public Challenges(string ans)
        //

        public void answer(string firstAnswer)
        {
            this.FirstAnswer = firstAnswer;


            while (true)
            {
                Console.WriteLine("Enter your answer");
                firstAnswer = Console.ReadLine();
                if (firstAnswer == "Mario")
                {
                    Console.WriteLine("Correct");
                    Tokens += 50;
                    //Console.WriteLine("You now have: {0} tokens",Tokens);//test-delete code 
                    break;

                }
                else
                {
                    Console.WriteLine("Try aaagin");
                    continue;


                }
                
                
            }

            
        }

    }
}


   
    

