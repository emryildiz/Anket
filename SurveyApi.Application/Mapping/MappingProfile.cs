using AutoMapper;
using SurveyApi.Application.Dtos.UserDtos;
using SurveyApi.Domain.Entities;

namespace SurveyApi.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // User profile
            this.CreateMap<UserRegisterDto, User>()
                .ForMember(x => x.CreatedDateTime,
                           opt => opt.MapFrom(src => DateTime.Now));

            this.CreateMap<UserLoginDto, User>();
            this.CreateMap<User, UserViewDto>();
        }
    }
}
