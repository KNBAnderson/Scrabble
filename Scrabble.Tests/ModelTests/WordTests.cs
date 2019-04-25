using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;
using System;
using System.Collections.Generic;

namespace Scrabble.Tests
{
  [TestClass]
  public class WordTest
  {

    [TestMethod]
    public void Word_GetLetterScoreA_int()
    {
      // Arrange
      Word newWord = new Word();
      // Act
      int result = newWord.LetterScore('A');
      // Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Word_GetLetterScoreb_int()
    {
      // Arrange
      Word newWord = new Word();
      // Act
      int result = newWord.LetterScore('b');
      // Assert
      Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void Word_SplitWordToArray_charArray()
    {
      // Arrange
      Word newWord = new Word();
      char[] testArray = {'t','e','s','t'};
      // Act
      char[] result = newWord.WordToCharacters("test");
      // Assert
      //Collection here will test array specifically
      CollectionAssert.AreEqual(testArray, result);
    }

    [TestMethod]
    public void Word_GetWordScore_int()
    {
      // Arrange
      Word newWord = new Word();

      // Act
      int result = newWord.WordScore("test");
      // Assert
      Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void Word_GetWordScoreLonger_int()
    {
      // Arrange
      Word newWord = new Word();

      // Act
      int result = newWord.WordScore("supercalifragilisticexpialidocious");
      // Assert
      Assert.AreEqual(56, result);
    }
  }
}
