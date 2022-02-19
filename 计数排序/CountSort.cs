namespace 计数排序
{
    public class CountSort
    {
        //优化前的计数排序
        public int[] Sort(int[] array)
        {
            if (array.Length == 0) return array;
            int max = array[0];
            foreach (int i in array)
                if (max < i) max = i;
            int[] CountArray = new int[max + 1];
            foreach (int i in array)
            {
                CountArray[i]++;
            }
            //排序后的数组
            int index = 0;
            for (int i = 0; i < CountArray.Length; i++)
            {
                for (int j = 0; j < CountArray[i]; j++)
                {
                    array[index++] = i;
                }
            }
            return array;
        }

        //优化后的计数排序
        public int[] SortYH(int[] array)
        {
            if (array.Length == 0) return array;
            int max = array[0];
            int min = array[0];
            foreach (int i in array)
            {
                if (max < i) max = i;
                if (min > i) min = i;
            }
            int d = max - min;
            int[] CountArray = new int[d + 1];
            foreach (int i in array)
            {
                CountArray[i - min]++;
            }
            for (int i = 1; i < CountArray.Length; i++)
            {
                CountArray[i] += CountArray[i - 1];
            }
            //排序后的数组
            int[] SortArray = new int[array.Length];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                SortArray[CountArray[array[i] - min] - 1] = array[i];
                CountArray[array[i] - min]--;
            }
            return SortArray;
        }
    }
}