using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyApi.Application.Dtos.UserDtos;
using SurveyApi.Application.Services;
using SurveyApi.Domain.Entities;

namespace SurveyApi.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        private IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            this._userService = userService;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            User user = await this._userService.GetById(id);

            return this.Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Add(UserRegisterDto registerDto)
        {
            User user = this._mapper.Map<User>(registerDto);

            await this._userService.AddAsync(user);

            return this.Ok();
        }
    }
}
