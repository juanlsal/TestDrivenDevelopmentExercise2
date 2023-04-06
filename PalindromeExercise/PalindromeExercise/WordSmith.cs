using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalidrome(string word)
        {
            string newWord = word.ToLower();
            
            var reversedWord = string.Empty;
            for (var i = newWord.Length - 1; i >= 0; i--)
            {
                reversedWord += newWord.ToLower()[i];
            }
            if (newWord == reversedWord)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
