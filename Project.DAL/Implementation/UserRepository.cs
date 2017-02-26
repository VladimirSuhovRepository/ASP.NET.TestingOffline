using Project.DAL.Entities;
using Project.DAL.Interface;
using Project.ORM;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Project.DAL.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly DbContext context;
        private readonly IDbSet<User> dbset;

        public UserRepository(DbContext uow)
        {
            context = uow;
            dbset = context.Set<User>();
        }
      
        public IEnumerable<UserDTO> GetAll()
        {
            return dbset.Local.Select(user => new UserDTO()
            {
                Id = user.Id,
                Name = user.Name
            });
        }

        public UserDTO GetById(int key)
        {

            var ormuser = dbset.Local.FirstOrDefault();
            return new UserDTO()
            {
                Id = ormuser.Id,
                Name = ormuser.Name

            };
        }

        public UserDTO GetByPredicate(Expression<Func<UserDTO, bool>> f)
        {
            //Expression<Func<DalUser, bool>> -> Expression<Func<User, bool>> (!)
            throw new NotImplementedException();
        }

        public void Create(UserDTO e)
        {
            var user = new User()
            {
                Name = e.Name
            };
            dbset.Local.Add(user);
        }

        public void Delete(UserDTO e)
        {
            var user = new User()
            {
                Id = e.Id,
                Name = e.Name
            };
            dbset.Single(u => u.Id == user.Id);
            dbset.Remove(user);
        }

        public void Update(UserDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
