using System;
using System.Linq;

namespace CodeWars
{
    public class CodeKatas
    {
        //An isogram is a word that has no repeating letters, consecutive or non-consecutive.
        // Implement a function that determines whether a string that contains only letters is an isogram.
        // Assume the empty string is an isogram. 
        // Ignore letter case.
        public bool IsIsogram(string str)
        {
            //Check the string length, if length is different from char array
            //then return false
            int stringLength = str.ToLower().Length;
            int stringArrayLength = new String(str.ToLower().Distinct().ToArray()).Length;

            return (stringLength == stringArrayLength) ? true : false;
        }

        /*
         *For inputString = "aabaa", the output should be
            checkPalindrome(inputString) = true;
            For inputString = "abac", the output should be
            checkPalindrome(inputString) = false;
            For inputString = "a", the output should be
            checkPalindrome(inputString) = true.
         */
        public bool IsPalindrome(string input)
        {
            var inputCharacterArray = input.ToCharArray();

            Array.Reverse(inputCharacterArray);
            
            string currentString = new string(inputCharacterArray);

            if (input == currentString)
            {
                return true;
            }
            return false;
        }
    }
}