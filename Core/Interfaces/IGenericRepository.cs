using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Specification;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
         Task<T> GetByIdAsync(int id);

         Task<IReadOnlyList<T>> ListAllAsync();

         Task<IReadOnlyList<T>> ListAllAsyncWithSpec(ISpecification<T> spec);
         Task<T> GetWithEntitySpec(ISpecification<T> spec);
         Task<int> CountAsync(ISpecification<T> spec);
        
    }
}