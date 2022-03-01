using 用栈实现队列;
using static System.Console;

StackQueue<int?> stackQueue = new StackQueue<int?>();

stackQueue.EnQueue(1);
stackQueue.EnQueue(2);
stackQueue.EnQueue(3);
stackQueue.EnQueue(4);
WriteLine((int?)stackQueue.DeQueue());
WriteLine((int?)stackQueue.DeQueue());
