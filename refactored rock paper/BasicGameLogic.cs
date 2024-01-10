using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refactored_rock_paper
{
    public class BasicGameLogic : IGameLogic
    {
        public void DetermineWinner(string playerChoice, string cpuChoice, ref int scorePlayer, ref int scoreCPU)
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
    }
}
