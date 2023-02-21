using AutoMapper;
using LearningCenter.Core.Domain.ResponseModel;
using LearningCenter.Infra.Domain.Entities;

namespace LearningCenter.Configuration
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<User, UserResponseModel>();
        }
    }
}
