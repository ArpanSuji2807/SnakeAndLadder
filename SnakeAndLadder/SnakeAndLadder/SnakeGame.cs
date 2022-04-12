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
        int position = 0, count = 0, player1 = 0, player2 = 0;
        public int DieRoll()
        {
            Random random = new Random();
            int diePosition = random.Next(1, 7);
            return diePosition;
        }
        public int GAME()
        {
            while (this.position < 100)
            {
                Random random = new Random();
                int roll = random.Next(0,3);
                switch (roll)
                {
                    case NO_PLAY:
                        this.position += 0;
                        break;
                    case SNAKE:
                        this.position -= this.DieRoll();
                        if (this.position < 0)
                        {
                            this.position = 0;
                        }
                        break;
                    case LADDER:
                        this.position += this.DieRoll();
                        if (this.position > 100)
                        {
                            this.position -= this.DieRoll();
                        }
                        break;
                }            
                count++;
            }
            Console.WriteLine("The no. of times dice played to win : "+" "+count);
            Console.WriteLine("the position is : " + this.position);
            return position;
        }
        public void TwoPlayers()
        {
            Random random = new Random();
            int check = random.Next(0,2);
            if (check == 0)
            {
                 player1 = GAME();
            }
            else
            {
                 player2 = this.GAME();
            }
            while(player1<100 && player2<100)
            {
                this.player1 = this.GAME();
                if (this.player1 == 100)
                {
                    Console.WriteLine("Player1 wins the Game");
                }
                else
                {
                    this.player1 = this.GAME();
                }
                if (player2 == 100)
                {
                    Console.WriteLine("player2 wins the Game");
                }
            }
        }
    }
}
