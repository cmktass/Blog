using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cmkts.BlogPage.Service.Interface
{
    public interface IGenericManager<TEntity> where TEntity:class,new()
    {
        Task<List<TEntity>> GetAllAsync();

        Task<TEntity> GetByIdAsync(int id);

        Task AddAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);

        Task RemoveAsync(TEntity entity);
    }
}
