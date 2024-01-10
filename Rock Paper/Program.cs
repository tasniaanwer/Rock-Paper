using System;

namespace ViolatingSolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Violating Single Responsibility Principle
            Game game = new Game();
            game.RunGame();
        }
    }

    class Game
    {
        private int scorePlayer;
        private int scoreCPU;
        private Random random;

        public Game()
        {
            random = new Random();
        }

        public void RunGame()
        {
            bool playAgain = true;

            while (playAgain)
            {
                scorePlayer = 0;
                scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    // Violating Open/Closed Principle
                    string inputPlayer = GetPlayerInput();
                    string inputCPU = GetRandomCPUChoice();

                    Console.WriteLine($"Computer chose {inputCPU}");
                    DetermineWinner(inputPlayer, inputCPU);
                    DisplayScores();
                }

                DisplayGameResult();

                Console.WriteLine("Do you want to play again? (y/n)");
                string loop = Console.ReadLine();
                playAgain = loop?.ToLower() == "y";

                Console.Clear();
            }
        }

        // Violating Single Responsibility Principle
        private string GetPlayerInput()
        {
            Console.Write("Choose between ROCK, PAPER, and SCISSORS: ");
            return Console.ReadLine()?.ToUpper();
        }

        // Violating Open/Closed Principle
        private string GetRandomCPUChoice()
        {
            int randomInt = random.Next(1, 4);
            return randomInt switch
            {
                1 => "ROCK",
                2 => "PAPER",
                3 => "SCISSORS",
                _ => throw new InvalidOperationException("Invalid random choice"),
            };
        }

        // Violating Single Responsibility Principle
        private void DetermineWinner(string playerChoice, string cpuChoice)
        {
            if (playerChoice == cpuChoice)
            {
                Console.WriteLine("DRAW!!\n\n");
            }
            else if ((playerChoice == "ROCK" && cpuChoice == "SCISSORS") ||
                     (playerChoice == "PAPER" && cpuChoice == "ROCK") ||
                     (playerChoice == "SCISSORS" && cpuChoice == "PAPER"))
            {
                Console.WriteLine("PLAYER WINS!!\n\n");
                scorePlayer++;
            }
            else
            {
                Console.WriteLine("CPU WINS!!\n\n");
                scoreCPU++;
            }
        }

        // Violating Single Responsibility Principle
        private void DisplayScores()
        {
            Console.WriteLine($"\n\nSCORES:\tPLAYER:\t{scorePlayer}\tCPU:\t{scoreCPU}");
        }

        // Violating Single Responsibility Principle
        private void DisplayGameResult()
        {
            if (scorePlayer == 3)
            {
                Console.WriteLine("Player WON!");
            }
            else if (scoreCPU == 3)
            {
                Console.WriteLine("CPU WON!");
            }
        }
    }
}

