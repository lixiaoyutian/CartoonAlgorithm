using static System.Console;
namespace 队列
{
    public class MyQueue
    {
        public int front;
        public int rear;
        public int[] array;
        public MyQueue(int size)
        {
            array = new int[size];
        }
        //入队
        public void EnQueue(int element)
        {
            if ((rear + 1) % array.Length == front)
            {
                throw new Exception("队列已满！");
            }
            array[rear] = element;
            rear = (rear + 1) % array.Length;
        }
        //出队
        public int DeQueue()
        {
            if (rear == front)
            {
                throw new Exception("队列已空!");
            }
            int deQueuement = array[front];
            front = (front + 1) % array.Length;
            return deQueuement;
        }
        //输出队列
        public void OutPut()
        {
            for (int i = front; i != rear; i = (i + 1) % array.Length)
            {
                Write(array[i]);
            }
            WriteLine();
        }
    }
}