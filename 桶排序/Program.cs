using static System.Console;
using 桶排序;
BucketSort bucketSort = new BucketSort();
double[] array = new double[] { 4.12, 6.421, 0.0023, 3.0, 2.123, 8.122, 4.12, 10.09 };
array = bucketSort.Sort(array);
foreach (double value in array)
{
    Write(value);
    Write(" ");
}
WriteLine();