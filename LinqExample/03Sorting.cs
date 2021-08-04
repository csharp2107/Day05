using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    static class _03Sorting
    {
        public static void Test()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){ Id=1, Name="John", Gender="Male", Subject=new List<string>{ "Math","English" } },
                new Student(){ Id=2, Name="Anna", Gender="Female", Subject=new List<string>{ "Economics","Esperanto" } },
                new Student(){ Id=3, Name="Martin", Gender="Male", Subject=new List<string>{ "Computer","Biology" } },
                new Student(){ Id=4, Name="Joanna", Gender="Female", Subject=new List<string>{ "Math","Physics" } },
                new Student(){ Id=5, Name="Ian", Gender="Male", Subject=new List<string>{ "Math","English" } },
            };

            var result = students.OrderByDescending(x => x.Name).ToList();
            result = students.OrderByDescending(x => x.Name).ThenBy(x => x.Id).ToList();
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Id}, {item.Name}, {item.Gender}");
            }

            result.Reverse();
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Id}, {item.Name}, {item.Gender}");
            }
        }
    }
}
