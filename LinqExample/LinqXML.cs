using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqExample
{
    static class LinqXML
    {
        public static void Test()
        {
            XElement xml = XElement.Load("c:/tmp/Employees.xml");
            foreach (var item in xml.Descendants("Employee"))
            {
                if (item.Element("Gender").Value.Equals("Male"))
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("------------------------------");
            // take only 2 elements from beginning
            var result = xml.Elements("Employee").Take(2);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------");
            // reverse elements
            result = xml.Elements("Employee").Reverse();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------");
            // Get employees with gender = Male
            result = xml.Elements("Employee").Where(e => e.Element("Gender").Value.Equals("Male"));
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------");
            // Get employees with state = CA
            result = from e in xml.Elements("Employee")
                     where e.Element("Address").Element("State").Value.Equals("CA")
                     select e;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------");
            // Remove employees with state = IL and save to XML file
            xml.Elements("Employee").Where(e => e.Element("Address")
                    .Element("State").Value.Equals("IL")).Remove();
            xml.Save("c:/tmp/test.xml");

        }
    }
}
