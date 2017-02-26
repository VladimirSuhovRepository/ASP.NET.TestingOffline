using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ORM
{
    public partial class EntityModelDatabase : DbContext
    {
        private static string connectionString= @"Server = .\SQLEXPRESS; Database = EntityModelDatabase; Integrated Security=true;";
        public EntityModelDatabase() : base(connectionString)
        {
            
        }

        public virtual DbSet<User> Users { get; set; }

    }
}
