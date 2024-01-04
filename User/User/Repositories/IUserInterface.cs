using User.Models;
using User.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace User.Repositories
{
    public interface IUserInterface
    {
        Task<IEnumerable<Users>> Get();
        Task<Users> GetById(Guid id);
        Task PostUser(CreateUserDto createUserDto);
        Task<Users> PutUser(Guid id, UpdateUserDto updateUserDto);
        Task<Users> DeleteById(Guid id);

    }
}
