namespace 二叉堆队列
{
    /// <summary>
    /// 最大堆
    /// </summary>
    public class PriorityQueue
    {
        private int[] array;
        private int size;
        public PriorityQueue()
        {
            this.array = new int[32];
            this.size = 0;
        }
        //入队
        public void EnQueue(int key)
        {
            if (size >= array.Length)
            {
                ReSize();
            }
            array[size++] = key;
            UpAdjust();
        }
        //出队
        public int DeQueue()
        {
            if (size <= 0)
            {
                throw new Exception("the queue is empty");
            }
            int head = array[0];
            array[0] = array[--size];
            DownAdjust();
            return head;
        }
        //上浮
        public void UpAdjust()
        {
            int childIndex = this.size - 1;
            int parentIndex = (childIndex - 1) / 2;
            int temp = array[childIndex];
            while (childIndex > 0 && temp > array[parentIndex])
            {
                array[childIndex] = array[parentIndex];
                childIndex = parentIndex;
                parentIndex = (parentIndex - 1) / 2;
            }
            array[childIndex] = temp;
        }
        //下沉
        public void DownAdjust()
        {
            int parentIndex = 0;
            int temp = array[parentIndex];
            int childIndex = 1;
            while (childIndex < size)
            {
                if ((childIndex + 1) < size && array[childIndex] < array[childIndex + 1])
                {
                    childIndex++;
                }
                if (temp >= array[childIndex])
                    break;
                array[parentIndex] = array[childIndex];
                parentIndex = childIndex;
                childIndex = 2 * childIndex + 1;
            }
            array[parentIndex] = temp;

        }
        //扩容
        public void ReSize()
        {
            int newSize = this.size * 2;
            int[] newArray = new int[newSize];
            array.CopyTo(newArray, 0);
            this.array = newArray;
        }

    }
}