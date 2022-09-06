namespace ECommerce.Application
{
    using Microsoft.EntityFrameworkCore;
    using System.Linq.Expressions;

    public interface IBaseRepository<T>
    {
         DbContext DbContext { get; }
        Task<T> AddAsync(T entity);
        Task<T> EditAsync(T entity);
        Task<T> DeleteAsync(Guid id);
        Task<T> GetByIdAsync(Guid id);
       Task<IEnumerable<T> >GetAllAsync();
        Task<List<T>> GetByExprissionAsync(Expression<Func<T, bool>> expression);

    }
}
