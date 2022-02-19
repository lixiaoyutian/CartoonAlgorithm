using 计数排序;
using static System.Console;
int[] array = new int[] { 5, 5, 3, 6, 3, 1, 8, 10, 9, 4, 1, 2 };
CountSort countSort = new CountSort();
array = countSort.Sort(array);
foreach (int i in array)
{
    Write(i);
    Write(" ");
}
WriteLine();