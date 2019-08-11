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

        public Player CurrentPlayer { get; set; } = new Player(500, 100);
        // list of worlds
        //research prop/program implementation
        //

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            var player = new Player(500, 100);

            var write = new Write(player);
            var challenges = new Challenges(player);
            var world = new World(player, write);
            var challenges1 = new Challenges(write);
            
           

            //Challenges.LuigiQuestion(player);

            //todo research list, property/ public Player CurrentPlayer { get; set; }(how does this work exactly?)
            //todo inheritance
            //todo static? last resort? why not always?





        }
    }
}


