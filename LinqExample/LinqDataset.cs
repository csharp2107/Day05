using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LinqExample
{
    static class LinqDataset
    {
        public static void Test()
        {
            // 3306 -TCP PORT
            String cs = "server=18.196.156.27;uid=world;pwd=world123;database=world;SslMode=None";
            MySqlConnection conn = new MySqlConnection(cs);
            try
            {
                conn.Open();

                // send SQL command, fetch data and fill the table
                String sql = "SELECT * FROM city";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable cities = ds.Tables[0];

                sql = "SELECT * FROM country";
                da = new MySqlDataAdapter(sql, conn);
                ds = new DataSet();
                da.Fill(ds);
                DataTable countries = ds.Tables[0];

                // search for cities names starting with "A"
                var result = cities.AsEnumerable().Where(
                    x => x.Field<string>("Name").StartsWith("A") 
                    ).ToList();
                foreach (var item in result)
                {
                    //  item.Name
                    Console.WriteLine($"{item.Field<string>("Name")} - {item.Field<string>("CountryCode")} - {item.Field<int>("Population")}");  
                }

                // join cities and countries - get full country name instead of country code
                var result1 = from city in cities.AsEnumerable()
                              join country in countries.AsEnumerable()
                              on city.Field<string>("CountryCode") equals country.Field<string>("Code")
                              select new
                              {
                                  CityId = city.Field<int>("ID"),
                                  CityName = city.Field<string>("Name"),
                                  CityCountry = country.Field<string>("Name"),
                                  CityPopulation = city.Field<int>("Population")
                              };
                foreach (var item in result1)
                {
                    //  item.Name
                    Console.WriteLine($"{item.CityId} - {item.CityName} - {item.CityCountry} - {item.CityPopulation}");
                }

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            } finally
            {
                if (conn != null)
                    conn.Close();
            }
        }
    }
}
