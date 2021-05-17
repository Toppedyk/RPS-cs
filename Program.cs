using System;
using RPS_cs.Models;


namespace RPS_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Would you like to play rock, paper scissors? y/n: ");
            Char ans = Console.ReadKey().KeyChar; 
            System.Console.WriteLine("");
            if(ans == 'y'){
                Console.WriteLine("Let's Play!");
            }else if(ans == 'n'){
                Console.WriteLine("Well then why did you run this app?");
            }else{
                Console.WriteLine("Idk, lets play anyway");
            }
            bool again = true;
            while (again)
            {
            Game game = new Game();
            bool winning = true;
            while (winning){
            Console.WriteLine("What is your choice? r/p/s: ");
            char player = Console.ReadKey().KeyChar;
            System.Console.WriteLine("");
            winning = game.Choice(player);
            }
            System.Console.Write("Want to play again??? y/n: ");
            char another = Console.ReadKey().KeyChar;
            System.Console.WriteLine("");
            if(another == 'y'){
                System.Console.WriteLine("Let's play again!");
                again = true;
            }else if(another == 'n'){
                System.Console.WriteLine("Thanks for playing! See you soon.");
                again = false;
            }else{
                System.Console.WriteLine("Bad input, i'll take that as no. come again soon");
                again = false;
            }
            }
        }
    }
}
