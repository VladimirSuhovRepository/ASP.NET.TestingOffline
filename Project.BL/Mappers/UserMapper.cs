using Project.BL.Entities;
using Project.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BL.Mappers
{
    public static class UserMapper
    {
        public static UserEntity ToUserEntity(this UserDTO userDTO)
        {
            return new UserEntity()
            {
                Id = userDTO.Id,
                UserName = userDTO.Name
            };
        }

        public static UserDTO ToUserDTO(this UserEntity userEntity)
        {
            return new UserDTO()
            {
                Id = userEntity.Id,
                Name = userEntity.UserName
            };
        }
    }
}
