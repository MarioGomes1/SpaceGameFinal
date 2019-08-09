using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyGame
{
 
    
    class Program
    {


        static void Main(string[] args)
        {
            var player = new Player(500);
            var write = new Write();
            var challenges = new Challenges(player);
            var world = new World(player, write);
            Console.WriteLine(player._tokens);
           
            







        }
    }
}


