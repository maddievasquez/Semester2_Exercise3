using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester2_Exercise3.Exercises
{
//    Write a program that generates a random number between 1 and 10. Ask a user to guess the
//random number, then display the random number and a message indicating whether the user's
//guess was too high, too low, or correct.

    //I tried to find a different way to solve the same question as in exercise 2
    public class Question3
    {
        public void RadomNumbers()
        {
            Random randomNum = new Random();
            int randomNumber = randomNum.Next(1, 11);
            int usersGuess;
            int amountOfGuesses = 0;
            do
            {
                Console.WriteLine("Guess the random number");
                usersGuess = int.Parse(Console.ReadLine());
                if (usersGuess < randomNumber)
                {
                    Console.WriteLine("Your guess was too low!");
                }
                else if (usersGuess > randomNumber)
                {
                    Console.WriteLine("Your guess was too high!");
                }
                else
                {
                    Console.WriteLine("Congrats, your guess is just right!");
                }
                amountOfGuesses++;

            } while (usersGuess != randomNumber);
            Console.WriteLine($"You guessed  times {amountOfGuesses}");
        } 
    }
}
