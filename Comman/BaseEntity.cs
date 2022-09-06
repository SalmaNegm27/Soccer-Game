namespace ECommerce.Application
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
      
        public DateTime CreationData { get; set; }
        public byte[] ConcurrencyStamp { get; set; }
    }
}
