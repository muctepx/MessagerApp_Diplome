using UserService.DTO;

namespace UserService.Abstraction;

public interface ITokenService
{
    public string GenerateToken(LoginViewModel loginViewModel);
}