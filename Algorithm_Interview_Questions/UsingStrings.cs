using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Interview_Questions
{
    class UsingStrings
    {
        /* Let's do a few funny things using strings
         * First: if palindrome or not
         * Second: reverse a string
         */
        #region First
        // a palindrome is a word/sentence that you can read both ways
        // example : lol, kayak, level, redder, madam, etc...

        /// <summary>
        /// Will tell you if "word" is a palindrome
        /// We use recurrence
        /// </summary>
        /// <param name="word">The word to check</param>
        /// <returns>You will get TRUE if "word" is a palindrome</returns>
        public bool PalidromeUsingRecurrence(string word)
        {
            int length = word.Length;

            if(word.ElementAt(0) == word.ElementAt(length-1) && length <= 3)
                return true;
            else if(word.ElementAt(0) == word.ElementAt(length-1))
                return PalidromeUsingRecurrence(word.Substring(1,length-2));

            return false;
        }

        /// <summary>
        /// Will tell you if "word" is a palindrome
        /// We don't use recurrence
        /// We create a table to contain the word
        /// </summary>
        /// <param name="word">The word to check</param>
        /// <returns>You will get TRUE if "word" is a palindrome</returns>
        public bool PalindromeWithoutRecurrence(string word)
        {
            int length = word.Length;
            char[] tableChar = new char[length];

            int i = 0;
            foreach(char c in word)
            {
                tableChar[i] = c;
                i++;
            }

            for(int j = 0 ; j < length / 2 ; j++)
            {
                if(tableChar[j] != tableChar[length - j - 1])
                    return false;
            }
            return true;
        }
        #endregion

        #region Second
        #endregion
    }
}
