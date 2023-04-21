using Domain.Entities;

namespace Application.Repositories;

public interface IProductRepository : IBaseRepository<Product>
{
    Task<Product> GetByName(string name, CancellationToken cancellationToken);
}