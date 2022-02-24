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
      return score;
    }
  }
}