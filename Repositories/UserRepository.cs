using System.Collections.Generic;
using System.Threading.Tasks;
using crud_netcore.DTO;
using crud_netcore.Models;
using crud_netcore.Utils;
using Microsoft.EntityFrameworkCore;

namespace crud_netcore.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(DbContext context)
        {
            _context = (AppDbContext)context;
        }

        public Task<AuthToken> Authenticate(Credentials credentials)
        {
            throw new System.NotImplementedException();
        }

        public async Task<int> Create(UserModel entity)
        {
            _context.Users.Add(entity).State = EntityState.Added;
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
            if (entity != null)
            {
                _context.Users.Remove(entity);
                return await _context.SaveChangesAsync() > 0;
            }
            return false;
        }

        public Task<List<UserModel>> GetAll()
        {
            return _context.Users.ToListAsync();
        }

        public async Task<bool> Update(UserModel entity)
        {
            var current = await _context.Users.FirstOrDefaultAsync(u => u.Id == entity.Id);
            if (current != null)
            {
                current.Username = entity.Username;
                _context.Users.Add(current).State = EntityState.Modified;
                return await _context.SaveChangesAsync() > 0;
            }
            return false;
        }
    }
}