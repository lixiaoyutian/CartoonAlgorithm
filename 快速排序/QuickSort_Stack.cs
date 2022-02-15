namespace 快速排序
{
    public class QuickSort_Stack
    {
        public void QuickSort(int[] array, int startIndex, int endIndex)
        {
            Stack<Dictionary<string, int>> stack = new Stack<Dictionary<string, int>>();
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("startIndex", startIndex);
            dic.Add("endIndex", endIndex);
            stack.Push(dic);
            while (stack.Count > 0)
            {
                Dictionary<string, int> dicTemp = stack.Pop();
                int pivotIndex = partition(array, dicTemp["startIndex"], dicTemp["endIndex"]);
                if (dicTemp["startIndex"] < pivotIndex - 1)
                {
                    Dictionary<string, int> leftDic = new Dictionary<string, int>();
                    leftDic.Add("startIndex", dicTemp["startIndex"]);
                    leftDic.Add("endIndex", pivotIndex - 1);
                    stack.Push(leftDic);
                }
                if (dicTemp["endIndex"] > pivotIndex + 1)
                {
                    Dictionary<string, int> rightDic = new Dictionary<string, int>();
                    rightDic.Add("startIndex", pivotIndex + 1);
                    rightDic.Add("endIndex", dicTemp["endIndex"]);
                    stack.Push(rightDic);
                }
            }
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