using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Lib
{
    public static class Sorting
    {
        public static void InsertionSort(params int[] arr)
        {
            Console.WriteLine("Unsorted Array...");
            
            PrintArray(arr);

            int i, j, temp;
            for(i = 0; i < arr.Length - 1; i++)
            {
                for(j = i + 1; j > 0; j--)
                {
                    if (arr[j-1] > arr[j])
                    {
                        temp = arr[j-1];
                        arr[j -1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }


            Console.WriteLine("Sorted Array...");
            PrintArray(arr);
        }

        public static void QuickSort(int[] arr, int left, int right)
        {
            Console.WriteLine("Unsorted Array...");
            PrintArray(arr);

            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    QuickSort(arr, left, pivot - 1);
                }

                if(pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right);
                }

            }

            Console.WriteLine("Sorted Array...");
            PrintArray(arr);
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];

            while(true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if(left < right)
                {
                    if (arr[left] == arr[right]) return right;
                    
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }

            }

        }

        public static void PrintArray(params int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("");
        }


    }
}
