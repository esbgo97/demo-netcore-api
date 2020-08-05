using System.Threading.Tasks;
using crud_netcore.DTO;
using crud_netcore.Models;

namespace crud_netcore.Repositories
{
    public interface IUserRepository: IRepository<UserModel>
    {
        Task<AuthToken> Authenticate(Credentials credentials);
    }
}