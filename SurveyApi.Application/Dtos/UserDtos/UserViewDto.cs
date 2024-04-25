using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurveyApi.Domain.Entities;

namespace SurveyApi.Application.Dtos.UserDtos
{
    public class UserViewDto
    {
        public string UserName { get; set; }

        public Team Team { get; set; }

        public UserRole Role { get; set; }
    }
}
