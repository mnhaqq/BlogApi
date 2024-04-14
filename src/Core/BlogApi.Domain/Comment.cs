using BlogApi.Domain.Common;

namespace BlogCrudApp.Models
{
    public class Comment : BaseDomainEntity
    {
        public string Text { get; set; } = "";
        public int PostId { get; set; }
        public virtual Post? Post { get; set; }
    }
}