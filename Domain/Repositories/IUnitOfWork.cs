using System.Threading.Tasks;

namespace CodersHomeAPI.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
