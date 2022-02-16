using static System.Console;
namespace 堆排序
{
    public class SortBinary
    {
        public void DownAdjust(int[] array, int parentIndex, int length)
        {
            int temp = array[parentIndex];
            int childIndex = parentIndex * 2 + 1;
            while (childIndex < length)
            {
                if ((childIndex + 1 < length) && array[childIndex] < array[childIndex + 1])
                {
                    childIndex++;
                }
                if (temp >= array[childIndex]) break;
                array[parentIndex] = array[childIndex];
                parentIndex = childIndex;
                childIndex = childIndex * 2 + 1;
            }
            array[parentIndex] = temp;

        }
        public void HeadSort(int[] array)
        {
            for (int i = (array.Length - 2) / 2; i >= 0; i--)
            {
                DownAdjust(array, i, array.Length);
            }
            OutPut(array);
            for (int i = array.Length - 1; i > 0; i--)
            {
                int temp = array[i];
                array[i] = array[0];
                array[0] = temp;
                DownAdjust(array, 0, i);
            }
            OutPut(array);
        }
        public void OutPut(int[] array)
        {
            foreach (int item in array)
            {
                Write(item);
                Write(" ");
            }
            WriteLine();
        }
    }
}