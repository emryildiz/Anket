using SurveyApi.Domain.Common;

namespace SurveyApi.Application.Services
{
    public interface IService<TEntity> where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> GetAll();

        Task<TEntity> GetById(int id);

        Task AddAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);

        Task DeleteAsync(int id);
    }
}
