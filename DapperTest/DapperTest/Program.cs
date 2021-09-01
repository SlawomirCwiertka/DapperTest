using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace DapperTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string cs = "DataSource=d:\\DPersonsDB.sqlite.:memdb1?mode=memory&cache=shared";

            using var con = new SqliteConnection(cs);
            con.Open();
            List<Person> persons = con.Query<Person>("select * from Persons").AsList<Person>();



            foreach (Person person in persons)
            {
                Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
            }
            //Person entity = new Person
            //{
            //    FirstName = "Staszek",
            //    LastName = "Stefczyk"
            //};
            //string sqlQuery = "INSERT INTO [Persons]([FirstName],[LastName]) VALUES (@FirstName,@LastName)";
            //con.Execute(sqlQuery,
            //    new
            //    {
            //        entity.FirstName,
            //        entity.LastName,
            //    });

            //con.Close();
        }
    }
}
