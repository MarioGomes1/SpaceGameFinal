using System;
using System.Runtime.CompilerServices;
using static MyGame.World;

namespace MyGame
{
    public class Write
    {
        public int Decision { get; set; }
        
        public Write()
        {
            
            Introduction();
            FirstChan();
        }

        public void Introduction()
        {
            Console.WriteLine();//TODO 1- add intro story add intro story here
        }


        public  void FirstChan() 
        {
            Console.WriteLine("                                                     |              |                ");
            Console.WriteLine("   --------------------------------------------------| Chapter-One  |--------------------------------------------- ");
            Console.WriteLine("                                                     |              |                ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("As you make your way to the first planet you suddenly realize that you are being attacked by space " +
                              "scavengers.To defeat them you must answer the following question: ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Beware; you will lose 50 tokens for every wrong answer.");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            Console.Read();
            Console.Clear();
            Console.WriteLine("What is question?");//TODO 2-input question here
            Console.Read();



        }

        public  int Planets1()
        {
            Console.Clear();
            Console.WriteLine("You have arrived at Planet Gotham. \nPress [1] to buy\npress [2] to sell");
            this.Decision = Decision = Convert.ToInt32(Console.ReadLine());
            return Decision;
            
        }

        public int Planets2()
        {

            Console.WriteLine("you have arrived ");
            return Decision;
        }
    }
}