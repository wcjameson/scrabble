using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

namespace Scrabble.Models
{
  public class Word
  {
    public string Term;
    public int Score;
    

    public Word(string term)
    {
      Term = term;
      Score = TallyScore(term);
    }

    private int TallyScore(string term) 
    {
      int score = 0;
      char[] characterArray = term.ToCharArray();

      foreach(string character in characterArray)
      {
        int charScore = CharacterScore(character);
        score = score + charScore;
      }
      return score;
    }

    public int CharacterScore(string character)
    {
      Regex test1 = new Regex(@"/a|e|i|o|u|l|n|r|s|t/gmi");
      Match match1 = test1.Match(character);
      if (match1.Success)
      {
        return 1;
      } 
      else
      {
        return 0;
      } 

    }


  }
}