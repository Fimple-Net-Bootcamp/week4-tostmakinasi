using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetCare.Core.DTOs.Activity;
using VirtualPetCare.Core.DTOs.Pet;
using VirtualPetCare.Core.Models;
using VirtualPetCare.Core.Repositories;
using VirtualPetCare.Core.Services;
using VirtualPetCare.Core.UnitOfWorks;
using VirtualPetCare.Service.Exceptions;

namespace VirtualPetCare.Service.Services
{
    public class ActivityService : Service<Activity>, IActivityService
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Pet> _petRepository;
        public ActivityService(IUnitOfWork unitOfWork, IGenericRepository<Activity> repository, IMapper mapper, IGenericRepository<Pet> petRepository) : base(unitOfWork, repository)
        {
            _mapper = mapper;
            _petRepository = petRepository;
        }

        /// <inheritdoc/>
        public async Task<List<ActivityForSpeciesDto>> ActivitiesForPet(int petId)
        {
            var pet = await _petRepository.GetByIdAsync(petId);
            if (pet == null)
                throw new NotFoundException($"Pet({petId}) not found");

            var activities = await _petRepository.GetAll().Include(x => x.PetSpecies).ThenInclude(x => x.Activities).SelectMany(x => x.PetSpecies.Activities).ToListAsync();

            if (!activities.Any())
                throw new NotFoundException($"Pet({petId}) activities not found");

            var activityDtos = _mapper.Map<List<ActivityForSpeciesDto>>(activities);

            return activityDtos;
        }

        /// <inheritdoc/>
        public async Task<ActivityDto> CreateAsync(ActivityCreateDto entity)
        {
            var activities = _mapper.Map<Activity>(entity);

            await _repository.AddAsync(activities);

            activities = await _repository.GetAll().Include(x => x.PetSpecies).FirstOrDefaultAsync(x => x.Id == activities.Id);
            
            var activityDto = _mapper.Map<ActivityDto>(entity);

            return activityDto;

        }
    }
}
