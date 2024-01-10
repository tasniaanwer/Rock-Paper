using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refactored_rock_paper
{
    public class ConsolePlayAgainPrompt : IPlayAgainPrompt
    {
        public bool ShouldPlayAgain()
        {
            Console.WriteLine("Do you want to play again? (y/n)");
            string loop = Console.ReadLine();
            return loop?.ToLower() == "y";
        }
    }

}
