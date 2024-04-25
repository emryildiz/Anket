using SurveyApi.Domain.Common;

namespace SurveyApi.Domain.Entities
{
    public class Question : BaseEntity
    {
        public string Message { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public int NumberOfReplies { get; set; }

        public List<Choice> Choices { get; set; }
    }
}
