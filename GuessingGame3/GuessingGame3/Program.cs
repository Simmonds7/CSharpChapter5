using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace GuessingGame3
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayGame();
        }
        static void DisplayGame()
        {
            int guess;
            string guessString;
            int min = 1;
            int max = 11;
            int againL = 1;
            int againH = 10;
            int numGuesses = 0;
            string result = null;
            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(min, max);
            do
            {
                Write("Choose a number between 1 and 10 (One and Ten inclusive).");
                guessString = ReadLine();
                guess = Convert.ToInt32(guessString);

                if (guess < max && guess >= min)
                {
                    if (randomNumber == guess)
                    {
                        result = "You have guessed correctly. The random number was " + randomNumber;
                        numGuesses++;
                    }
                    else if (guess > randomNumber)
                    {
                        result = "Your guess was incorrect. Try going lower.";
                        numGuesses++;
                        if (guess > againH)
                        {
                            result = "You... You... Did you really just?... Oh my... You really are that stupid... I said go Lower.";
                            numGuesses++;
                        }
                        againH = guess;
                    }
                    else if (guess < randomNumber)
                    {
                        result = "Your guess was incorrect. Try going higher.";
                        numGuesses++;
                        if(guess < againL)
                        {
                            result = "You... You... Did you really just?... Oh my... You really are that stupid... I said go Higher.";
                            numGuesses++;
                        }
                        againL = guess;
                    }
                }
                else
                    result = "Error. Number guessed doesn't fit the range.";
                DisplayString(result);
            } while (guess != randomNumber);
            WriteLine("You guessed it in {0} guesses.", numGuesses);
        }
        static void DisplayString(string result)
        {
            WriteLine(result);

        }
    }
}
