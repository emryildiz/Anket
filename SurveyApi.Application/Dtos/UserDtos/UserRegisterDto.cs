using SurveyApi.Domain.Entities;

namespace SurveyApi.Application.Dtos.UserDtos
{
    public class UserRegisterDto
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public Team Team { get; set; }

        public UserRole Role { get; set; }
    }
}
