using User.Models;
using User.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace User.Repositories
{
    public class UserService : IUserInterface
    {
        public readonly UserDbContext dbContext;

        public UserService(UserDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<Users> DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Users>> Get()
        {
            return await dbContext.User.ToListAsync();
        }

        public async Task<Users> GetById(Guid id)
        {
            return await dbContext.User.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task PostUser(CreateUserDto createUserDto)
        {
            var user = new Users
            {
                Id = Guid.NewGuid(),
                Name = createUserDto.Name,
                Email = createUserDto.Email,
                CreatedDate = DateTime.Now,
            };

            await dbContext.User.AddAsync(user);
            await dbContext.SaveChangesAsync();

        }

        public Task<Users> PutUser(Guid id, UpdateUserDto updateUserDto)
        {
            throw new NotImplementedException();
        }
    }
}
