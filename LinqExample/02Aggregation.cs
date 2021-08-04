using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    static class _02Aggregation
    {
        public static void Test()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int _min = numbers.Min();
            int _max = numbers.Max();
            int _sum = numbers.Sum();
            int _count = numbers.Count();
            Console.WriteLine($"min={_min}, max={_max}, count={_count}");
            numbers.Aggregate((x, y) => x * y); // Factorial

            string[] strArr = { "A", "B", "C" };
            string s = strArr.Aggregate((s1, s2) => s1 + s2);
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
