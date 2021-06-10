using System;

namespace Stack
{
    public class MinMaxStack
    {
        private class Node
        {
            int _data;
            Node _next;

            public Node(int data, Node next)
            {
                _data = data;
                _next = next;
            }
        }

        private Node top;
        private int max;
        private int min;
        private int count;

        public MinMaxStack()
        {
            top = null;
            count = 0;

        }

        public int Peek()
        {
            // Write your code here.
            return -1;
        }

        public int Pop()
        {
            // Write your code here.
            return -1;
        }


        public void Push(int number)
        {
            top = new Node(number, top);
        }


        public int GetMin()
        {
            // Write your code here.
            return -1;
        }


        public int GetMax()
        {
            // Write your code here.
            return -1;
        }
    }
}