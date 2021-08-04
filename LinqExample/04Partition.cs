using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    static class _04Partition
    {
        
        public static void Test()
        {
            string[] countries = { "UK", "USA", "Russia", "China", "Australia", "Argentina", "Spain" };
            IEnumerable<string> result = countries.Take(3);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=========================");
            // query syntax
            result = (from c in countries select c).Take(3);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=========================");
            result = countries.TakeWhile(s => s.StartsWith("U") );
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=========================");
            result = countries.Skip(3);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=========================");
            result = countries.SkipWhile(s => s.StartsWith("U"));
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

    }
}
