using System;
using System.Collections.Generic;

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Music[] items = new[] {
                new Music("Radiohead", 156),
                new Music("Kishore Kumar", 141),
                new Music("Wilco", 111),
                new Music("Neutral Milk Hotel", 94),
                new Music("Beck", 88),
                new Music("The Strokes", 61),
                new Music("The Black Keys", 35)
            };

            foreach (var item in SelectionSort(items))
                Console.WriteLine($"{item.BandName}\t{item.Listens}");

        }

        static (Music band, int listens) FindSmallest(Music[] list)
        {
            Music smallest = list[0];
            int smallest_index = 0;

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] != null && list[i].Listens < smallest.Listens)
                {
                    smallest = list[i];
                    smallest_index = i;
                }
            }

            return (smallest, smallest_index);
        }

        static Music[] SelectionSort(Music[] list)
        {
            Music[] newArray = new Music[list.Length];

            for (int i = 0; i < list.Length; i++)
            {
                var smallest = FindSmallest(list);

                newArray[i] = smallest.band;
                list[smallest.listens] = null;
            }

            return newArray;
        }
    }
}
