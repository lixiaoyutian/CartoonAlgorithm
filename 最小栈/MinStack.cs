namespace 最小栈
{
    public class MinStack
    {
        private Stack<int> mainStack = new Stack<int>();
        private Stack<int> minStack = new Stack<int>();

        public void Push(int value)
        {
            mainStack.Push(value);
            if (minStack.Count == 0 || (minStack.Count > 0 && value <= minStack.Peek()))
            {
                minStack.Push(value);
            }
        }
        public int Pop()
        {
            if (mainStack.Peek().Equals(minStack.Peek()))
            {
                minStack.Pop();
            }
            return mainStack.Pop();
        }

        public int GetMinValue()
        {
            if (mainStack.Count == 0)
            {
                throw new Exception("Stack is empty.");
            }
            return minStack.Peek();
        }
    }
}