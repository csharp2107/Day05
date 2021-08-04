using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    static class _05Elements
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

            Student result =  students.First( s => s.Gender.Equals("Female") );
            result = students.FirstOrDefault(s => s.Name.StartsWith("F"));
            if (result==null)
            {
                result = new Student() { Id = -1, Name = "Dummy" };
            }

            // apply null-coalescing operator ??
            result = students.FirstOrDefault(s => s.Name.StartsWith("F")) ?? new Student();
            Console.WriteLine(result);

            List<int> ints = new List<int>() { 5, 6, 7, 8, 9, 10 };
            int y = ints.FirstOrDefault(x => x == 1);
            Console.WriteLine(y);

            result = students.ElementAt(0); // students[0];
            result = students.Last(s => s.Id<=3);
            result = students.LastOrDefault(s => s.Subject.IndexOf("Polish") >= 0);

            int studentIndex = students.FindIndex(s => s.Name.Equals("Ian"));
            Console.WriteLine(studentIndex);

            result = students.Single(s => s.Name.Equals("Anna"));
            result = students.SingleOrDefault(s => s.Name.Equals("XYZ"));
            Console.WriteLine(result);

            int[] empyInts = { };
            y = empyInts.DefaultIfEmpty().First();
            Console.WriteLine(y);

            students.RemoveRange(0, 2); //remove first two elements from list

            Console.ReadKey();

        }
    }
}
