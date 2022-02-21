using static System.Console;
using 判断链表是否有环;
Node node1 = new Node(5);
Node node2 = new Node(3);
Node node3 = new Node(7);
Node node4 = new Node(2);
Node node5 = new Node(6);
node1.next = node2;
node2.next = node3;
node3.next = node4;
node4.next = node5;
node5.next = node2;
Write(isCycle(node1));



bool isCycle(Node Head)
{
    Node p1 = Head;
    Node p2 = Head;
    while (p2 != null && p2.next != null)
    {
        p1 = p1.next; ;
        p2 = p2.next.next;
        if (p1 == p2) return true;
    }
    return false;
}