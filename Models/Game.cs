using System;

namespace RPS_cs.Models
{
    public class Game
    {
        private char compChoice {get; set;}
        public bool Choice(char playerChoice)
        {
            System.Console.Write("Computer's Choice: ");
            System.Console.Write(compChoice);
            System.Console.WriteLine("");
            if(playerChoice == compChoice){
                System.Console.WriteLine("It's a tie!");
                return false;
            }else if(playerChoice == 'p'){
                if(compChoice == 'r'){
                System.Console.WriteLine("You Win!! Paper beats Rock!");
                return false;
                }else{
                System.Console.WriteLine("You lose, try again! ");
                return false;
                }
            }else if(playerChoice == 'r'){
                if(compChoice == 's'){
                System.Console.WriteLine("You Win!! Rock beats Scissors!");
                return false;
                }else{
                System.Console.WriteLine("You lose, try again! ");
                return false;
                }
            }else if(playerChoice == 's'){
                if(compChoice == 'p'){
                System.Console.WriteLine("You Win!! Scissors beats Paper!");
                return false;
                }else{
                System.Console.WriteLine("You lose, try again! ");
                return false;
                }
            }else{
                System.Console.WriteLine("Enter a valid response");
                return true;
            }
        }

public Game()
{
    Random rnd = new Random();
    var num = rnd.Next(1, 4);
    if(num == 1){
        compChoice = 'r';
    }else if( num == 2 ){
        compChoice = 'p';
    }else{
        compChoice = 's';
    }
}

    }
}