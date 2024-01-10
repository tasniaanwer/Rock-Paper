using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refactored_rock_paper
{
    public class RandomChoiceProvider : IChoiceProvider
    {
        private readonly Random random;

        public RandomChoiceProvider(Random random)
        {
            this.random = random;
        }

        public string GetCPUChoice()
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
    }
}
