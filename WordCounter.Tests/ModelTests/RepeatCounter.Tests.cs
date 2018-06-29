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
        public void IncrementGetTotalCount_IncrementGetTotalCount_Int()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            int testTotal = 4;
            while(testRepeatCounter.GetTotalCount() < 4) testRepeatCounter.IncrementTotalCount();
            Assert.AreEqual(testTotal, testRepeatCounter.GetTotalCount());
        }

        [TestMethod]
        public void GetOutcome_GetsOutcomeLettersInWord_Int()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string testLetter = "t";
            string testWord = "test";
            testRepeatCounter.SetUserWord(testLetter);
            testRepeatCounter.SetUserPhrase(testWord);
            testRepeatCounter.GetOutcome();
            Assert.AreEqual(2, testRepeatCounter.GetTotalCount());
        }

        [TestMethod]
        public void GetOutcome_GetsOutcomeLettersInWordCaseInsensitive_Int()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string testLetter = "t";
            string testWord = "TesterT";
            testRepeatCounter.SetUserWord(testLetter);
            testRepeatCounter.SetUserPhrase(testWord);
            testRepeatCounter.GetOutcome();
            Assert.AreEqual(3, testRepeatCounter.GetTotalCount());
        }

        [TestMethod]
        public void GetOutcome_GetsOutcomeNumbersInLargerNumber_Int()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string testNumber = "3";
            string testLargeNumber = "3213";
            testRepeatCounter.SetUserWord(testNumber);
            testRepeatCounter.SetUserPhrase(testLargeNumber);
            testRepeatCounter.GetOutcome();
            Assert.AreEqual(2, testRepeatCounter.GetTotalCount());
        }

        [TestMethod]
        public void GetOutcome_GetsOutcomeLettersInMixedWord_Int()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string testLetter = "g";
            string testMixedWord = "3go3go2";
            testRepeatCounter.SetUserWord(testLetter);
            testRepeatCounter.SetUserPhrase(testMixedWord);
            testRepeatCounter.GetOutcome();
            Assert.AreEqual(2, testRepeatCounter.GetTotalCount());
        }


    }
}
