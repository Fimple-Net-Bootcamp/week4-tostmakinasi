using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetCare.Core.DTOs.Training;
using VirtualPetCare.Core.DTOs.TrainingHistory;
using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Core.Services
{
    public interface ITrainingService 
    {
        /// <summary>
        /// Adds a training to a pet.
        /// </summary>
        /// <param name="data">Data for adding a training to a pet.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task AddTrainingToPet(AddTrainingToPetDto data);

        /// <summary>
        /// Gets the training histories for a pet by its ID.
        /// </summary>
        /// <param name="petId">The ID of the pet.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the asynchronous operation, containing the list of training histories for the pet.</returns>
        Task<List<TrainingHistoryForPetDto>> GetTrainingHistoriesByPetId(int petId);

    }
}
