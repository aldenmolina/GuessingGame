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

            Console.WriteLine("I am thinking of a number from 1 to 10. Can you guess it?");

            while (guess != num && tries != 3)
            {
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == num)
                {
                    Console.WriteLine("You are correct!");    
                    
                }
                else if (guess < num)
                {
                    Console.WriteLine("Your number is less than my number. Try again!");
                    continue;
                }
                else if (guess > num)
                {
                    Console.WriteLine("Your number is greater than my number. Try again!");
                    continue;
                }
                else if (guess == 0)
                {
                    Console.WriteLine("You must pick a number between 1 and 10");
                    continue;
                }
                else 
                {
                    Console.WriteLine("That is not a valid answer.");
                    break;
                }
            }
        }
    }
}
