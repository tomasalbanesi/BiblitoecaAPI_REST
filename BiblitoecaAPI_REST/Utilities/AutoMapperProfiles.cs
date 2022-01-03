using AutoMapper;
using BiblitoecaAPI_REST.DTOs;
using BiblitoecaAPI_REST.Models;

namespace BiblitoecaAPI_REST.Utilities
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            // Categories
            CreateMap<Category,CategoryReadDTO>().ReverseMap();
            CreateMap<CategoryCreationDTO, Category>();
        }
    }
}
