using SurveyApi.Application.Repositories;
using SurveyApi.Domain.Entities;
using SurveyApi.Infrastructure.Context;

namespace SurveyApi.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(SurveyDbContext context) : base(context) { }
    }
}
