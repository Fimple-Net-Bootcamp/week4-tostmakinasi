using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetCare.Core.DTOs.Training;
using VirtualPetCare.Core.DTOs.TrainingHistory;
using VirtualPetCare.Core.Models;
using VirtualPetCare.Core.Repositories;
using VirtualPetCare.Core.Services;
using VirtualPetCare.Core.UnitOfWorks;
using VirtualPetCare.Service.Exceptions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VirtualPetCare.Service.Services
{
    public class TrainingService :ITrainingService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<TrainingHistory> _historyRepository;
        private readonly IGenericRepository<Pet> _petRepository;
        private readonly IGenericRepository<Training> _trainingRepository;
        private readonly IMapper _mapper;

        public TrainingService(IUnitOfWork unitOfWork, IGenericRepository<TrainingHistory> historyRepository, IGenericRepository<Training> trainingRepository, IMapper mapper, IGenericRepository<Pet> petRepository)
        {
            _unitOfWork = unitOfWork;
            _historyRepository = historyRepository;
            _trainingRepository = trainingRepository;
            _mapper = mapper;
            _petRepository = petRepository;
        }

        /// <inheritdoc/>
        public async Task AddTrainingToPet(AddTrainingToPetDto data)
        {
            var petCheck = await _petRepository.AnyAsync(x => x.Id == data.PetId);

            if (!petCheck)
                throw new NotFoundException($"Pet({data.PetId}) not found.");

            var trainingCheck = await _trainingRepository.AnyAsync(x=> x.Id == data.TrainingId);

            if (!trainingCheck)
                throw new NotFoundException($"Training({data.PetId}) not found.");

            var trainingHistory = _mapper.Map<TrainingHistory>(data);

            await _historyRepository.AddAsync(trainingHistory);
            _unitOfWork.CommitChanges();
        }

        /// <inheritdoc/>
        public async Task<List<TrainingHistoryForPetDto>> GetTrainingHistoriesByPetId(int petId)
        {

            var petCheck = await _petRepository.AnyAsync(x => x.Id == petId);

            if (!petCheck)
                throw new NotFoundException($"Pet({petId}) not found.");

            var histories = await _historyRepository.GetAll().Include(x=> x.Training).Where(x=> x.PetId == petId).ToListAsync();

            if(!histories.Any())
                throw new NotFoundException($"Pet({petId}) Training History not found.");

            var historyDtos = _mapper.Map<List<TrainingHistoryForPetDto>>(histories);

            return historyDtos;
        }
    }
}
