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
            Decision = write.Planets2();
            Console.Clear();

            if (Decision == 1) Buy();
           
            else if (Decision == 2) Sell();
            
        }




        public int Buy()
        {


            Console.WriteLine("You have chosen to buy. Here are your options \n [1] for water \n [2] for food");
            int buy = Convert.ToInt32(Console.ReadLine());
            if (buy==1)
            {
                CurrentPlayer.Tokens -= 50;
                
            }

            return CurrentPlayer.Tokens;

        }

        public void Sell()
        {
            Console.WriteLine("You have chosen to sell. Here are your options \n [1] for water \n [2] for food");
        }
    }
}





//        // Name

//        // Math stuff
//        // How to trade water on this planet at 115% or Fuel at 40%

//        // Distance from Sun? Fuel required? Some value to allow travel?
//    }
//}