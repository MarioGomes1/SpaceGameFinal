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
        public Player CurrentPlayer { get; set; } = new Player(500);
        // list of worlds
        //research prop/program implementation
        //

        static void Main(string[] args)
        {
            var player = new Player(500);

            var write = new Write();
            var challenges = new Challenges(player);
            var world = new World(player, write);
            
           

            //Challenges.LuigiQuestion(player);

            //todo research list, property/ public Player CurrentPlayer { get; set; }(how does this work exactly?)
            //todo inheritance
            //todo static? last resort? why not always?





        }
    }
}


