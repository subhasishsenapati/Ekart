using AutoMapper;
using EKart.Core.Entities;
using EKart.Infrastructure.Models;

namespace EKart.Infrastructure.Mapper
{
    public class MapperProfileInfra : Profile
    {
        public MapperProfileInfra()
        {
            CreateMap<UserRegisterModel, User>();
        }
    }
}
