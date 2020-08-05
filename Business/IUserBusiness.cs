using System.Threading.Tasks;
using crud_netcore.DTO;
using crud_netcore.Models;

namespace crud_netcore.Business
{
    public interface IUserBusiness : IEntityBusiness<UserModel>
    {
        Task<AuthToken> Authenticate(Credentials credentials);
    }
}