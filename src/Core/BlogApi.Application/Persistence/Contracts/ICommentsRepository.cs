using BlogApi.Domain;

namespace BlogApi.Application.Persistence.Contracts
{
    public interface ICommentsRepository : IGenericRepository<Comment>
    {
    }
}