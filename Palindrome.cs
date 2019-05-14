using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Palindrome.Web
{
    public class Palindrome
    {
        bool IsPalindrome(string userInput, string userInputReversed)
        {
            try
            {
                string textInfo = string.Empty;
                char[] chArray = msg.ToCharArray();
                char[] PalChar = new char[chArray.Length];
                PalChar = chArray;
                textInfo = msg;

                Array.Reverse(PalChar, 0, PalChar.Length);
                new string(PalChar);
                if (userInput == userInputReversed)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error Occurred");
                return false;


            }

        }
    }
}