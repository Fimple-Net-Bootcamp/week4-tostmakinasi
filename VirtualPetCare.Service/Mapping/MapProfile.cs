using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetCare.Core.DTOs.Activity;
using VirtualPetCare.Core.DTOs.ActivityHisroty;
using VirtualPetCare.Core.DTOs.Food;
using VirtualPetCare.Core.DTOs.FoodHistory;
using VirtualPetCare.Core.DTOs.Health;
using VirtualPetCare.Core.DTOs.Pet;
using VirtualPetCare.Core.DTOs.PetSpecies;
using VirtualPetCare.Core.DTOs.Training;
using VirtualPetCare.Core.DTOs.TrainingHistory;
using VirtualPetCare.Core.DTOs.User;
using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Service.Mapping
{
    public class MapProfile :Profile
    {
        public MapProfile()
        {
            //User
            CreateMap<User, UserDto>();
            CreateMap<User, UserListDto>();
            CreateMap<UserCreateDto, User>().ReverseMap();
            CreateMap<User, UserPetDetailDto>();
            CreateMap<User, UserStatisticDto>()
                .ForMember(x => x.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));


            //Health
            CreateMap<Health, HealthDto>();
            CreateMap<Health, HealthStatisticDto>();

            //Activity
            CreateMap<ActivityCreateDto, Activity>();
            CreateMap<Activity, ActivityDto>();
            CreateMap<Activity,ActivityForSpeciesDto>();

            //ActivityHistory
            CreateMap<ActivityHistory, ActivityHistoryStatisticDto>()
                .ForMember(x => x.ActivityName, opt => opt.MapFrom(src => src.Activity.Name))
                .ForMember(x => x.Date, opt => opt.MapFrom(src => src.CreatedDate.Date));

            //PetSpecies
            CreateMap<PetSpeciesForActivityCreateDto, PetSpecies>();
            CreateMap<PetSpecies, PetSpeciesDto>();

            //Food
            CreateMap<Food, FoodDto>();
            CreateMap<FoodFeedingDto, Food>()
                .ForMember(x=> x.Id, opt=> opt.MapFrom(src=> src.FoodId));

            //FoodHistory
            CreateMap<FoodHistory,FoodHistoryStatisticDto>()
                .ForMember(x=> x.FoodName, opt=> opt.MapFrom(src => src.Food.Name))
                .ForMember(x=> x.Date, opt=> opt.MapFrom(src=> src.CreatedDate.ToShortDateString()));

            //TrainingHistory
            CreateMap<AddTrainingToPetDto, TrainingHistory>()
                .ForMember(x=> x.Date, opt=> opt.MapFrom(src=> DateTime.SpecifyKind(src.Date, DateTimeKind.Utc)));
            CreateMap<TrainingHistory, TrainingHistoryForPetDto>()
                .ForMember(x => x.Date, opt => opt.MapFrom(src => src.Date.ToString("MM/dd/yyyy HH:mm")))
                .ForMember(x=> x.Name, opt=> opt.MapFrom(src=> src.Training.Name));
        }

        
    }
}
