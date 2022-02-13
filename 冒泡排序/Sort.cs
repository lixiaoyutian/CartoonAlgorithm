using System;
using static System.Console;
namespace 冒泡排序
{
    public class Sort
    {
        private int[] array;
        public Sort(int[] Array)
        {
            this.array = Array;
        }
        //冒泡法排序
        public void SortArray()
        {
            int LastExChangeIndex = 0;//记录最后交换的位置
            int SortBorder = array.Length - 1;//对比的边界
            for (int i = 0; i < array.Length - 1; i++)
            {
                bool IsSorted = true;
                for (int j = 0; j < SortBorder; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        LastExChangeIndex = j;
                        IsSorted = false;
                    }
                }
                SortBorder = LastExChangeIndex;
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