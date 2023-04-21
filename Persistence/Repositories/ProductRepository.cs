using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Repositories;
using Domain.Entities;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class ProductRepository : BaseRepository<Product, BaseDbContext>, IProductRepository
    {
        public ProductRepository(BaseDbContext context) : base(context)
        {
        }

        public async Task<Product> GetByName(string name, CancellationToken cancellationToken)
        {
            return await Get(p => p.Name == name, cancellationToken);
        }
    }
}
