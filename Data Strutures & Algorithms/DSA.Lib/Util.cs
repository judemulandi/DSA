using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Lib
{
    public class Util
    {
        public static void swap(ref int item1, ref int item2, params int[] arr)
        {
            int temp = arr[item1];
            arr[item1] = arr[item2];
            arr[item2] = temp;
        }
    }
}
