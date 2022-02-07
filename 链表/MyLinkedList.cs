using System;
using static System.Console;
namespace 链表
{
    //链点结构
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    public class MyLinkedList
    {
        private Node Head;
        private Node Last;
        private int Size;
        public MyLinkedList()
        {
            this.Size = 0;
            this.Head = null;
            this.Last = null;
        }
        //添加链点
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.Size == 0)
            {
                this.Head = node;
            }
            if (this.Size > 0)
            {
                this.Last.next = node;
            }
            this.Last = node;
            this.Size++;
        }
        //插入链点
        public void Insert(int index, int data)
        {
            if (index < 0 || index > this.Size)
            {
                throw new Exception("超出范围！");
            }
            Node nodeNew = new Node(data);
            if (index == 0)
            {
                nodeNew.next = this.Head;
                this.Head = nodeNew;
                this.Size++;
            }
            else if (index == this.Size)
            {
                this.Last.next = nodeNew;
                this.Last = nodeNew;
            }
            else
            {
                Node node = GetLink(index - 1);
                nodeNew.next = node.next;
                node.next = nodeNew;
            }
            this.Size++;
        }
        //删除链点
        public Node Remove(int index)
        {
            if (index < 0 || index > this.Size)
            {
                throw new Exception("超出范围！");
            }
            Node node = this.GetLink(index - 1);
            Node nodeOld = node.next;
            node.next = nodeOld.next;
            this.Size--;
            return nodeOld;
        }
        //获取链点
        public Node GetLink(int index)
        {
            if (index < 0 || index > this.Size)
            {
                throw new Exception("超出范围！");
            }
            Node node = this.Head;
            for (int i = 0; i < index; i++)
            {
                node = node.next;
            }
            return node;
        }
        //输出
        public void OutPut()
        {
            Node node = this.Head;
            for (int i = 0; i < this.Size; i++)
            {
                Write(node.data);
                Write(" ");
                node = node.next;
            }
            WriteLine();
        }
    }
}