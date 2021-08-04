using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    static class _08JoinOperators
    {
        
        public static void Test()
        {
            List<Deptartament> deptartaments = new List<Deptartament>()
            {
                new Deptartament() { Id=1, DeptName="Finance" },
                new Deptartament() { Id=2, DeptName="HR" },
                new Deptartament() { Id=3, DeptName="IT" }
            };

            List<Employee> employees = new List<Employee>()
            {
                new Employee() { EmpId=1, Name="John", DeptId=1 },
                new Employee() { EmpId=2, Name="Mark", DeptId=1 },
                new Employee() { EmpId=3, Name="Anna", DeptId=2 },
                new Employee() { EmpId=4, Name="Ian", DeptId=2 },
                new Employee() { EmpId=5, Name="Richard" },
            };

            // inner join
            var result = from d in deptartaments
                         join e in employees
                         on d.Id equals e.DeptId
                         select new
                         {
                             DepartamentName = d.DeptName,
                             EmployeeName = e.Name
                         };
            foreach (var item in result)
            {
                Console.WriteLine($"{item.DepartamentName} - {item.EmployeeName}");
            }


            // cross join
            Console.WriteLine("-----------------------------");
            result = from d in deptartaments
                         from  e in employees
                         select new
                         {
                             DepartamentName = d.DeptName,
                             EmployeeName = e.Name
                         };
            foreach (var item in result)
            {
                Console.WriteLine($"{item.DepartamentName} - {item.EmployeeName}");
            }

            // left outer join
            Console.WriteLine("-----------------------------");
            result = from e in employees
                     join d in deptartaments
                     on e.DeptId equals d.Id into empDept
                     from ed in empDept.DefaultIfEmpty()
                     select new
                     {
                         DepartamentName = ed==null ? "NO DEPARTAMENT" : ed.DeptName,
                         EmployeeName = e.Name
                     };

            foreach (var item in result)
            {
                Console.WriteLine($"{item.DepartamentName} - {item.EmployeeName}");
            }
            Console.ReadKey();
        }

    }

    class Deptartament
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
    }

    class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int DeptId { get; set; }
    }
}
