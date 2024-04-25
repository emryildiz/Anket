using SurveyApi.Application.UnitOfWork;
using SurveyApi.Infrastructure.Context;

namespace SurveyApi.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SurveyDbContext _dbContext;

        public UnitOfWork(SurveyDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task CommitAsync()
        {
            await this._dbContext.SaveChangesAsync();
        }

        public void Commit()
        {
            this._dbContext.SaveChanges();
        }
    }
}
