using static System.Console;

int[] array = new int[] { 2, 6, 3, 4, 5, 10, 9 };
WriteLine(getMaxSortedDistance(array));

int getMaxSortedDistance(int[] array)
{
    int max = array[0];
    int min = array[0];
    foreach (int i in array)
    {
        if (i > max) max = i;
        if (i < min) min = i;
    }
    double d = max - min;
    if (d == 0)
    {
        return 0;
    }
    int bucketNum = array.Length;
    Bucket[] buckets = new Bucket[bucketNum];
    for (int i = 0; i < bucketNum; i++)
    {
        buckets[i] = new Bucket();
    }
    //确定每个桶的最大值和最小值
    for (int i = 0; i < array.Length; i++)
    {
        int index = (int)((array[i] - min) / (d / (bucketNum - 1)));
        if (buckets[index].min == null || buckets[index].min < array[i])
        {
            buckets[index].min = array[i];
        }
        if (buckets[index].max == null || buckets[index].max > array[i])
        {
            buckets[index].max = array[i];
        }
    }
    int leftMax = (int)buckets[0].max;
    int maxDistance = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (buckets[i].min == null)
        {
            continue;
        }
        if (buckets[i].min - leftMax > maxDistance)
        {
            maxDistance = (int)buckets[i].min - leftMax;
        }
        leftMax = (int)buckets[i].max;
    }
    return maxDistance;
}

struct Bucket
{
    public int? min = null;
    public int? max = null;
    public Bucket()
    {

    }
}