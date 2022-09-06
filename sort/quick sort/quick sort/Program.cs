using System;
using System.Collections.Generic;

namespace quick_sort
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(random.Next(0, 100));
            }

            Sort(ref list, 0, list.Count - 1);
            foreach (var item in list)
            {
                Console.Out.Write($"{item} ");
            }
        }

        public static void Sort(ref List<int> list, int left, int right)
        {
            int rleft = left, rright = right;
            int middle = list[(left + right) / 2];
            while (rleft <= rright)
            {
                while (list[rleft] < middle)
                {
                    rleft++;
                }

                while (middle < list[rright])
                {
                    rright--;
                }

                if (rleft <= rright)
                {
                    int temp = list[rleft];
                    list[rleft] = list[rright];
                    list[rright] = temp;
                    rleft++;
                    rright--;
                }
            }

            if (left < rright)
            {
                Sort(ref list, left, rleft - 1);
            }

            if (rleft < right)
            {
                Sort(ref list, rright + 1, right);
            }
        }
    }
}