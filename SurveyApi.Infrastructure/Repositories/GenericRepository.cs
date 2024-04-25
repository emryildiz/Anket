using Microsoft.EntityFrameworkCore;
using SurveyApi.Application.Repositories;
using SurveyApi.Domain.Common;
using SurveyApi.Infrastructure.Context;

namespace SurveyApi.Infrastructure.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        private DbSet<TEntity> _dbSet;

        public GenericRepository(SurveyDbContext context)
        {
            this._dbSet = context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return this._dbSet
                       .AsNoTracking()
                       .AsQueryable();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await this._dbSet.FindAsync(id);
        }

        public async Task AddAsync(TEntity entity)
        {
            await this._dbSet.AddAsync(entity);
        }

        public async void Delete(int id)
        {
            TEntity entity = await this.GetById(id);

            this._dbSet.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            this._dbSet.Update(entity);
        }
    }
}
