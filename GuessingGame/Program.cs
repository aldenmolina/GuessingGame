using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rando = new Random();
            int num = rando.Next(1, 10);
            int guess = 0;
            int tries = 0;

            Console.WriteLine("I am thinking of a number from 1 to 10. Can you guess what it is?");

            while (guess != num && tries != 3)
            {
                guess = int.Parse(Console.ReadLine());
                tries++;
                Console.WriteLine("Round: " + tries + " of 3");

                if (guess == num)
                {
                    Console.WriteLine("You are correct!");
                    
                }
                else if (guess == 0)
                {
                    Console.WriteLine("You must pick a number between 1 and 10.");
                    
                    continue;
                }
                else if (guess < 1 || guess > 10)
                {
                    Console.WriteLine("Error: Not a valid number!");
                   
                    break;
                }
                else if (guess > num)
                {
                    Console.WriteLine("Your number is higher than my number. Try again!");
                    
                    continue;
                }
                else if (guess < num)
                {
                    Console.WriteLine("Your number is lower than my number. Try again!");

                    continue;
                }
            }
        }
    }
}
