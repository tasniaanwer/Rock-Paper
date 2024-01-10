using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refactored_rock_paper
{
    public class ConsoleUserInput : IUserInput
    {
        public string GetPlayerInput()
        {
            Console.Write("Choose between ROCK, PAPER, and SCISSORS: ");
            return Console.ReadLine()?.ToUpper();
        }
    }
}
