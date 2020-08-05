using System.Collections.Generic;
using System.Threading.Tasks;
using crud_netcore.DTO;
using crud_netcore.Models;
using crud_netcore.Repositories;

namespace crud_netcore.Business
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserRepository _userRepository;
        public UserBusiness(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<AuthToken> Authenticate(Credentials credentials)
        {
            return _userRepository.Authenticate(credentials);
        }

        public Task<int> Create(UserModel entity)
        {
            return _userRepository.Create(entity);
        }

        public Task<bool> Delete(int id)
        {
            return _userRepository.Delete(id);
        }

        public Task<List<UserModel>> GetAll()
        {
            return _userRepository.GetAll();
        }

        public Task<bool> Update(UserModel entity)
        {
            return _userRepository.Update(entity);
        }
    }
}