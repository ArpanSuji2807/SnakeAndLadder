﻿using System;
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
        public void GAME()
        {
            while (this.position < 100)
            {
                Random random = new Random();
                int roll = random.Next(1, 7);
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
                        int num = this.DieRoll();
                        this.position += num;
                        if (this.position > 100)
                        {
                            this.position -= num;
                        }
                        break;
                }
                count++;
            }
            Console.WriteLine("The no. of times dice played to win : "+" "+count);
            Console.WriteLine("the position is : " + this.position);
        }
        public void TwoPlayers()
        {
            player1= this.DieRoll();
            Console.WriteLine("Roll for Player1");
            if (player1 <= 100)
            {
                Console.WriteLine("Player1 is the winner");
            }
            else
            {
                player2 = this.DieRoll();
                Console.WriteLine("Roll of player2");
                if (player2 <= 100)
                {
                    Console.WriteLine("Player2 is the winner");
                }
            }
        }
    }
}
