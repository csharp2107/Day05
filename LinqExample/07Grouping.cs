using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    static class _07Grouping
    {
        
        public static void Test()
        {

            List<Student> students = new List<Student>()
            {
                new Student(){ Id=1, Name="John", Gender="Male", Subject=new List<string>{ "Math","English" } },
                new Student(){ Id=2, Name="Anna", Gender="Female", Subject=new List<string>{ "Economics","Esperanto" } },
                new Student(){ Id=3, Name="Martin", Gender="Male", Subject=new List<string>{ "Computer","Biology" } },
                new Student(){ Id=4, Name="Joanna", Gender="Female", Subject=new List<string>{ "Math","Physics" } },
                new Student(){ Id=6, Name="Joanna", Gender="Female", Subject=new List<string>{ "Math","Physics" } },
                new Student(){ Id=5, Name="Ian", Gender="Male", Subject=new List<string>{ "Math","English" } },
            };

            var studGrouping = students.GroupBy(s => s.Gender);
            studGrouping = from s in students
                           group s by s.Gender;
            foreach (var item in studGrouping)
            {
                Console.WriteLine("------------");
                Console.WriteLine($"{item.Key} - count: {item.Count()}");
                foreach (var s in item)
                {
                    Console.WriteLine(s);
                }
            }


            Console.ReadKey();
        }

    }
}
