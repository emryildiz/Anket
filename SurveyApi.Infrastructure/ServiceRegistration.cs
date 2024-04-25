using Microsoft.Extensions.DependencyInjection;
using SurveyApi.Application.Repositories;
using SurveyApi.Application.Services;
using SurveyApi.Application.UnitOfWork;
using SurveyApi.Infrastructure.Repositories;
using SurveyApi.Infrastructure.Services;

namespace SurveyApi.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceRegistration(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IService<>), typeof(Service<>));

            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserService, UserService>();
        }
    }
}
