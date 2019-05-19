namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MyContext : DbContext
    {
   
        public MyContext()
            : base("name=MyContext")
        {
        }

        
    
        public virtual DbSet<Game> Games { get; set; }
    }

    public class Game
    {
        public int id { get; set; }
        public string Developer { get; set; }
        public string Name { get; set; }
        public string General { get; set; }
    }
}