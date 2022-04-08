using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeGame
    {
       const int NO_PLAY = 0, SNAKE = 1, LADDER = 2;
        int position = 0;
        public int DieRoll()
        {
            Random random = new Random();
            int diePosition = random.Next(1, 7);
            return diePosition;
        }
        public void GAME()
        {
            Random random = new Random();
            int roll = random.Next(1, 7);
            switch (roll)
            {
                case NO_PLAY: this.position += 0;
                    break;
                case SNAKE: this.position -= this.DieRoll();
                    break;
                case LADDER: this.position += this.DieRoll();
                    break;
            }
        }
    }
}
