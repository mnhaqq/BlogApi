namespace BlogApi.Domain.Common
{
    public abstract class BaseDomainEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}