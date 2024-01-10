using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refactored_rock_paper
{
    public interface IScoreDisplay
    {
        void DisplayScores(int scorePlayer, int scoreCPU);
    }
}
