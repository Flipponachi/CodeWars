using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(CodeWars.IsIsogram("MooOse"));

            ReadLine();
        }
    }

       //An isogram is a word that has no repeating letters, consecutive or non-consecutive.
       // Implement a function that determines whether a string that contains only letters is an isogram.
       // Assume the empty string is an isogram. 
       // Ignore letter case.

    static class CodeWars
    {
        public static bool IsIsogram(string str)
        {
            //Check the string length, if length is different from char array
            //then return false
            int stringLength = str.ToLower().Length;
            int stringArrayLength = new String(str.ToLower().Distinct().ToArray()).Length;

            if (stringLength == stringArrayLength)
            {
                return true;
            }
            else if (stringLength > stringArrayLength)
            {
                return false;
            }
            return true;
        } 
    }


}
