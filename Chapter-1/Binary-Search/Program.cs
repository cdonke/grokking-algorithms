using System;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myList = new[] { 1, 3, 5, 7, 9 };

            Console.WriteLine($"Index of 3 is {binary_search(myList, 3)}");

            Console.WriteLine($"Index of 2 is {binary_search(myList, 2)}");

        }


        static int binary_search(int[] list, int item)
        {
            int low = 0;
            int high = list.Length - 1;
            int mid, guess;

            while (low <= high)
            {
                mid = (low + high) / 2;
                guess = list[mid];

                if (guess == item)
                    return mid;
                else if (guess > item)
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return -1;
        }
    }
}
