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
            _userWord = word.ToLower();
        }

        public string GetUserWord()
        {
            return _userWord;
        }

        public void SetUserPhrase(string word)
        {
            _userPhrase = word.ToLower();
        }

        public string GetUserPhrase()
        {
            return _userPhrase;
        }

        public void IncrementTotalCount()
        {
            _totalCount++;
        }

        public int GetTotalCount()
        {
            return _totalCount;
        }

        public void GetOutcomeLettersInWord()
        {
            foreach (char letterInWord in GetUserWord())
            {
                foreach (char letterInPhrase in GetUserPhrase())
                {
                    if (letterInWord == letterInPhrase) IncrementTotalCount();
                }
            }
        }

        public void GetOutcomeWordsInPhrase()
        {
            char[] specialCharacters = {',', '.', '!', '?', ' ', '"', '-', '(', ')'};
            string[] splitPhrase = GetUserPhrase().Split(specialCharacters);
            foreach (string word in splitPhrase)
            {
                if (GetUserWord() == word) IncrementTotalCount();
            }
        }

    }
}
