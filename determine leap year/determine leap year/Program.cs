using System;

namespace determine_leap_year
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Out.WriteLine("输入年份");
            int year = Int32.Parse(Console.In.ReadLine() ?? throw new InvalidOperationException());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.Out.WriteLine("是闰年");
            }
            else
            {
                Console.Out.WriteLine("不是闰年");
            }
        }
    }
}