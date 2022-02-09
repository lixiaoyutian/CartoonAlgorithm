namespace 二叉堆
{
    public class BinaryHead
    {
        //二叉堆上浮
        public void UpAdjust(int[] array)
        {
            int childIndex = array.Length - 1;
            int parentIndex = (childIndex - 1) / 2;
            int temp = array[childIndex];
            while (childIndex > 0 && temp < array[parentIndex])
            {
                array[childIndex] = array[parentIndex];
                childIndex = parentIndex;
                parentIndex = (parentIndex - 1) / 2;
            }
            array[childIndex] = temp;
        }
        //二叉堆下沉
        public void DownAdjust(int[] array, int length, int parentIndex)
        {
            int temp = array[parentIndex];
            int childIndex = parentIndex * 2 + 1;
            while (childIndex < length)
            {
                if ((childIndex + 1) < length && array[childIndex] > array[childIndex + 1])
                {
                    childIndex++;
                }
                if (array[childIndex] >= temp)
                {
                    break;
                }
                array[parentIndex] = array[childIndex];
                parentIndex = childIndex;
                childIndex = childIndex * 2 + 1;
            }
            array[parentIndex] = temp;
        }
        //构造二叉堆
        public void buildHeap(int[] array)
        {
            for (int i = (array.Length - 2) / 2; i >= 0; i--)
            {
                DownAdjust(array, array.Length, i);
            }
        }
    }
}