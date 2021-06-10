using System;

namespace LinkedListSolutions
{
    public partial class LinkedList
	{

		public static LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList)
		{
			if (linkedList == null)
            {
				return null;
            }

			var node = linkedList;
			var head = node;

			while (linkedList != null)
            {
				var i = linkedList.value;
				while (linkedList.next != null && i == linkedList.next.value)
                {
					linkedList = linkedList.next;
                }
				node.next = linkedList.next;
				node = node.next;
				linkedList = linkedList.next;
            }
			return head;
		}
	}
}
