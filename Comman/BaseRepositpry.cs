
namespace ECommerce.Application
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.ChangeTracking;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public class BaseRepositpry<T> : IBaseRepository<T> where T : BaseEntity
    {

        public DbContext DbContext { get; }
        protected DbSet<T> _Set;
        public BaseRepositpry(DbContext context)
        {
            DbContext = context;
            _Set = context.Set<T>();
        }

        public async Task<T> AddAsync(T entity)
        {
            return (await _Set.AddAsync(entity)).Entity;
            
           
        }
        public async Task<T> GetByIdAsync(Guid id) => await _Set.FirstOrDefaultAsync(c => c.Id == id);

        public  async Task<T> DeleteAsync(Guid id)
        {
          var result=  await GetByIdAsync(id);
            if (result == null)
                throw new Exception("The Entity doesnt exist");
            _Set.Remove(result);
            return result;    
        }
  
        public async Task<T> EditAsync(T entity)
        {
            T entityEntry = await GetByIdAsync(entity.Id);
            if (entityEntry == null)
                return null;
            else
                return _Set.Update(entity).Entity;
        }

       

        public async Task<List<T>> GetByExprissionAsync(Expression<Func<T, bool>> expression) => await _Set.ToListAsync();

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _Set.ToListAsync();
        }
    }
}

