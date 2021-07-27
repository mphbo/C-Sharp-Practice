using System;

namespace Variables
{
  class Program
  {
    static void Main(string[] args)
    {

      string secretWord = "giraffe";
      string guess = "";
      int guessCount = 0;
      int guessLimit = 3;
      bool outOfGuesses = false;
      do
      {
        if (guessCount < guessLimit)
        {
          Console.Write("Enter guess: ");
          guess = Console.ReadLine();
          guessCount++;
        } else
        {
          outOfGuesses = true;
        }
      } while (guess != secretWord && !outOfGuesses);
      if (outOfGuesses) 
      {
       Console.WriteLine("You Lose!"); 
      } else
      {
        Console.WriteLine("You Win!");
      }

    }

  }
}