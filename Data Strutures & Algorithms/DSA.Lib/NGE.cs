using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Lib
{
    //Next Greatest Element
    public class NGE
    {
        public static void DoFindNGE(int[] arr)
        {
            if (arr == null) return;

            Stack st = new Stack();
            int[] result = new int[arr.Length];
            st.Push(arr[0]);
            int next, element;
            for(int i = 1; i < arr.Length; i++)
            {
                next = arr[i];
                if(st.Count > 0)
                {
                    element = Convert.ToInt32(st.Pop());
                    
                    while(element < next)
                    {
                        Console.WriteLine(element+"-->"+next);
                        if(st.Count == 0)
                        {
                            break;
                        }
                        element = Convert.ToInt32(st.Pop());
                    }

                    if(element > next)
                    {
                        st.Push(element);
                    }
                }
                st.Push(next);
            }

            while(st.Count > 0)
            {
                element = Convert.ToInt32(st.Pop());
                next = -1;
                Console.WriteLine(element + "-->" + next);
            }



        }
    }
}
