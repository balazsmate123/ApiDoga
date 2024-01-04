using User.Models;
using User.Models.Dtos;

namespace User
{
    public static class Extensions
    {
        public static UserDto AsDto(this UserDto User)
        {
            return new(User.Id, User.Name, User.Email, User.CreatedDate);
        }
        public static BankAccountDto AsDto(this BankAccountDto BankAccount)
        {
            return new(BankAccount.Id, BankAccount.Balance, BankAccount.Numbers,BankAccount.UsersId, BankAccount.CreatedDate);
        }
    }
}
