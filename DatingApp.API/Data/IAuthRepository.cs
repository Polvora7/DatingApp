using DatingAPP.API.Models;
using System.Threading.Tasks;

namespace DatingAPP.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> USerExists(string username);
    }
}
