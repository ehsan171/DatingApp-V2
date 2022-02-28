using DatingApp.API.Models;

namespace API.Imterfaces
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}