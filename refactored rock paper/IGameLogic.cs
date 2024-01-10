using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refactored_rock_paper
{
    public interface IGameLogic
    {
        void DetermineWinner(string playerChoice, string cpuChoice, ref int scorePlayer, ref int scoreCPU);
    }

}
