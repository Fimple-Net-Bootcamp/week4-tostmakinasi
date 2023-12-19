using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetCare.Core.DTOs.SocialInteraction;

namespace VirtualPetCare.Core.Services
{
    /// <summary>
    /// Service interface for social interactions.
    /// </summary>
    public interface ISocialInteractionService
    {
        /// <summary>
        /// Creates and starts a new social interaction.
        /// </summary>
        /// <param name="socialInteraction">Data for creating a new social interaction.</param>
        Task CreateAndStartSocialInteraction(SocialInteractionCreateDto socialInteraction);

        /// <summary>
        /// Retrieves social interactions participated by the specified pet.
        /// </summary>
        /// <param name="petId">ID of the pet.</param>
        /// <returns>List of social interactions for the pet.</returns>
        Task<List<SocialInteractionDto>> GetSocialInteractionsByPetId(int petId);
    }

}
