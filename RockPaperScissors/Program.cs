using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    private static void Main(string[] args)
    {
        string inputPlayer, inputCPU;
        int randomInt;

        bool playAgain = true;

        while (playAgain)
        {

            int scorePlayer = 0;
            int scoreCPU = 0;

            while (scorePlayer < 3 && scoreCPU < 3)
            {

                
                Console.Write("Choose ROCK, PAPER or SCISSORS:   ");
                
                inputPlayer = Console.ReadLine();
                
                inputPlayer = inputPlayer.ToUpper();

                Random rnd = new Random();

                randomInt = rnd.Next(1, 4);

                switch (randomInt)
                {
                    case 1:
                        inputCPU = "ROCK";
                        Console.WriteLine("Computer chose ROCK");
                        
                        if (inputPlayer == "ROCK")
                        {
                            Console.WriteLine("It's a tie!!\n");
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("YOU WIN\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "SCISSORS")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("COMPUTER WINS!!\n");
                            scoreCPU++;
                        }
                        break;
                    case 2:
                        inputCPU = "PAPER";
                        Console.WriteLine("Computer chose PAPER");
                        if (inputPlayer == "PAPER")
                        {
                            Console.WriteLine("It's a tie!!\n");
                        }
                        else if (inputPlayer == "ROCK")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("COMPUTER WINS!!\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "SCISSORS")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("YOU WIN\n");
                            scorePlayer++;
                        }
                        break;
                    case 3:
                        inputCPU = "SCISSORS";
                        Console.WriteLine("Computer chose SCISSORS");
                        if (inputPlayer == "SCISSORS")
                        {
                            Console.WriteLine("It's a tie!!\n");
                        }
                        else if (inputPlayer == "ROCK")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("YOU WIN\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("COMPUTER WINS!!\n");
                            scoreCPU++;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid entry!");
                        break;
                }
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}", scorePlayer, scoreCPU);

            }

            if (scorePlayer == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("YOU WON!!!");
            }
            else if (scoreCPU == 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("COMPUTER WON! :( ");
            }
            else
            {

            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Do you want to play again?(y/n)");
            string loop = Console.ReadLine();
            if (loop == "y")
            {
                playAgain = true;
                Console.Clear();
            }
            else if (loop == "n")
            {
                playAgain = false;
            }
            else
            {

            }

        }
    }
}
        
