using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Lib
{
    public static class Palindrome
    {
        public static bool IsPalindrome(string str)
        {
            CustomStack stack = new CustomStack();
            int pos = 0;
            Boolean isPalindrome = false;
            string ch;
            if (str == null) return isPalindrome;

            for (int i = 0; i < str.Length; i++)
                stack.Push(str.Substring(i,1));

            while(stack.Count > 0)
            {
                ch = stack.Pop().ToString();
                if (ch != str.Substring(pos, 1))
                {
                    isPalindrome = false;
                    break;
                }
                else
                    isPalindrome = true;
                pos++;
            }

            return isPalindrome;
        }
    }
}
