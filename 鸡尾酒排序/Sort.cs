using System;
using static System.Console;
namespace 鸡尾酒排序
{
    public class Sort
    {
        private int[] array;
        public Sort(int[] Array)
        {
            this.array = Array;
        }
        //鸡尾酒排序
        public void SortArray()
        {
            int LeftLastExChangeIndex = 0;//从左开始的记录最后交换的位置
            int LeftSortBorder = array.Length - 1;//左边对比的边界
            int RightLastExChangeIndex = array.Length - 1;//从右开始的记录最后交换的位置
            int RightSortBorder = 0;//右边对比的边界
            for (int i = 0; i < array.Length / 2; i++)
            {
                bool IsSorted = true;
                for (int j = i; j < LeftSortBorder; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        LeftLastExChangeIndex = j;
                        IsSorted = false;
                    }
                }
                LeftSortBorder = LeftLastExChangeIndex;
                if (IsSorted) break;
                IsSorted = true;
                for (int j = array.Length - i - 1; j > RightSortBorder; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                        RightLastExChangeIndex = j;
                        IsSorted = false;
                    }
                }
                RightSortBorder = RightLastExChangeIndex;
                if (IsSorted) break;
            }
        }
        public void OutPut()
        {
            foreach (int item in array)
            {
                Write(item);
                Write("  ");
            }
            WriteLine();
        }
    }
}