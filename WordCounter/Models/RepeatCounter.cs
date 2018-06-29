using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounter
    {
        private string _userWord; //Word to test against
        private string _userPhrase; //Phrase to find Word in
        private int _totalCount; //Counts up the total to output at the end

        public void SetUserWord(string word)
        {
            _userWord = word;
        }

        public string GetUserWord()
        {
            return _userWord;
        }

        public void SetUserPhrase(string word)
        {
            _userPhrase = word;
        }

        public string GetUserPhrase()
        {
            return _userPhrase;
        }

        public void SetTotalCount(int total)
        {
            _totalCount = total;
        }

        public int GetTotalCount ()
        {
            return _totalCount;
        }


    }
}
