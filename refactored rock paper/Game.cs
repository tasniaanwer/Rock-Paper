
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refactored_rock_paper
{


    public class Game
    {
        private readonly Random random;

        public Game()
        {
            random = new Random();
        }
        public void RunGame()
        {
            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    IUserInput userInput = new ConsoleUserInput();
                    string inputPlayer = userInput.GetPlayerInput();

                    IChoiceProvider choiceProvider = new RandomChoiceProvider(random);
                    string inputCPU = choiceProvider.GetCPUChoice();

                    IGameLogic gameLogic = new BasicGameLogic();
                    gameLogic.DetermineWinner(inputPlayer, inputCPU, ref scorePlayer, ref scoreCPU);

                    IScoreDisplay scoreDisplay = new ConsoleScoreDisplay();
                    scoreDisplay.DisplayScores(scorePlayer, scoreCPU);
                }
                IGameResultDisplay gameResultDisplay = new ConsoleGameResultDisplay();
                gameResultDisplay.DisplayGameResult(scorePlayer, scoreCPU);

                IPlayAgainPrompt playAgainPrompt = new ConsolePlayAgainPrompt();
                playAgain = playAgainPrompt.ShouldPlayAgain();

                Console.Clear();
            }
        }

    }
}