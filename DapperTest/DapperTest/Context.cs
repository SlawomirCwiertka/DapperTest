using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DapperTest
{
    class Context: DbContext
    {
        public DbSet<Person> Persons { get; set; }
        private string _connectionString;
        public Context()
        {
            _connectionString = "DataSource=c:\\DPersonsDB.sqlite";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=d:\\DPersonsDB.sqlite.:memdb1?mode=memory&cache=shared");
    }
}
