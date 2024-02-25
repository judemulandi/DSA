// See https://aka.ms/new-console-template for more information
using DSA.Lib;

int[] arr = new int[5] { 8, 5, 7, 3, 1 };
Boolean isActive = false;
//Insertion Sort
if (isActive)
    Sorting.InsertionSort(arr);

//Quick Sort
isActive = false;
if (isActive)
    Sorting.QuickSort(arr, 0, arr.Length-1);

//Mergeable Stack
isActive = false;
if (isActive)
{
    MergeableStack s = new MergeableStack();
    s.Push(5);
    s.Push(7);
    s.Push(3);
    s.Push(1);
    s.display();

    MergeableStack i = new MergeableStack();
    i.Push(11);
    i.Push(141);
    i.Push(500);

    s.merge(i);
    s.display();
}

isActive = true;
if (isActive)
{
    int[] price = { 100, 80, 60, 70, 60, 75, 85 };
    CalculateStockSpan.calculate(price);
}