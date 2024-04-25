using SurveyApi.Domain.Common;

namespace SurveyApi.Application.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll();

        Task<TEntity> GetById(int id);

        Task AddAsync(TEntity entity);

        void Update(TEntity entity);

        void Delete(int id);
    }
}
