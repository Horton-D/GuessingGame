using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to my guessing Game!!\nHere you guess a random number between 1-10!");

           
            while (true)
            {

             int correctNumber;
             int userGuess = 0;
    
             Random random = new Random();
             correctNumber = random.Next(1, 10);
             Console.WriteLine("Guess a number");



                while (userGuess != correctNumber)
                {
                   
                    var input = Console.ReadLine();
                    if (!int.TryParse(input, out userGuess)) Console.WriteLine("Enter a valid number");

                    if( userGuess == correctNumber)
                    {
                        Console.WriteLine("You Win");
                    }else
                    {
                        Console.WriteLine("Try Again");
                    }
                }

                
                Console.WriteLine("Would you like to play again? y/n");
                var playAgain = Console.ReadLine();

                if (playAgain == "y")
                {
                    continue;
                }
                else
                {

                    Console.WriteLine("Good Bye!");
                    return;
                }
            }
        }
    }
}
