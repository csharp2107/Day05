using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldContext;

namespace LinqExample
{
    static class LinqSQL
    {
        public static void Test()
        {
            WorldDataContext context = new WorldDataContext();
            var result = context.Cities.Where(c => c.Name.StartsWith("B")).ToList();
            
            // all cities in Canada
            result = context.Cities.Where(c => c.CountryCode.Equals("CAN")).ToList();

            result = context.Cities.Where(c => c.Country.Name.Equals("Canada") ).ToList();
        }
    }
}
