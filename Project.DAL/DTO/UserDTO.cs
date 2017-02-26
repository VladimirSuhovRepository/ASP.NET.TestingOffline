using Project.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Entities
{
    public class UserDTO : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
