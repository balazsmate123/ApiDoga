using User.Models.Dtos;
using User.Models;
using Microsoft.EntityFrameworkCore;

namespace User.Repositories
{
    public class BankAccountService : IBankAccountInterface
    {
        public readonly UserDbContext dbContext;

        public BankAccountService(UserDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<BankAccounts> DeleteByBankId(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BankAccounts>> GetBank()
        {
            return await dbContext.BankAccount.ToListAsync();
        }

        public async Task<BankAccounts> GetByBankId(Guid id)
        {
            return await dbContext.BankAccount.SingleOrDefaultAsync(x => x.Id == id);
        }


        public async Task PostBankAccount(CreateBankAccountDto createBankAccountDto)
        {
            var bankAccounts = new BankAccounts
            {
                Id = Guid.NewGuid(),
                Balance = createBankAccountDto.Balance,
                Numbers = createBankAccountDto.Numbers,
                UsersId = createBankAccountDto.UsersId,
                CreatedDate = DateTime.Now,
            };

            await dbContext.BankAccount.AddAsync(bankAccounts);
            await dbContext.SaveChangesAsync();

        }


        public Task<BankAccounts> PutBankAccount(Guid id, UpdateBankAccountDto UpdateBankAccountDto)
        {
            throw new NotImplementedException();
        }


        Task<BankAccounts> IBankAccountInterface.DeleteByBankId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
