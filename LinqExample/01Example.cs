using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    static class _01Example
    {

        public static void Test()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> result = from nr in numbers 
                                      where nr >3 
                                      select nr;
            foreach (var item in result)
            {
                Console.Write(item+", ");
            }

            List<int> intNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> resultInt = intNumbers.Where(x => x > 3).ToList();
            foreach (var item in resultInt)
            {
                Console.Write(item + ", ");
            }

            Console.ReadKey();
        }

    }
}
