using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    static class LinqPerformance
    {

        public static void Test()
        {
            List<Student> students = new List<Student>();

            for (int i = 0; i < 1_000_000; i++)
            {
                List<Student> studTmp = new List<Student>()
                {
                    new Student(){ Id=1, Name="John", Gender="Male", Subject=new List<string>{ "Math","English" } },
                    new Student(){ Id=2, Name="Anna", Gender="Female", Subject=new List<string>{ "Economics","Esperanto" } },
                    new Student(){ Id=3, Name="Martin", Gender="Male", Subject=new List<string>{ "Computer","Biology" } },
                    new Student(){ Id=4, Name="Joanna", Gender="Female", Subject=new List<string>{ "Math","Physics" } },
                    new Student(){ Id=6, Name="Joanna", Gender="Female", Subject=new List<string>{ "Math","Physics" } },
                    new Student(){ Id=5, Name="Ian", Gender="Male", Subject=new List<string>{ "Math","English" } },
                };
                students.AddRange(studTmp);
            }

            Console.WriteLine("--------------------");

            // classic loop
            List<Student> destStudents = new List<Student>();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            foreach (var item in students)
            {
                if (item.Id > 4)
                    destStudents.Add(item);
            }
            sw.Stop();
            Console.WriteLine($"loop={sw.ElapsedMilliseconds}");

            // linq approach
            sw.Restart();
            destStudents = students.Where(s => s.Id > 4).ToList();
            sw.Stop();
            Console.WriteLine($"linq={sw.ElapsedMilliseconds}");

            // PLINQ - Pararell LINQ           
            students.AsParallel().Where(s => s.Id == 4);

            
        }
    }
}
