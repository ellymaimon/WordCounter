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
        public void GetOutcomeLettersInWord_GetsOutcomeLettersInWord_Int()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string testLetter = "t";
            string testWord = "test";
            testRepeatCounter.SetUserWord(testLetter);
            testRepeatCounter.SetUserPhrase(testWord);
            testRepeatCounter.GetOutcomeLettersInWord();
            Assert.AreEqual(2, testRepeatCounter.GetTotalCount());
        }

        [TestMethod]
        public void GetOutcomeLettersInWord_GetsOutcomeLettersInWordCaseInsensitive_Int()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string testLetter = "t";
            string testWord = "TesterT";
            testRepeatCounter.SetUserWord(testLetter);
            testRepeatCounter.SetUserPhrase(testWord);
            testRepeatCounter.GetOutcomeLettersInWord();
            Assert.AreEqual(3, testRepeatCounter.GetTotalCount());
        }

        [TestMethod]
        public void GetOutcomeLettersInWord_GetsOutcomeNumbersInLargerNumber_Int()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string testNumber = "3";
            string testLargeNumber = "3213";
            testRepeatCounter.SetUserWord(testNumber);
            testRepeatCounter.SetUserPhrase(testLargeNumber);
            testRepeatCounter.GetOutcomeLettersInWord();
            Assert.AreEqual(2, testRepeatCounter.GetTotalCount());
        }

        [TestMethod]
        public void GetOutcomeLettersInWord_GetsOutcomeLettersInMixedWord_Int()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string testLetter = "g";
            string testMixedWord = "3go3go2";
            testRepeatCounter.SetUserWord(testLetter);
            testRepeatCounter.SetUserPhrase(testMixedWord);
            testRepeatCounter.GetOutcomeLettersInWord();
            Assert.AreEqual(2, testRepeatCounter.GetTotalCount());
        }

        [TestMethod]
        public void GetOutcomeWordsInPhrase_GetsOutcomeWordInWord_Int()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string testWord1 = "test";
            string testWord2 = "test";
            testRepeatCounter.SetUserWord(testWord1);
            testRepeatCounter.SetUserPhrase(testWord2);
            testRepeatCounter.GetOutcomeWordsInPhrase();
            Assert.AreEqual(1, testRepeatCounter.GetTotalCount());
        }

        [TestMethod]
        public void GetOutcomeWordsInPhrase_GetsOutcomeeWordInPhrase_Int()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string testWord = "test";
            string testPhrase = "and then test and we do things";
            testRepeatCounter.SetUserWord(testWord);
            testRepeatCounter.SetUserPhrase(testPhrase);
            testRepeatCounter.GetOutcomeWordsInPhrase();
            Assert.AreEqual(1, testRepeatCounter.GetTotalCount());
        }

        [TestMethod]
        public void GetOutcomeWordsInPhrase_GetsOutcomeeWordsInPhrase_Int()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string testWord = "test";
            string testPhrase = "and test then test and we test things";
            testRepeatCounter.SetUserWord(testWord);
            testRepeatCounter.SetUserPhrase(testPhrase);
            testRepeatCounter.GetOutcomeWordsInPhrase();
            Assert.AreEqual(3, testRepeatCounter.GetTotalCount());
        }

        [TestMethod]
        public void GetOutcomeWordsInPhrase_GetsOutcomeeWordsInPhraseCaseInsensitive_Int()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string testWord = "test";
            string testPhrase = "and Test then test and we TEST things tESt";
            testRepeatCounter.SetUserWord(testWord);
            testRepeatCounter.SetUserPhrase(testPhrase);
            testRepeatCounter.GetOutcomeWordsInPhrase();
            Assert.AreEqual(4, testRepeatCounter.GetTotalCount());
        }



    }
}
