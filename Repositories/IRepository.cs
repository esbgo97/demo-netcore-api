using System.Collections.Generic;
using System.Threading.Tasks;

namespace crud_netcore.Repositories
{
    public interface IRepository<T>
    {
        Task<int> Create(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(int id);
        Task<List<T>> GetAll();
    }
}