using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSolutions
{
    public class DoublyLinkedList
	{
		public Node Head;
		public Node Tail;

		public void SetHead(Node node)
		{
			// Write your code here
		}

		public void SetTail(Node node)
		{
			// Write your code here.
		}

		public void InsertBefore(Node node, Node nodeToInsert)
		{
			// Write your code here.
		}

		public void InsertAfter(Node node, Node nodeToInsert)
		{
			// Write your code here.
		}

		public void InsertAtPosition(int position, Node nodeToInsert)
		{
			// Write your code here.
		}

		public void RemoveNodesWithValue(int value)
		{
			// Write your code here.
		}

		public void Remove(Node node)
		{
			Node current = Head;
			Node previous = null;

			while (current != null)
            {
				if (current.Value.Equals(node.Value))
                {
					if (previous != null)
                    {

                    }
                }

				current = current.Next;
            }
		}

		public bool ContainsNodeWithValue(int value)
		{
			var current = Head;
			while (current != null)
            {
				if (current.Value == value)
                {
					return true;
                }
				current = current.Next;
            }
			return false;
		}
	}
}
