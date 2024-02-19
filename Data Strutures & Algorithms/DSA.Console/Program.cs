// See https://aka.ms/new-console-template for more information
using DSA.Lib;

int[] arr = new int[5] { 8, 5, 7, 3, 1 };
Boolean isActive = false;
//Insertion Sort
if (isActive)
    Sorting.InsertionSort(arr);

//Quick Sort
isActive = true;
if (isActive)
    Sorting.QuickSort(arr, 0, arr.Length-1);
