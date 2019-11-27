using System.Linq;
using AutoMapper;
using DatingApp.API.DTOs;
using DatingApp.API.Models;

namespace DatingApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>()
                .ForMember(destination => destination.PhotoUrl, 
                            options => options.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
                .ForMember(destionation => destionation.Age, 
                            options => options.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<User, UserForDetailedDto>()
                .ForMember(destination => destination.PhotoUrl, 
                            options => options.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
                .ForMember(destionation => destionation.Age, 
                            options => options.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotoForDetailedDto>();
        }
    }
}