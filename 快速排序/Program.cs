using 快速排序;
using static System.Console;
QuickSort_Double quickSort_Double = new QuickSort_Double();
int[] array = new int[] { 5, 5, 3, 6, 3, 1, 8, 10 };
quickSort_Double.QuickSort(array, 0, array.Length - 1);
foreach (int item in array)
{
    Write(item);
    Write(" ");
}
WriteLine();

QuickSort_Single quickSort_Single = new QuickSort_Single();
array = new int[] { 5, 5, 3, 6, 3, 1, 8, 10 };
quickSort_Single.QuickSort(array, 0, array.Length - 1);
foreach (int item in array)
{
    Write(item);
    Write(" ");
}
WriteLine();

QuickSort_Stack quickSort_Stack = new QuickSort_Stack();
array = new int[] { 5, 5, 3, 6, 3, 1, 8, 10 };
quickSort_Stack.QuickSort(array, 0, array.Length - 1);
foreach (int item in array)
{
    Write(item);
    Write(" ");
}
WriteLine();