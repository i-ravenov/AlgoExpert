using System;
using System.Linq;
using LinkedListSolutions;
using System.Collections.Generic;

namespace AlgoExpertSolution
{
    class Program
    {
        static void Main()
        {
        }

        public static void PrintLinkedList(LinkedList node)
        {
            while (node != null)
            {
                Console.Write("{0} -> ", node.value);
                node = node.next;
            }
            Console.WriteLine("");
        }

        public static int[] MergeSort(int[] array)
        {
            if (array.Length == 1) return array;
            int halfSize = array.Length / 2;

            int[] left = array.Take(halfSize).ToArray();
            int[] right = array.Skip(halfSize).ToArray();

            return Merge(MergeSort(left), MergeSort(right));
        }

        private static int[] Merge(int[] l, int[] r)
        {
            int[] res = new int[l.Length + r.Length];

            int i = 0, j = 0;
            while (i < l.Length && j < r.Length)
            {
                if (l[i] < r[j])
                {
                    res[i + j] = l[i++];
                }
                else
                {
                    res[i + j] = r[j++];
                }
            }
            while (i < l.Length)
            {
                res[i + j] = l[i++];
            }
            while (j < r.Length)
            {
                res[i + j] = r[j++];
            }
            return res;
        }
    }
}
