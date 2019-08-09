using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class World
    {
        public int Tokens;
        public World(Player player)
        {
            this.Tokens = player.Tokens;
            Console.WriteLine(Tokens);
        }

    }
}





//        // Name

//        // Math stuff
//        // How to trade water on this planet at 115% or Fuel at 40%

//        // Distance from Sun? Fuel required? Some value to allow travel?
//    }
//}