using SurveyApi.Domain.Common;

namespace SurveyApi.Domain.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public UserRole Role { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public Team Team { get; set; }
    }
}
