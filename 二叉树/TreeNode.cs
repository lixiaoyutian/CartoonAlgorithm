using System.Collections.Generic;
using System;
using static System.Console;
namespace 二叉树
{
    public class TreeNode
    {
        public int data;
        public TreeNode leftChild;
        public TreeNode rightChild;
        public TreeNode(int data)
        {
            this.data = data;
            this.leftChild = null;
            this.rightChild = null;
        }
    }
    public class TreeNodeManage
    {
        private TreeNode Node;
        public TreeNodeManage()
        {

        }
        public TreeNodeManage(List<int?> treeNode)
        {
            Node = CreateTreeNode(treeNode);
        }
        //创建二叉树
        public TreeNode CreateTreeNode(List<int?> treeNode)
        {
            TreeNode node = null;
            if (treeNode == null || treeNode.Count == 0)
            {
                return null;
            }
            int? data = treeNode[0];
            treeNode.RemoveAt(0);
            if (data != null)
            {
                node = new TreeNode((int)data);
                node.leftChild = CreateTreeNode(treeNode);
                node.rightChild = CreateTreeNode(treeNode);
            }
            return node;
        }
        //遍历二叉树
        public void Traveral(int kind)
        {
            switch (kind)
            {
                case 1:
                    preTraveral(this.Node); break;
                case 2:
                    inTraveral(this.Node); break;
                case 3:
                    postTraveral(this.Node); break;
                case 4:
                    stackPreTraveral(this.Node); break;
                case 5:
                    queuePreTraveral(this.Node); break;
            }
        }
        //前序遍历
        private void preTraveral(TreeNode node)
        {
            if (node == null) return;
            Write(node.data);
            preTraveral(node.leftChild);
            preTraveral(node.rightChild);
        }
        //中序遍历
        private void inTraveral(TreeNode node)
        {
            if (node == null) return;
            inTraveral(node.leftChild);
            Write(node.data);
            inTraveral(node.rightChild);
        }
        //后序遍历
        private void postTraveral(TreeNode node)
        {
            if (node == null) return;
            postTraveral(node.leftChild);
            postTraveral(node.rightChild);
            Write(node.data);
        }
        //堆栈前序遍历
        private void stackPreTraveral(TreeNode node)
        {
            Stack<TreeNode> stackTreeNode = new Stack<TreeNode>();
            TreeNode treeNode = node;
            while (treeNode != null || stackTreeNode.Count > 0)
            {
                while (treeNode != null)
                {
                    Write(treeNode.data + " ");
                    stackTreeNode.Push(treeNode);
                    treeNode = treeNode.leftChild;
                }
                if (stackTreeNode.Count > 0)
                {
                    treeNode = stackTreeNode.Pop();
                    treeNode = treeNode.rightChild;
                }
            }
        }
        //队列层次遍历
        private void queuePreTraveral(TreeNode node)
        {
            Queue<TreeNode> queueTreeNode = new Queue<TreeNode>();
            TreeNode treeNode = node;
            queueTreeNode.Enqueue(treeNode);
            while (queueTreeNode.Count > 0)
            {
                treeNode = queueTreeNode.Dequeue();
                if (treeNode != null)
                {
                    Write(treeNode.data + " ");
                    if (treeNode.leftChild != null)
                    {
                        queueTreeNode.Enqueue(treeNode.leftChild);
                    }
                    if (treeNode.rightChild != null)
                    {
                        queueTreeNode.Enqueue(treeNode.rightChild);
                    }
                }
            }
        }
    }
}