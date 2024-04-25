using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurveyApi.Application.Repositories;
using SurveyApi.Application.Services;
using SurveyApi.Application.UnitOfWork;
using SurveyApi.Domain.Entities;

namespace SurveyApi.Infrastructure.Services
{
    public class UserService : Service<User>, IUserService
    {
        public UserService(IGenericRepository<User> genericRepository, IUnitOfWork unitOfWork) : base(genericRepository, unitOfWork) { }
    }
}
