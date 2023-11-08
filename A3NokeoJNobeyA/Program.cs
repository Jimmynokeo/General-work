/* Rock Paper Scissors Arena.cs
 * To simulate a rock paper scissors game
 *
 * Revision History:
 *  Jimmy Nokeo and Abia Elizabeth Nobey, Noveember 2023
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3NokeoJNobeyA
{
    class Program
    {   // variables and random Generator
        static Random randGen = new Random();
        static int rounds;
        static int counter;
        static int userScore;
        static int botScore;
        

        static void Main(string[] args)
        {
            //Welcoming user and requesting round input
            Console.WriteLine("Welcome to the Rock Paper Scissors Tournament");

            do
            {
                try
                {
                    Console.WriteLine("How many rounds would you like to play (1-10): ");
                    rounds = Convert.ToInt32(Console.ReadLine());
                    if (rounds < 0 || rounds > 10)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    if (rounds >= 1 && rounds <= 10 && rounds != 0)
                    {
                        rounds--;
                        DisplaySelection();

                    }
                    if (rounds == 0)
                    {
                        DisplayScore();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Rounds must be in integer form");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Please select between 1 and 10 rounds ");
                }
            } while (rounds != 0);






            Console.ReadKey();
        }
        //creating a welcome menu and round 
        static void DisplaySelection()
        {
            string userChoice;

            Console.Clear();
            Console.WriteLine("Please select from the following:");
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissors");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {

            }
            


           // for (int counter = 1; c
        }
        static void Gameplay()
        {

        }
        static void DisplayScore()
        {
            Console.WriteLine("The tournament is complete");
            Console.WriteLine("The Player wins the series");
            Console.WriteLine("Thanks for playing. Come back soon.");
            Console.ReadKey();
        }
    }   
        

        
        
}
