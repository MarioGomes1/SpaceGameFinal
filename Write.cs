using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static MyGame.World;

namespace MyGame
{
    public class Write
    {
        public int Decision { get; set; }
        public Player CurrentPlayer { get; set; }

        public Write(Player player)
        {

            CurrentPlayer = player;
            
            Introduction();
            FirstChan();
        }

        public void Introduction()
        {

            Console.WriteLine("                                                     |                  |                ");
            Console.WriteLine("   --------------------------------------------------| In the Beginning |---------------------------------------------- ");
            Console.WriteLine("                                                     |                  |                ");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("After decades of Governmental conflicts, endless, pointless wars; Planet Earth has been put on a self destruct path." +
                              " With limited resources it is only a matter of time before humans become extinct.");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("                                                     |                  |                ");
            Console.WriteLine("   --------------------------------------------------| In the Beginning |--------------------------------------- ");
            Console.WriteLine("                                                     |                  |                                       ");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                      The survival of your ---- has been placed in your hands.");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("                                                     |                  |                ");
            Console.WriteLine("   --------------------------------------------------| In the Beginning |--------------------------------------- ");
            Console.WriteLine("                                                     |                  |                ");

            Console.WriteLine(
                "You must travel where no humans have been before; SPACE. Your objective will be to gather enough resources \n\nthroughout your journey and return back to Earth.");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(
                "\n\n\n\n\nYou will begin this journey with 500 tokens, and a full tank of fuel. Your goal is to reach planet Area51 with at least\n\n1000 Tokens where you will trade it for several cargo which contains first-aid, water, food, and clothing, at least 40%  \n\nof fuel will be needed to return back to earth with the" +
                " additional load.");
           
            Console.WriteLine(""); 
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.ReadLine();
           // Console.Clear();
            //TODO 1- add intro story add intro story here
        }


        public  void FirstChan() 
        {
            Console.Clear();
            Console.WriteLine("                                                     |              |                ");
            Console.WriteLine("   --------------------------------------------------| Chapter-One  |---------------------------------------------- ");
            Console.WriteLine("                                                     |              |                ");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\n\n---------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("\n\n\n\nAs you make your way to the first planet you suddenly realize that you are being attacked by space " +
                              "scavengers.\n\nTo defeat them you must answer the following question: ");
            Console.WriteLine("\n\n------------------------------------------------------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("   --------------------------------------------------| Chapter-One  |---------------------------------------------- ");
            Console.WriteLine("                                                     |              |                ");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Beware; you will lose 50 tokens for every wrong answer.");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.Read();
            Console.Clear();
            Console.WriteLine("   --------------------------------------------------| Chapter-One  |---------------------------------------------- ");
            Console.WriteLine("                                                     |              |                ");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("To make a member of a class accessible from outside the class declaration you should declare it as:\n[1] Void\n[2] Private\n[3]Public");
            Console.Read();



        }

        public void SecondChan()
        {

            
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("                                                     |              |                ");
            Console.WriteLine("   --------------------------------------------------| Chapter-Two  |---------------------------------------------- ");
            Console.WriteLine("                                                     |              |                ");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("After a successful trip to planet Gotham, you must now depart to planet Tamebos. You are one step closer to reaching \n\nyour goal.");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("                                                     |              |                ");
            Console.WriteLine("   --------------------------------------------------| Chapter-Two  |---------------------------------------------- ");
            Console.WriteLine("                                                     |              |                ");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(
                "\n\n\n\nAs you make your way to Tamebos, your ship is hit yet again!\n\nThey've returned!\n\n You will have to defeat, or escape once more... ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("For every wrong answer they will take 100 tokens from you.");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.Read();
            Console.Clear();
            Console.WriteLine("   --------------------------------------------------| Chapter-Two  |---------------------------------------------- ");
            Console.WriteLine("                                                     |              |                ");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
           
            Console.WriteLine("An enumeration is a__________type\n[1]reference\n[2]value[3]object\n[4]reference AND value");//TODO 2-input question here
             //int ans = Convert.ToInt32(Console.ReadLine());
             //this.Decision = Decision = Convert.ToInt32(Console.ReadLine());
             //return Decision;
        }

        public  int Planets1()
        {
            Console.Clear();
            Console.WriteLine("                                                     |              |                ");
            Console.WriteLine("   --------------------------------------------------|  It Begins!  |---------------------------------------------- ");
            Console.WriteLine("                                                     |              |                ");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\nAfter 14 days of space travel, you have finally arrived at your first of five destinations; Planet Gotham. This long \n\njourney has cost you 25% of your fuel." +
                              " \n\n\n\n\n\n\n Before you are allowed to depart Gotham, it is mandatory that you make a transaction...");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.ReadKey();
            Console.WriteLine("Your options are:\n[1] to buy fuel \n[2] to sell fuel");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            this.Decision = Decision = Convert.ToInt32(Console.ReadLine());
            return Decision;
            
        }

        public int Planets2()
        {

            Console.WriteLine("");
            Console.WriteLine("After 3 long months, and (hopefully) defeating the space pirates once more, you have finally arrived on planet Tamebos");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("");
            return Decision;
        }
    }
}