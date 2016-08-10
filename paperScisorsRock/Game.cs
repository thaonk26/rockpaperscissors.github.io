using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paperScisorsRock
{
    class Game
    {
        Player playerOne;
        Player playerTwo;
        string one = "scissors";
        string two = "rock";
        string three = "paper";
        int rounds;
        int numberOfRounds;

        public Game()
        {
            Console.WriteLine("PLAYER ONE, what is your name?");
            this.playerOne = new Player(Console.ReadLine());
            Console.WriteLine("PLAYER TWO, what is your name? OR 'cpu' to play against AI");
            this.playerTwo = new Player(Console.ReadLine());
            Console.WriteLine("How many rounds would you like?");
            numberOfRounds = Convert.ToInt32(Console.ReadLine());
            this.rounds = 1;
        }
        public string answerRandom()
        {
            Random number = new Random();
            int answer = number.Next(1, 4);
            switch (answer)
            {
                case 1:
                    return one;
                case 2:
                    return two;
                default:
                    return three;
            }
        }
        public void RunGame()
        {
            while (rounds <= numberOfRounds)
            {
                Console.WriteLine("Welcome to Scissors, Paper, Rock!\n choose what you want {0}", playerOne.getName());
                playerOne.setOption(Console.ReadLine());
                if (playerTwo.getName() == "cpu")
                {
                    playerTwo.setOption(answerRandom());
                }
                else {
                    Console.WriteLine("Welcome to Paper, Rock, Scissors!\n Choose your fate {0}", playerTwo.getName());
                    playerTwo.setOption(Console.ReadLine());
                }
                    if (playerOne.getOption() == one && playerTwo.getOption() == two)
                    {
                        Console.WriteLine("\n\n ROUND {0}!!! \n\n", rounds);
                        Console.WriteLine("{0} chose {1} and {2} chose {3},\n {2} WINS!\n\n", playerOne.getName(), one, playerTwo.getName(), two);
                        rounds++;
                        playerTwo.addOneToScore();
                    }
                    else if (playerOne.getOption() == two && playerTwo.getOption() == one)
                    {
                        Console.WriteLine("\n\n ROUND {0}!!! \n\n", rounds);
                        Console.WriteLine("{0} chose {1} and {2} chose {3},\n {0} WINS!\n\n", playerOne.getName(), two, playerTwo.getName(), one);
                        rounds++;
                        playerOne.addOneToScore();
                    }
                    else if (playerOne.getOption() == one && playerTwo.getOption() == three)
                    {
                        Console.WriteLine("\n\n ROUND {0}!!! \n\n", rounds);
                        Console.WriteLine("{0} chose {1} and {2} chose {3},\n {0} WINS!\n\n", playerOne.getName(), one, playerTwo.getName(), three);
                        rounds++;
                        playerOne.addOneToScore();
                    }
                    else if (playerOne.getOption() == three && playerTwo.getOption() == one)
                    {
                        Console.WriteLine("\n\n ROUND {0}!!! \n\n", rounds);
                        Console.WriteLine("{0} chose {1} and {2} chose {3},\n {2} WINS!\n\n", playerOne.getName(), three, playerTwo.getName(), one);
                        rounds++;
                        playerTwo.addOneToScore();
                    }
                    else if (playerOne.getOption() == three && playerTwo.getOption() == two)
                    {
                        Console.WriteLine("\n\n ROUND {0}!!! \n\n", rounds);
                        Console.WriteLine("{0} chose {1} and {2} chose {3},\n {2} WINS!\n\n", playerOne.getName(), three, playerTwo.getName(), two);
                        rounds++;
                        playerTwo.addOneToScore();
                    }
                    else if (playerOne.getOption() == two && playerTwo.getOption() == three)
                    {
                        Console.WriteLine("\n\n ROUND {0}!!! \n\n", rounds);
                        Console.WriteLine("{0} chose {1} and {2} chose {3},\n {2} WINS!\n\n", playerOne.getName(), two, playerTwo.getName(), three);
                        rounds++;
                        playerTwo.addOneToScore();
                    }
                    else
                        Console.WriteLine("\n\nIt's a tie!\n Try again\n\n");
                }
            
            Console.Clear();
        Console.WriteLine("Final score:\n {0} with {1}\n {2} with {3}", playerOne.getName(), playerOne.getScore(), playerTwo.getName(), playerTwo.getScore());
        }

    }
}

