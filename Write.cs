using System;
using System.Runtime.CompilerServices;
using static MyGame.World;

namespace MyGame
{
    public class Write
    {
        public int purchase { get; set; }
        
        public Write()
        {
            
            Introduction();
            Replies();
        }

        public void Introduction()
        {
            Console.WriteLine();//add intro story here
        }


        public  void Replies() 
        {

            
            Console.WriteLine(
                "You have encountered your first challenge...to pass you must answer the following question");
            
        }

        public  int Planets()
        {
            
            Console.WriteLine("You have arrived at Planet Gotham. \nPress 1 to buy\n press 2 to sell?");
            this.purchase = purchase = Convert.ToInt32(Console.ReadLine());
            return purchase;
        }
    }
}