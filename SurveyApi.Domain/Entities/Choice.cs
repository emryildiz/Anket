using SurveyApi.Domain.Common;

namespace SurveyApi.Domain.Entities
{
    public class Choice : BaseEntity
    {
        public string Message { get; set; }

        public int NumberOfSelection { get; set; }
    }
}
