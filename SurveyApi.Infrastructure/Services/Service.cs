using Microsoft.EntityFrameworkCore;
using SurveyApi.Application.Repositories;
using SurveyApi.Application.Services;
using SurveyApi.Application.UnitOfWork;
using SurveyApi.Domain.Common;

namespace SurveyApi.Infrastructure.Services
{
    public class Service<TEntity> : IService<TEntity> where TEntity : BaseEntity
    {
        private readonly IGenericRepository<TEntity> _genericRepository;
        protected readonly IUnitOfWork UnitOfWork;

        public Service(IGenericRepository<TEntity> genericRepository, IUnitOfWork unitOfWork)
        {
            this._genericRepository = genericRepository;
            this.UnitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await this._genericRepository.GetAll().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await this._genericRepository.GetById(id);
        }

        public async Task AddAsync(TEntity entity)
        {
            await this._genericRepository.AddAsync(entity);
            await this.UnitOfWork.CommitAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            this._genericRepository.Update(entity);

            await this.UnitOfWork.CommitAsync();
        }

        public async Task DeleteAsync(int id)
        {
            this._genericRepository.Delete(id);

            await this.UnitOfWork.CommitAsync();
        }
    }
}
