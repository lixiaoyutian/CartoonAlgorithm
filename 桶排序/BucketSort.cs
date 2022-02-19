namespace 桶排序
{
    public class BucketSort
    {
        public double[] Sort(double[] array)
        {
            if (array.Length == 0) return array;
            double max = array[0];
            double min = array[0];
            foreach (int i in array)
            {
                if (max < i) max = i;
                if (min > i) min = i;
            }
            double d = max - min;
            int bucketNum = array.Length;
            Dictionary<int, List<double>> dictionary = new Dictionary<int, List<double>>();
            for (int i = 0; i < bucketNum; i++)
            {
                dictionary.Add(i, new List<double>());
            }
            for (int i = 0; i < array.Length; i++)
            {
                int num = (int)((array[i] - min) / (d / (bucketNum - 1)));
                dictionary[num].Add(array[i]);
            }
            foreach (var dic in dictionary)
            {
                dic.Value.Sort();
            }
            double[] SortArray = new double[array.Length];
            int index = 0;
            foreach (var dic in dictionary)
            {
                foreach (var item in dic.Value)
                {
                    SortArray[index++] = item;
                }
            }
            return SortArray;
        }

    }
}