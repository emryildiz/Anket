using SurveyApi.Domain.Common;

namespace SurveyApi.Domain.Entities
{
    public class Survey : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public List<Question> Question { get; set; }

        public User Owner { get; set; }

        public Team Team { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ExpiredDate { get; set; }
    }
}
