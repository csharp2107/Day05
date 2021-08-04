using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    static class _09SetOperators
    {
        
        public static void Test()
        {
            string[] countries1 = { "India", "USA", "UK", "Australia", "uk" };
            string[] countries2 = { "India", "Canada", "UK", "China" };

            // union
            var result = countries1.Union(countries2).ToList();

            // intersect
            result = countries1.Intersect(countries2).ToList();

            // distinct
            result = countries1.Distinct(StringComparer.OrdinalIgnoreCase).ToList();

            // except
            result = countries1.Except(countries2).ToList();



        }

    }

    
}
