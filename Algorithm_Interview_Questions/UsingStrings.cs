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
         */


        // a palindrome is a word/sentence that you can read both ways
        // example : lol, kayak, level, redder, madam, etc...
        public bool Palidrome(string word)
        {
            int length = word.Length;

            if(word.ElementAt(0) == word.ElementAt(length-1) && length <= 3)
                return true;
            else if(word.ElementAt(0) == word.ElementAt(length-1))
                return Palidrome(word.Substring(1,length-2));

            return false;
        }
    }
}
