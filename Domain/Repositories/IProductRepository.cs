using CodersHomeAPI.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodersHomeAPI.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}
