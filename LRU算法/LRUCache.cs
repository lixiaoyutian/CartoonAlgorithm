using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LRU算法
{
    class Node
    {
        public Node pre;
        public Node next;
        public string Key;
        public string Value;
        public Node(string Key, string Value)
        {
            this.Key = Key;
            this.Value = Value;
        }
    }
    public class LRUCache
    {
        private Node Head;
        private Node End;
        private int Limit = 0;
        private Hashtable hashtable;
        public LRUCache()
        {

        }
        public LRUCache(int limit)
        {
            this.Limit = limit;
            hashtable = new Hashtable();
        }

        public string Get(string key)
        {
            Node node = (Node)hashtable[key];
            if (node == null)
            {
                return null;
            }
            RefreshNode(node);
            return node.Value;
        }

        public void Put(string key, string value)
        {
            Node node = null;
            if (hashtable.ContainsKey(key))
            {
                node = (Node)hashtable[key];
            }
            if (node == null)
            {
                if (hashtable.Count >= Limit)
                {
                    hashtable.Remove(Head.Key);
                    RemoveNode(Head);
                }
                node = new Node(key, value);
                AddNode(node);
            }
            else
            {
                node.Value = value;
                RefreshNode(node);
            }
        }


        private void RefreshNode(Node node)
        {
            RemoveNode(node);
            AddNode(node);
        }
        private void RemoveNode(Node node)
        {
            if (Head == node && End == node)
            {
                Head = null;
                End = null;
            }
            else if (End == node)
            {
                End = End.pre;
                End.next = null;
            }
            else if (node == Head)
            {
                Head = Head.next;
                Head.pre = null;
            }
            else
            {
                node.pre.next = node.next;
                node.next.pre = node.pre;
            }
            hashtable.Remove(node.Key);
        }
        private void AddNode(Node node)
        {
            if (End != null)
            {
                End.next = node;
                node.pre = End;
                node.next = null;
            }
            End = node;
            if (Head == null)
            {
                Head = node;
            }
            hashtable.Add(node.Key, node);
        }
    }
}