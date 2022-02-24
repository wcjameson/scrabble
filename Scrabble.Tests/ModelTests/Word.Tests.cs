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
  }
}