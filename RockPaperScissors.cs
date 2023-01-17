using System;
class ConsoleColorsClass
{
    ConsoleColor background = Console.BackgroundColor;
    ConsoleColor foreground = Console.ForegroundColor;

}

namespace RockPaperScissors
{
    class RockPaperScissors
    {
        static void Main(string[] args)
        {
        
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;

            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            Console.WriteLine("Input how much games you wanna play: ");
            int gameCounter = int.Parse(Console.ReadLine());
            int winsCounter = 0;
            int loseCounter = 0;
            int equalsCounter = 0;


            while (gameCounter > 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
                string playerMove = Console.ReadLine();

                if (playerMove == "r" || playerMove == "rock")
                {
                    playerMove = Rock;
                }
                else if (playerMove == "p" || playerMove == "paper")
                {
                    playerMove = Paper;
                }
                else if (playerMove == "s" || playerMove == "scissors")
                {
                    playerMove = Scissors;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Invalid Input. Try Again...");
                    continue;
                }

                Random random = new Random();
                int computerRandomNumber = random.Next(1, 4);
                string computerMove = string.Empty;

                switch (computerRandomNumber)
                {
                    case 1:
                        computerMove = "Rock";
                        break;
                    case 2:
                        computerMove = "Paper";
                        break;
                    case 3:
                        computerMove = "Scissors";
                        break;
                    default:
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"The computer chose {computerMove}.");

                if ((playerMove == Rock && computerMove == Scissors)
                    || (playerMove == Paper && computerMove == Rock)
                    || (playerMove == Scissors && computerMove == Paper))

                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win");
                    winsCounter++;
                }
                else if ((computerMove == Rock && playerMove == Scissors)
                    || (computerMove == Paper && playerMove == Rock)
                    || (computerMove == Scissors && playerMove == Paper))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lose.");
                    loseCounter++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("This game was a draw");
                    equalsCounter++;
                }

                gameCounter--;
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Console.WriteLine("SCORE");
            Console.WriteLine($"Wins: {winsCounter}");
            Console.WriteLine($"Losses: {loseCounter}");
            Console.WriteLine($"Equals: {equalsCounter}");
            
        }
    }
}
