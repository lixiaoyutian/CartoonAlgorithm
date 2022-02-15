namespace 快速排序
{
    public class QuickSort_Double
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
            int left = startIndex;
            int right = endIndex;
            while (left < right)
            {
                while (left < right && array[right] > pivot) { right--; }
                while (left < right && array[left] <= pivot) { left++; }
                if (left < right)
                {
                    int temp = array[right];
                    array[right] = array[left];
                    array[left] = temp;
                }
            }
            array[startIndex] = array[left];
            array[left] = pivot;
            return left;
        }
    }
}