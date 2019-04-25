using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class Program
  {

    public static void Main()
    {
      Word newWord = new Word();
      Console.WriteLine("Please enter a word: ");
        string userWord = Console.ReadLine();
        Console.WriteLine("The Scrabble score for  " + userWord  + " is " + newWord.WordScore(userWord) + ".");
        if (newWord.WordScore(userWord) < 10){
          Console.WriteLine("That's weak. Do better.");
        } else {
          Console.WriteLine("I guess that's ok.");
        }

        Main();
    }

  }
}
