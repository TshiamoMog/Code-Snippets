using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnipetsApplication
{
    internal class StringManipulator
    {
        readonly private string inputString;

        #region Constructor
        public StringManipulator(string input)
        {
            inputString = input;
        }
        #endregion

        #region Reverse Letters
        public void ReverseLetters()
        {
            string[] words = inputString.Split(' ');
            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                char[] letters = word.ToCharArray();
                Array.Reverse(letters);
                result.Append(letters);
                result.Append(' ');
            }
            Console.WriteLine();
            Console.WriteLine(result);
        }
        #endregion

        #region Reverse Words
        public void ReverseWords()
        {
            string[] words = inputString.Split(' ');
            Array.Reverse(words);
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", words));
        }
        #endregion

        #region Reverse Letters and Words
        public void ReverseLettersAndWords()
        {
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine();
            Console.WriteLine(charArray);
        }
        #endregion

        #region Count Words
        public void CountWords()
        {
            string[] words = inputString.Split(' ', '.', ',', '!', '?');
            int wordCount = words.Length;
            Console.WriteLine("Word Count: " + wordCount);
        }
        #endregion

        #region UpperCase
        public void ConvertToUpper()
        {
            Console.WriteLine("Uppercase String: " + inputString.ToUpper());
        }
        #endregion

        #region LowerCase
        public void ConvertToLower()
        {
            Console.WriteLine("Lowercase String: " + inputString.ToLower());
        }
        #endregion
    }
}
