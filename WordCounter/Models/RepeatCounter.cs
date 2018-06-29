using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounter
    {
        private string _userWord;
        private string _userPhrase;
        private string[] _splitPhrase;
        private int _totalCount;

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

        public void GetOutcomePhraseInPhrase()
        {
            string[] SplitWord = GetUserWord().Split(' ');
            SplitPhrase();
            int counter = 0;
            foreach (string word in SplitWord)
            {
                foreach (string otherWord in GetSplitPhrase())
                {
                    if (word == otherWord) counter++;
                }
                int timesToIncrement = counter / SplitWord.Length;
                while (counter < timesToIncrement) IncrementTotalCount();
            }
        }

        public void GetOutcome()
        {
            if (GetUserWord().Length == 1) GetOutcomeLettersInWord();
            else GetOutcomeWordsInPhrase();
        }
    }
}
