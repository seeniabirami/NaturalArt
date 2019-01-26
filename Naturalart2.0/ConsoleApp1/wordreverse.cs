using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class wordreverse
    {
        public static bool isPalindrome(String word)
        {
            word = word.ToLower();
            String myword = "";
            bool result = false;
            for (int i = word.Length - 1; i >= 0; i--)
            {

                myword = myword + word.ElementAt(i);
            }

            if (word == (myword))
            {

                result = true;
            }
            return result;
        }
    }
}
