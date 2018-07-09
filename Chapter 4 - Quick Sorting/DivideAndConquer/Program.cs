using System;

namespace DivideAndConquer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = new[] { 2, 6, 4 };
            Console.WriteLine($"Sum: {Sum(items)}");
            Console.WriteLine($"Count: {Count(items)}");
            Console.WriteLine($"Max: {Max(items)}");
        }

        static int Sum(int[] list)
        {
            if (list.Length == 1)
                return list[0];
            else
            {
                int[] newList = new int[list.Length - 1];
                Array.Copy(list, 1, newList, 0, newList.Length);
                return list[0] + Sum(newList);
            }
        }

        static int Count(int[] list)
        {
            if (list.Length == 1)
                return 0;
            else
            {
                int[] newList = new int[list.Length - 1];
                Array.Copy(list, 1, newList, 0, newList.Length);
                return 1 + Count(newList);
            }
        }

        static int Max(int[] list)
        {
            int max = list[0];
            for (int i = 1; i < list.Length; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
            }

            return max;
        }
    }
}
