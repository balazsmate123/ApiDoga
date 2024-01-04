namespace User.Models.Dtos
{
    public record UserDto(Guid Id, string Name, string Email, DateTime CreatedDate);
    public record CreateUserDto(string Name, string Email);
    public record UpdateUserDto(string Name, string Email);

    public record BankAccountDto(Guid Id, int Balance, int Numbers, Guid UsersId, DateTime CreatedDate);
    public record CreateBankAccountDto(int Balance, int Numbers, Guid UsersId);

    public record UpdateBankAccountDto(int Balance, int Numbers, Guid UsersId);

}
