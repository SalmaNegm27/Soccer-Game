namespace ECommerce.Application
{
    public interface IBaseUnitOfWork<T> where T : BaseEntity
    {
       Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(Guid id);
        Task<IEnumerable<T>> ReadAsync();
        Task<T> ReadByIdAsync(Guid id);
     
    }
}
