using System;
using System.Collections;
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

        static void DoInfix2Postfix(string s)
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
        //Works for single digits
        public static string DoEvaluate(string s)
        {
            Stack i = new Stack();
            string answer  = String.Empty;

            int a, b, ans;
            for(int j = 0; j < s.Length; j++)
            {
                String c = s.Substring(j, 1);
                if (c.Equals("*"))
                {
                    String sa = (String)i.Pop();
                    String sb = (String)i.Pop();
                    a = Convert.ToInt32(sa);
                    b = Convert.ToInt32(sb);
                    ans = a * b;
                    i.Push(ans.ToString());
                }else if (c.Equals("/"))
                {
                    String sa = (String)i.Pop();
                    String sb = (String)i.Pop();
                    a = Convert.ToInt32(sa);
                    b = Convert.ToInt32(sb);
                    ans = a / b;
                    i.Push(ans.ToString());
                }
                else if (c.Equals("+"))
                {
                    String sa = (String)i.Pop();
                    String sb = (String)i.Pop();
                    a = Convert.ToInt32(sa);
                    b = Convert.ToInt32(sb);
                    ans = a + b;
                    i.Push(ans.ToString());
                }
                else if (c.Equals("-"))
                {
                    String sa = (String)i.Pop();
                    String sb = (String)i.Pop();
                    a = Convert.ToInt32(sa);
                    b = Convert.ToInt32(sb);
                    ans = a - b;
                    i.Push(ans.ToString());
                }
                else
                {
                    i.Push(c);
                }
            }

            answer = (String)i.Pop ();
            return answer;
        }


    }
}
