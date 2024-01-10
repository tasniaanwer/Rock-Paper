using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refactored_rock_paper
{
    public class ConsoleScoreDisplay : IScoreDisplay
    {
        public void DisplayScores(int scorePlayer, int scoreCPU)
        {
            Console.WriteLine($"\n\nSCORES:\tPLAYER:\t{scorePlayer}\tCPU:\t{scoreCPU}");
        }
    }
}
