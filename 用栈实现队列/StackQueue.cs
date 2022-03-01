namespace 用栈实现队列
{
    public class StackQueue<T>
    {
        Stack<T> stackA = new Stack<T>();
        Stack<T> stackB = new Stack<T>();

        public void EnQueue(T num)
        {
            stackA.Push(num);
        }
        public T DeQueue()
        {
            if (stackB.Count == 0)
            {
                if (stackA.Count == 0)
                {
                    return default(T);
                }
                transfer();
            }
            return stackB.Pop();
        }
        protected void transfer()
        {
            while (stackA.Count > 0)
            {
                stackB.Push(stackA.Pop());
            }
        }
    }
}