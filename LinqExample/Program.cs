using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //DummyClass.Test();
            //_01Example.Test();
            //_02Aggregation.Test();
            //_03Sorting.Test();
            //_04Partition.Test();
            //_05Elements.Test();
            //_06Casting.Test();
            //_07Grouping.Test();
            //_08JoinOperators.Test();
            //_09SetOperators.Test();
            for (int i = 0; i < 10; i++)
            {
                LinqPerformance.Test();
            }
            Console.ReadKey();

        }
    }
}
