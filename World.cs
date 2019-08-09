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
        public int tokens { get; set; }
        public int _purchase { get; set; }
        public World(Player player, Write write)
        {

            this.tokens = player._tokens;
           _purchase= write.Planets();
           
         
           if (_purchase == 1) 
           {
               Buy();
               player._tokens = this.tokens;
            }
           else if (_purchase==2)
           {
               Sell();
               player._tokens = this.tokens;
            }

           

        }




        public int Buy()
        {


            Console.WriteLine("You have chosen to buy. Here are your options \n 1 for water \n 2 for food");
            int buy = Convert.ToInt32(Console.ReadLine());
            if (buy==1)
            {
                tokens -= 50;
                
            }

            return tokens;

        }

        public void Sell()
        {
            Console.WriteLine("You have chosen to sell. Here are your options \n 1 for water \n 2 for food");
        }
    }
}





//        // Name

//        // Math stuff
//        // How to trade water on this planet at 115% or Fuel at 40%

//        // Distance from Sun? Fuel required? Some value to allow travel?
//    }
//}