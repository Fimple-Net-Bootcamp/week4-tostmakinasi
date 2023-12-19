using AutoMapper;
using Microsoft.EntityFrameworkCore;
using VirtualPetCare.Core.DTOs.SocialInteraction;
using VirtualPetCare.Core.Models;
using VirtualPetCare.Core.Repositories;
using VirtualPetCare.Core.Services;
using VirtualPetCare.Core.UnitOfWorks;
using VirtualPetCare.Service.Exceptions;

namespace VirtualPetCare.Service.Services
{
    /// <inheritdoc/>
    public class SocialInteractionService : Service<SocialInteraction>, ISocialInteractionService
    {
        private readonly IGenericRepository<Pet> _petRepository;
        private readonly IMapper _mapper;
        public SocialInteractionService(IUnitOfWork unitOfWork, IGenericRepository<SocialInteraction> repository, IMapper mapper, IGenericRepository<Pet> petRepository) : base(unitOfWork, repository)
        {
            _mapper = mapper;
            _petRepository = petRepository;
        }
        /// <inheritdoc/>
        public async Task CreateAndStartSocialInteraction(SocialInteractionCreateDto socialInteractionDto)
        {
            await CheckPetIds(socialInteractionDto.PaticipantPetIds);

            var socialInteraction = _mapper.Map<SocialInteraction>(socialInteractionDto);

            await _repository.AddAsync(socialInteraction);

            await _unitOfWork.CommitChangesAsync();

        }
        
        private async Task CheckPetIds(List<int> petIds)
        {
            foreach (var id in petIds)
            {
                if(!(await _petRepository.AnyAsync(x=> x.Id == id)))
                {
                    throw new  NotFoundException($"Pet({id}) was not found so the social event could not be started."); 
                }
            }
        }

        /// <inheritdoc/>
        public async Task<List<SocialInteractionDto>> GetSocialInteractionsByPetId(int petId)
        {
            var petCheck = await _petRepository.AnyAsync(x=> x.Id == petId);

            if (!petCheck)
                throw new NotFoundException($"Pet({petId}) not found");

            var socialEvents = await _petRepository.GetAll().Where(x=> x.Id == petId).Include(x=> x.SocialInteractionParticipants).ThenInclude(x=> x.SocialInteraction).Where(x=> x.Id==petId).SelectMany(x=> x.SocialInteractionParticipants).ToListAsync();

            if(socialEvents is null || socialEvents.Count <= 0)
                throw new NotFoundException($"Pet({petId}) social interactions not found.");

            var dtos = _mapper.Map<List<SocialInteractionDto>>(socialEvents);

            return dtos;
        }
    }
}
