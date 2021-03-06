﻿using System;
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

        /*
         * A digital root is the recursive sum of all the digits in a number.
         * Given n, take the sum of the digits of n.
         * If that value has two digits, continue reducing in this way until a single-digit number is produced.
         * This is only applicable to the natural numbers.
         * digital_root(16)
            => 1 + 6
            => 7
            digital_root(942)
            => 9 + 4 + 2
            => 15 ...
            => 1 + 5
            => 6
           
         */
        
        public int DigitalRoot(long n)
        {
            //Split into character array
            
            string inputValueString = n.ToString();
            var stringChar = inputValueString.ToCharArray();
            
            //value of input
            int recursiveSum = 0;
            

            for (int i = 0; i < stringChar.Length; i++)
            {
                int currentValue = (int)char.GetNumericValue(stringChar[i]);
                recursiveSum += currentValue;
                
            }

          
            while (recursiveSum > 10)
            {
                return DigitalRoot(recursiveSum);
            }
           
            return recursiveSum;
        }
        
        /*
         * Given an array of integers, find the pair of adjacent elements that has the largest product and return that product.
         * Example For inputArray = [3, 6, -2, -5, 7, 3], the output should be adjacentElementsProduct(inputArray) = 21
           7 and 3 produce the largest product.
         */
        public int AdjacentElementsProduct(int[] arrayOfInts)
        {
            return 2;
        }
    }
}