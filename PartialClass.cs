using System;
using System.Linq;

namespace ConsoleApp1
{
    partial class MainClass
    {
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (Convert.ToBoolean(arr[i]))
                {
                    Console.WriteLine($"{i + 1}: {arr[i]}");
                }
            }
        }
    }

    partial class MyIndexers<T>
    {
        public void PrintItems()
        {
            for (int i = 0; i < items.Length; i++)
            {
                    Console.WriteLine($"{i + 1}: {items[i]}");
            }
        }

        public void Sort()
        {
            Array.Sort(items);
        }

        public void Reverse()
        {
            Array.Reverse(items);
        }

        public T Max()
        {
            return items.Max();
        }

        public T Min()
        {
            return items.Min();
        }
    }
}