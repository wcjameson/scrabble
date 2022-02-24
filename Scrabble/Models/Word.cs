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

      foreach(char character in characterArray)
      {
        int charScore = CharacterScore(character);
        score = score + charScore;
      }
      return score;
    }

    public int CharacterScore(char character)
    {
      string element = character.ToString();
      Regex test1 = new Regex(@"a|A|e|E|i|I|o|O|u|U|l|L|n|N|r|R|s|S|t|T");
      bool match1 = test1.IsMatch(element);
            Regex test2 = new Regex(@"d|D|g|G");
      bool match2 = test2.IsMatch(element);
            Regex test3 = new Regex(@"b|B|c|C|m|M|p|P");
      bool match3 = test3.IsMatch(element);
            Regex test4 = new Regex(@"f|F|h|H|v|V|w|W|y|Y");
      bool match4 = test4.IsMatch(element);
            Regex test5 = new Regex(@"k|K");
      bool match5 = test5.IsMatch(element);
            Regex test6 = new Regex(@"j|J|x|X");
      bool match6 = test6.IsMatch(element);
            Regex test7 = new Regex(@"q|Q|z|Z");
      bool match7 = test7.IsMatch(element);
      
 
      if (match1)
      {
        return 1;
      } 
      else if (match2)
      {
        return 2;
      }
      else if (match3)
      {
        return 3;
      }
      else if (match4) 
      {
        return 4;
      }
      else if (match5)
      {
        return 5;
      }
      else if (match6)
      {
        return 8;
      }
      else if (match7)
      {
        return 10;
      }
      else
      {
        return 0;
      } 

    }


  }
}