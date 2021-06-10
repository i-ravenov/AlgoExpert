using System;
using System.Linq;

namespace DynamicProgramming
{
    class Program
    {
        static void Main()
        {
            int w = 4;
            int h = 3;
            Console.WriteLine(NumberOfWaysToTraverseGraph2(w, h));
        }

        public static int MaxSubsetSumNoAdjacent(int[] array)
        {
            int n = array.Length;
            if (n == 0) return 0;
            if (n == 1) return array[0];
            if (n == 2) return Math.Max(array[0], array[1]);

            return Math.Max(MaxSubsetSumNoAdjacent(array.Take(n - 2).ToArray()) + array[n - 1],
                MaxSubsetSumNoAdjacent(array.Take(n - 1).ToArray()));
        }

        public static int MaxSubsetSumNoAdj(int[] ar)
        {
            int[] max = new int[ar.Length];
            max[0] = ar[0];
            max[1] = Math.Max(ar[0], ar[1]);
            for (int i = 2; i < ar.Length; i++)
                max[i] = Math.Max(max[i - 2] + ar[i], max[i - 1]);
            return max.Max();
        }

        public static int NumberOfWaysToMakeChange(int n, int[] denoms)
        {
            Array.Sort(denoms);
            if (n == 0) return 1;
            if (denoms.Length == 1) return n % denoms[0] == 0 ? 1 : 0;
            return NumberOfWaysToMakeChange(n - denoms[0], denoms) +
                NumberOfWaysToMakeChange(n, denoms.Skip(1).ToArray());
        }

        public static int NumberOfWaysToMakeChange1(int n, int[] denoms)
        {
            int[] ways = new int[n + 1];
            ways[0] = 1;
            foreach (int denom in denoms)
            {
                for (int amount = 1; amount < n + 1; amount++)
                {
                    if (denom <= amount)
                    {
                        ways[amount] += ways[amount - denom];
                    }
                }
            }
            return ways[n];
        }

        public static int MinNumberOfCoinsForChange(int n, int[] denoms)
        {
            int[] min = new int[n + 1];
            Array.Fill(min, int.MaxValue);
            min[0] = 0;

            foreach (int denom in denoms)
            {
                for (var i = 1; i < n + 1; i++)
                {
                    if (denom <= i)
                    {
                        min[i] = Math.Min(min[i - denom] + 1, min[i]);
                    }
                }
            }
            return min[n];
        }


        public static int NumberOfWaysToTraverseGraph(int width, int height)
        {
            if (width == 1 || height == 1)
            {
                return 1;
            }
            return NumberOfWaysToTraverseGraph(width - 1, height) +
                NumberOfWaysToTraverseGraph(width, height - 1);
        }

        public static int NumberOfWaysToTraverseGraph2(int width, int height)
        {
            int[,] ways = new int[width + 1, height + 1];
            for (int i = 0; i < width + 1; i++)
            {
                ways[i, 0] = 1;
            }
            for (int j = 0; j < height + 1; j++)
            {
                ways[0, j] = 1;
            }

            for (int i = 1; i < ways.GetLength(0); i++)
            {
                for (int j = 1; j < ways.GetLength(1); j++)
                {
                    ways[i, j] = ways[i - 1, j] + ways[i, j - 1];
                }
            }
            return ways[width - 1, height - 1];
        }

        public static int LevenshteinDistance(string str1, string str2)
        {
            int[,] d = new int[str1.Length + 1, str2.Length + 1];
            for (int i = 0; i < d.GetLength(0); i++)
            {
                d[i, 0] = i;
            }
            for (int j = 0; j < d.GetLength(1); j++)
            {
                d[0, j] = j;
            }
            for (int i = 1; i < d.GetLength(0); i++)
            {
                for (int j = 1; j < d.GetLength(1); j++)
                {
                    if (str1[i - 1] == str2[j - 1])
                    {
                        d[i, j] = d[i - 1, j - 1];
                    }
                    else
                    {
                        d[i, j] = 1 + Math.Min(Math.Min(d[i - 1, j], d[i, j - 1]), d[i - 1, j - 1]);
                    }
                }
            }

            return d[str1.Length, str2.Length];
        }
    }
}
