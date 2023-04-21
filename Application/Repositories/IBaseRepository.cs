using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;

namespace Application.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T> Get(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);
        Task<List<T>> GetAll(CancellationToken cancellationToken);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
