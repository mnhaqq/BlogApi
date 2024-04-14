using BlogApi.Domain.Common;

namespace BlogCrudApp.Models
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