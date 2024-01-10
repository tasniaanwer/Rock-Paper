using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refactored_rock_paper
{
    public interface IGameResultDisplay
    {
        void DisplayGameResult(int scorePlayer, int scoreCPU);
    }
}
