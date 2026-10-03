using System;
using System.Linq;

namespace extensionmethods
{
    public static class StringExtensions
    {
        public static String Shorten(this String str, int numOfWords)
        {
            if (numOfWords < 0)
            {
                throw new ArgumentOutOfRangeException("numOfWords", "why the hell are you passing a negative number you idiot");
            }
            if (numOfWords == 0)
            {
                return "";
            }
            var words = str.Split(' ');
            if (words.Length <= numOfWords)
            {
                return str;
            }

            return string.Join(" ", words.Take(numOfWords)) + "...";
        }
    }
}