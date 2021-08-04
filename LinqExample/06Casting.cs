using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    static class _06Casting
    {
        
        public static void Test()
        {

            // array <-> list conversion
            string[] countries = { "UK", "USA", "Russia", "China", "Australia", "Argentina", "Spain" };
            List<string> result = countries.ToList();
            result = (from s in countries select s).ToList();

            string[] countries1 = result.ToArray();
            countries1 = (from s in countries select s).ToArray();

            // casting sequence elements
            ArrayList arrayList = new ArrayList();
            arrayList.Add("ABC");
            arrayList.Add("GFD");
            arrayList.Add("TRE");

            IEnumerable<string> result1 = arrayList.Cast<string>();
            result = result1.ToList();

            ArrayList intArr = new ArrayList();
            intArr.Add(1); intArr.Add(2); intArr.Add(3);
            int[] ints = intArr.Cast<int>().ToArray();


            // Lookup operator
            List<Student> students = new List<Student>()
            {
                new Student(){ Id=1, Name="John", Gender="Male", Subject=new List<string>{ "Math","English" } },
                new Student(){ Id=2, Name="Anna", Gender="Female", Subject=new List<string>{ "Economics","Esperanto" } },
                new Student(){ Id=3, Name="Martin", Gender="Male", Subject=new List<string>{ "Computer","Biology" } },
                new Student(){ Id=4, Name="Joanna", Gender="Female", Subject=new List<string>{ "Math","Physics" } },
                new Student(){ Id=6, Name="Joanna", Gender="Female", Subject=new List<string>{ "Math","Physics" } },
                new Student(){ Id=5, Name="Ian", Gender="Male", Subject=new List<string>{ "Math","English" } },
            };
            var lookup = students.ToLookup(s => s.Gender);
            foreach (var item in lookup)
            {
                Console.WriteLine(item.Key);
                // iteration for elements related with lookup field
                foreach (var s in lookup[item.Key])
                {
                    Console.WriteLine(s);
                }
            }



            Console.ReadKey();
        }

    }
}
