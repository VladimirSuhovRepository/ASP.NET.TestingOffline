using Project.BL.Interfaces;
using Project.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.BL.Entities;
using Project.BL.Mappers;

namespace Project.BL.Providers
{
    public class UsersProvider : IUsersProvider
    {
        private readonly IUnitOfWork uow;
        private readonly IUserRepository userRepository;
        public UsersProvider(IUnitOfWork uow, IUserRepository repository)
        {
            this.uow = uow;
            this.userRepository = repository;
        }

        public void CreateUser(UserEntity user)
        {
            userRepository.Create(user.ToUserDTO());
            uow.Commit();
        }

        public void DeleteUser(UserEntity user)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserEntity> GetAllUserEntities()
        {
            throw new NotImplementedException();
        }

        public UserEntity GetUserEntity(int id)
        {
            return userRepository.GetById(id).ToUserEntity();
        }
    }
}
