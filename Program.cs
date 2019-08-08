using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class Write
    {
        public Write(Player player)
        {
            
            var challenges = new Challenges(player, Replies());
        }
        public static string Replies()
        {

            string firstAnswer;
            Console.WriteLine("You have encountered your first challenge...to pass you must answer the following question");
            Console.WriteLine("spell Mario");
            firstAnswer = Console.ReadLine();
            return firstAnswer;

            Console.WriteLine(
                "You have just passed your first challenge, you are on your way to planet 2 too get some \n" +
                "resources. Use your tokens wisely.");


        }
    }


    class Program
    {


        static void Main(string[] args)
        {
            var player = new Player();//pass parameter/tokens 
            var write = new Write(player);

           //only objects

        }
    }
}


