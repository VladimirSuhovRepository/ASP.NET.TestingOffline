using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ORM
{
    public partial class EntityModelOffline : DbContext
    {
        public EntityModelOffline()
        {
        }

        public virtual DbSet<User> Users { get; set; }
        
    }
}
