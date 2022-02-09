using 二叉堆;
using static System.Console;
BinaryHead binaryHead = new BinaryHead();
int[] array = new int[] { 1, 3, 2, 6, 5, 7, 8, 9, 10, 0 };
binaryHead.UpAdjust(array);
foreach (var item in array)
{
    Write(item.ToString() + "  ");
}
WriteLine();
array = new int[] { 7, 1, 3, 10, 5, 2, 8, 9, 6 };
binaryHead.buildHeap(array);
foreach (var item in array)
{
    Write(item.ToString() + "  ");
}