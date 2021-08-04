using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    static class DummyClass
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

            // looking for male and english subject
            List<Student> targetList = new List<Student>();
            foreach (var item in students)
            {
                if (item.Gender.Equals("Male")  && item.Subject.IndexOf("English")>=0 )
                {
                    targetList.Add(item);
                }
            }
            Console.WriteLine(targetList.Count);
        }
    }
}
