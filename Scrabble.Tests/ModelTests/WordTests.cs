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
    public void Word_GetLetterScore_int()
    {
      // Arrange
      Word newWord = new Word();
      // Act
      int result = newWord.LetterScore('A');
      // Assert
      Assert.AreEqual(1, result);
    }

  }
}
