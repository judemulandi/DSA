using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Lib
{
    public  class Infix2Postfix
    {
        static int Prec(char c)
        {
            if (c == '*')
                return 3;
            else if (c == '/' || c == '*')
                return 2;
            else if (c == '+' || c == '-')
                return 1;
            else
                return -1;
        }

        static char Associativity(char c)
        {
            if(c == '^')
                return 'R';
            return 'L';
        }

        static void Infix2Postfix(string s)
        {
            Stack<char> stack = new Stack<char>();
            List<char> result = new List<char>();

            for(int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c<= '9'))
                {
                    result.Add(c);
                }

                else if (c == '(')
                {
                    stack.Push(c);
                }
                
                else if(c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        result.Add(stack.Pop());
                    }
                    stack.Pop();
                }

                else
                {
                    while(stack.Count > 0  && (Prec(s[i]) < Prec(stack.Peek()) || Prec(s[i]) == Prec(stack.Peek()) &&
                        Associativity(s[i]) == 'L'))
                    {
                        result.Add(stack.Pop());
                    }
                    stack.Push(c);
                }

            }

            while(stack.Count > 0)
            {
                result.Add(stack.Pop());
            }
            Console.WriteLine(string.Join(", ", result));
        } 


    }
}
