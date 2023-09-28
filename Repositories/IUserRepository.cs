
namespace AuthApi.Repositories;

// Repositories/IUserRepository.cs
using System.Threading.Tasks;
using AuthApi.Models;

public interface IUserRepository
{
    Task<User> GetUserByEmail(string email);
    Task CreateUser(User user);
}