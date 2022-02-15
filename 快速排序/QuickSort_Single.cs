namespace 快速排序
{
    public class QuickSort_Single
    {
        public void QuickSort(int[] array, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex) return;
            int pivotIndex = partition(array, startIndex, endIndex);
            QuickSort(array, startIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, endIndex);
        }
        public int partition(int[] array, int startIndex, int endIndex)
        {
            int pivot = array[startIndex];
            int mark = startIndex;
            for (int i = startIndex + 1; i < endIndex; i++)
            {
                if (array[i] < pivot)
                {
                    mark++;
                    int temp = array[i];
                    array[i] = array[mark];
                    array[mark] = temp;
                }
            }
            array[startIndex] = array[mark];
            array[mark] = pivot;
            return mark;
        }
    }
}