using AutoMapper;
using EKart.API.DTOs.Request;
using EKart.Infrastructure.Models;

namespace EKart.API.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<RegisterRequestDTO, UserRegisterModel>();
            CreateMap<LoginRequestDTO, UserLoginModel>();
        }
    }
}
