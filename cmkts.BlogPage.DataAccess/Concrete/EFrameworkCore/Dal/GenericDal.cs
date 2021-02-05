using cmkts.BlogPage.DataAccess.Concrete.EFrameworkCore.BlogPageContext;
using cmkts.BlogPage.DataAccess.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace cmkts.BlogPage.DataAccess.Concrete.EFrameworkCore.Dal
{
    public class GenericDal<TEntity> : IGenericDal<TEntity> where TEntity:class,new()
    {
        public async Task AddAsync(TEntity entity)
        {
            using(var db=new BPContext())
            {
                db.Set<TEntity>().Add(entity);
                await db.SaveChangesAsync();
            }
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            using(var db=new BPContext())
            {
                return await db.Set<TEntity>().ToListAsync();
            }
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            using (var db = new BPContext())
            {
                return await db.Set<TEntity>().FindAsync(id);
            }
        }

        public async Task RemoveAsync(TEntity entity)
        {
            using (var db = new BPContext())
            {
                db.Set<TEntity>().Remove(entity);
                await db.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(TEntity entity)
        {
            using (var db = new BPContext())
            {
                db.Set<TEntity>().Update(entity);
                await db.SaveChangesAsync();
            }
        }
    }
}
