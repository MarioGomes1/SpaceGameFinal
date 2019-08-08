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
            //
            var challenges = new Challenges(player, Replies()); //Calling and passing 'Replies' method, passing player class
        }

        public static string Replies() //this method is being ^ called
        {

            string firstAnswer;
            Console.WriteLine(
                "You have encountered your first challenge...to pass you must answer the following question");
            Console.WriteLine("spell Mario");
            firstAnswer = Console.ReadLine();
            return firstAnswer;
        }

        public static string Planet2Store()

        {
            string userInputforplanet2;
            Console. WriteLine(
            "You have just passed your first challenge, you are on your way to planet 2 too get some \n" +
            "resources. Use your tokens wisely.");
            userInputforplanet2 = Console.ReadLine();
            return userInputforplanet2;
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


