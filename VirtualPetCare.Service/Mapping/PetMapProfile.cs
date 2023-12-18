using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetCare.Core.DTOs.Pet;
using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Service.Mapping
{
    public class PetMapProfile : Profile
    {
        public PetMapProfile()
        {
            CreateMap<Pet, PetListDto>()
               .ForMember(x => x.Age, opt => opt.MapFrom(src => CalculateAge(src.CreatedDate)))
               .ForMember(x => x.HealtStatus, opt => opt.MapFrom(src => src.Health.Status))
               .ForMember(x => x.Species, opt => opt.MapFrom(src => src.PetSpecies.Species));

            CreateMap<Pet, PetUserDetailDto>()
                .ForMember(x => x.Age, opt => opt.MapFrom(src => CalculateAge(src.CreatedDate)))
                .ForMember(x => x.HealtStatus, opt => opt.MapFrom(src => src.Health.Status))
                .ForMember(x => x.PetId, opt => opt.MapFrom(src => src.Id));

            CreateMap<Pet, PetDto>()
                .ForMember(x => x.Age, opt => opt.MapFrom(src => CalculateAge(src.CreatedDate)))
                .ForMember(x => x.HealtStatus, opt => opt.MapFrom(src => src.Health.Status));
            CreateMap<PetCreateDto, Pet>();
            CreateMap<PetUpdateDto, Pet>();
            CreateMap<Pet, PetStatisticsDto>()
                .ForMember(x => x.Age, opt => opt.MapFrom(src => CalculateAge(src.CreatedDate)))
                .ForMember(x => x.Name, opt => opt.MapFrom(src => src.PetName))
                .ForMember(x => x.Species, opt => opt.MapFrom(src => src.PetSpecies.Species));

            CreateMap<Pet, PetStatisticsForUserDto>()
                .ForMember(x => x.Age, opt => opt.MapFrom(src => CalculateAge(src.CreatedDate)))
                .ForMember(x => x.Name, opt => opt.MapFrom(src => src.PetName))
                .ForMember(x => x.Species, opt => opt.MapFrom(src => src.PetSpecies.Species));
        }
        private static string CalculateAge(DateTime createdDate)
        {
            double ageInDays = (DateTime.UtcNow - createdDate).TotalDays;

            return ageInDays < 365
                ? $"{Math.Round(ageInDays, 1)} Days Old"
                : $"{DateTime.UtcNow.Year - createdDate.Year} Years Old";
        }
    }
}
