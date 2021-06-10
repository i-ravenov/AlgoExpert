using NUnit.Framework;
using LinkedListSolutions;
using System;

namespace Tests
{
    public class Tests
    {

        public static void PrintLinkedList(LinkedList node)
        {
            while (node != null)
            {
                Console.Write("{0} -> ", node.value);
                node = node.next;
            }
            Console.WriteLine("");
        }

        [Test]
        public void Test1()
        {

            LinkedList node = new LinkedList(1);
            LinkedList node2 = new LinkedList(1);
            var node3 = new LinkedList(3);
            var node4 = new LinkedList(4);
            var node5 = new LinkedList(4);
            var node6 = new LinkedList(4);
            var node7 = new LinkedList(5);
            var node8 = new LinkedList(6);
            var node9 = new LinkedList(6);

            node.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            node5.next = node6;
            node6.next = node7;
            node7.next = node8;
            node8.next = node9;
            PrintLinkedList(node8);
            PrintLinkedList(node);


            PrintLinkedList(LinkedList.RemoveDuplicatesFromLinkedList(node));


            Assert.Pass();
        }
    }
}