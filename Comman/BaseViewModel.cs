namespace ECommerce.Application
{
    public class BaseViewModel
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public byte[] ConcurrencyStamp { get; set; }
    }
}
