using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounter
    {
        private string _userWord; //Word to test against
        private string _userPhrase; //Phrase to find Word in
        private string[] _splitPhrase; //Phrase split into an array of words
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

        public void SplitPhrase()
        {
            char[] specialCharacters = {',', '.', '!', '?', ' ', '"', '-', '(', ')'};
            _splitPhrase = GetUserPhrase().Split(specialCharacters);
        }

        public string[] GetSplitPhrase()
        {
            return _splitPhrase;
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
            SplitPhrase();
            foreach (string word in GetSplitPhrase())
            {
                if (GetUserWord() == word) IncrementTotalCount();
            }
        }

        public void GetOutcome()
        {
            if (GetUserWord().Length == 1) GetOutcomeLettersInWord();
            else GetOutcomeWordsInPhrase();
        }

    }
}
