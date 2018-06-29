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
            string test = "test";
            testRepeatCounter.SetUserWord(test);
            Assert.AreEqual("test", testRepeatCounter.GetUserWord());
        }
    }
}
