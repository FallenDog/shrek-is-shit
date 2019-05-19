using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    class GameContext : DbContext
    {
        public GameContext():base("DbConnection")
        { }
      public DbSet<GameViewModel> games { get; set; }
    }
}
