using BlogApi.Domain;

namespace BlogApi.Application.Persistence.Contracts
{
    public interface IPostsRepository : IGenericRepository<Post>
    {
    }
}