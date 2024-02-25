using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Lib
{
    //Understanding the stock span problem
    //https://www.codingninjas.com/studio/library/understanding-stock-span
    public class CalculateStockSpan
    {
        //Using an array
        public static void calculate(int[] arr)
        {
            int[] temp = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = 1;
                for(int j = i-1; j > 0; j--)
                {
                    if (arr[j] <= arr[i])
                    {
                        temp[i] = temp[i] + 1;
                    }
                }
            }

            for(int j = 0;j < temp.Length; j++)
            {
                Console.WriteLine(temp[j] + " ");
            }

        }

        //Using a stack
        public static void StackCalculate(int[] arr)
        {
            Stack st = new Stack();
            st.Push(0);
            int[] result = new int[arr.Length];
            for(int i = 1; i < arr.Length; i++)
            {

                while(st.Count > 0 && arr[(int)st.Peek()] <= arr[i])
                {
                    st.Pop();
                }

                result[i] = (st.Count == 0) ? (i + 1) : (i - (int)st.Peek());

                st.Push(i);
            }

        }

    }
}
