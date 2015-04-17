namespace hrStrange_Grid
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            while (true)
            {
                var nums = Console.ReadLine().Split(' ').Select(Int64.Parse).ToArray();
                long row = nums[0];
                long col = nums[1];
                bool evenRow = row % 2 == 0;
                long num = row / 2;
                if (evenRow && num > 0)
                {
                    --num;
                }
                num *= 10;
                if (evenRow)
                {
                    ++num;
                }
                num += 2 * (col - 1);
                Console.WriteLine(num);
            }
        }
    }
}
