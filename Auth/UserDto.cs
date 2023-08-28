

namespace MoneyApp_Api.Dto;

public class UserDto
{
    public int Id { get; set;} 

    public string UserName { get; set;} = string.Empty;

    public byte[] PasswordSalt { get; set;} 

    public byte[] PasswordHash { get; set;}
}