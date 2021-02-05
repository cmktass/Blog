using cmkts.BlogPage.DataAccess.Interface;
using cmkts.BlogPage.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cmkts.BlogPage.Service.Concrete
{
    public class GenericManager<TEntity> : IGenericManager<TEntity> where TEntity : class, new()
    {
        private IGenericDal<TEntity> genericDal;

        public GenericManager(IGenericDal<TEntity> genericDal)
        {
            this.genericDal = genericDal;
        }

        public async Task AddAsync(TEntity entity)
        {
            await genericDal.AddAsync(entity);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await genericDal.GetAllAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await genericDal.GetByIdAsync(id);
        }

        public async Task RemoveAsync(TEntity entity)
        {
            await genericDal.RemoveAsync(entity);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await genericDal.UpdateAsync(entity);
        }
    }
}
