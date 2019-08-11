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
        public Player CurrentPlayer { get; set; }
        //player to world not world to player.
        public World CurrentWorld { get; set; }//research

        public List<Product> Product = new List<Product>();
       public  int Tokens { get; set; }
       public double Fuel { get; set; }    
        public Player(int tokens, double fuel)
        {

            this.Tokens = tokens;
            this.Fuel = fuel;




        }

        public Player()
        {
            
        }

       
            

       
        
      



      
    }
}

