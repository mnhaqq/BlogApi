using BlogApi.Domain.Common;

namespace BlogApi.Domain
{
    public class Post : BaseDomainEntity
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
        }
        public string Title { get; set; } = "";
        public string Content { get; set; } = "";        
        public virtual ICollection<Comment> Comments { get; set; }
    }
}