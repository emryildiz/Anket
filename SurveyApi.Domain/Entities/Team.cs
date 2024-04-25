using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurveyApi.Domain.Common;

namespace SurveyApi.Domain.Entities
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }
    }
}
