using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refactored_rock_paper
{
    public class ConsoleGameResultDisplay : IGameResultDisplay
    {
        public void DisplayGameResult(int scorePlayer, int scoreCPU)
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
