using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter;
namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTests
    {
        [TestMethod]
        public void GetSetUserWord_GetSetUserWord_String()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string testWord = "test";
            testRepeatCounter.SetUserWord(testWord);
            Assert.AreEqual(testWord, testRepeatCounter.GetUserWord());
        }

        [TestMethod]
        public void GetSetUserPhrase_GetSetUserPhrase_String()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string testPhrase = "test test test";
            testRepeatCounter.SetUserPhrase(testPhrase);
            Assert.AreEqual(testPhrase, testRepeatCounter.GetUserPhrase());
        }

        [TestMethod]
        public void GetSetTotalCount_GetSetTotalCount_Int()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            int testTotal = 4;
            testRepeatCounter.SetTotalCount(testTotal);
            Assert.AreEqual(testTotal, testRepeatCounter.GetTotalCount());
        }
    }
}
