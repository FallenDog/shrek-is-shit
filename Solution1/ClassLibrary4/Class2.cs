using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ClassLibrary4
{
    class gameContext : DbContext
    {
        public gameContext() :base("DbConnection")
            {}

        public DbSet<Class1> games { get; set; }
    }
}
