using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
public void WordConstructor_InstantiatesWord_AWord()
{
  Word testObject = new Word("test");
  Assert.AreEqual(typeof(Word), testObject.GetType());
}
[TestMethod]
public void TallyScore_CalculateScore_AScore()
{
  Word testWord = new Word("bed");
  Assert.AreEqual(6, testWord.Score);
  
}
  }
}