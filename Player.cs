using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static MyGame.Enum;

namespace MyGame
{
     public class Player
    {
        //player to world not world to player.
        public World CurrentWorld { get; set; }//research

        public List<Product> Product = new List<Product>();
        public  int _tokens { get; set; }
        public Player(int tokens)
        {

            _tokens = tokens;
          


        }

       
            

       
        
      



      
    }
}

