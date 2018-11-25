using AutoMapper;
using CatchUp.Dtos;
using CatchUp.Entities;
 
namespace CatchUp.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}