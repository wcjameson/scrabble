using System;
using Scrabble.Models;

namespace Scrabble
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Enter your Scrabble word!");
      string scrabbleWord = Console.ReadLine();
      Word userWord = new Word(scrabbleWord);
      Console.WriteLine("Your score is " + userWord.Score);

    }
  }
}