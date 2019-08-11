using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{

    public class World
    {

        public Player CurrentPlayer { get; set; }
        //public int tokens { get; set; }
        public int Decision { get; set; }
        public World(Player player, Write write)
        {
            CurrentPlayer = player;
            //this.tokens = player._tokens;
            Decision = write.Planets1();
            Console.Clear();
            if (Decision == 1) Buy();
           
            else if (Decision == 2) Sell();
            //Decision = write.SecondChan();

        }




        public double Buy()
        {
            CurrentPlayer.Fuel *= 0.75; 
           
            

            Console.WriteLine("You have chosen to buy.To refuel back to 100% it will cost you 150 tokens");
            int buy = Convert.ToInt32(Console.ReadLine());


            return CurrentPlayer.Tokens -= 150;


           

        }

        public void Sell()
        {
            
            
            Console.WriteLine("You have chosen to sell. The shop on this planet will pay you 100 tokens for 25% of your fuel");

            CurrentPlayer.Fuel -= 50;

            //CurrentPlayer.Tokens += 100;

        }
        
    }
    
}





//        // Name

//        // Math stuff
//        // How to trade water on this planet at 115% or Fuel at 40%

//        // Distance from Sun? Fuel required? Some value to allow travel?
//    }
//}