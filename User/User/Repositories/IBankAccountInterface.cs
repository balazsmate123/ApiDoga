using User.Models.Dtos;
using User.Models;

namespace User.Repositories
{
    public interface IBankAccountInterface
    {
        Task<IEnumerable<BankAccounts>> GetBank();
        Task<BankAccounts> GetByBankId(Guid id);
        Task PostBankAccount(CreateBankAccountDto CreateBankAccountDto);
        Task<BankAccounts> PutBankAccount(Guid id, UpdateBankAccountDto UpdateBankAccountDto);
        Task<BankAccounts> DeleteByBankId(Guid id);
    }
}
