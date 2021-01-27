using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerInput, botInput;
            int randomInt;
            bool continuegame = true;

            while (continuegame)
            {

                int playerScore = 0;
                int botScore = 0;

                while (playerScore < 3 && botScore < 3)
                {

                    Console.Write("Choose between ROCK, PAPER or SCISSORS: ");
                    playerInput = Console.ReadLine();
                    playerInput = playerInput.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            botInput = "ROCK";
                            Console.WriteLine("The bot chose ROCK!");

                            if (playerInput == botInput)
                            {
                                Console.WriteLine("ITS A DRAW!");
                            }
                            else if (playerInput == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!");
                                playerScore++;
                            }
                            else if (playerInput == "SCISSIORS")
                            {
                                Console.WriteLine("BOT WINS!");
                                botScore++;
                            }
                            break;

                        case 2:
                            botInput = "PAPER";
                            Console.WriteLine("The bot chose PAPER!");

                            if (playerInput == botInput)
                            {
                                Console.WriteLine("ITS A DRAW!");
                            }
                            else if (playerInput == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!");
                                playerScore++;
                            }
                            else if (playerInput == "ROCK")
                            {
                                Console.WriteLine("BOT WINS!");
                                botScore++;
                            }
                            break;

                        case 3:
                            botInput = "SCISSORS";
                            Console.WriteLine("The bot chose SCISSORS!");
                            if (playerInput == botInput)
                            {
                                Console.WriteLine("ITS A DRAW!");
                            }
                            else if (playerInput == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!");
                                playerScore++;
                            }
                            else if (playerInput == "PAPER")
                            {
                                Console.WriteLine("BOT WINS!");
                                botScore++;
                            }
                            break;

                        default:
                            Console.WriteLine("You didn't enter a valid choice!");
                            break;
                    }
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}", playerScore, botScore, "\n\n");
                }

                if (playerScore == 3)
                {
                    Console.WriteLine("PLAYER WINS THE GAME!");
                }
                else if (botScore == 3)
                {
                    Console.WriteLine("THE BOT HAS WON THIS ROUND");
                }
                else
                {

                }

                Console.Write("Would you like to play again? (Y/N): ");
                string loop = Console.ReadLine();
                loop = loop.ToUpper();
                if (loop == "Y")
                {
                    continuegame = true;
                    Console.Clear();
                }
                else if (loop == "N")
                {
                    continuegame = false;
                    Console.WriteLine("Thanks for playing!");
                }
                else
                {

                }
            }
        }
    }
}
