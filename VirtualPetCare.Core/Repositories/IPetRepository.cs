using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetCare.Core.DTOs.Pet;
using VirtualPetCare.Core.Models;
using VirtualPetCare.Core.Repositories;

namespace VirtualPetCare.Core.Repositories
{
    /// <summary>
    /// Repository interface for the Pet entity with additional methods for fetching related entities.
    /// </summary>
    public interface IPetRepository : IGenericRepository<Pet>
    {
        /// <summary>
        /// Gets a pet by its ID with the associated owner.
        /// </summary>
        /// <param name="id">The ID of the pet.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the asynchronous operation, containing the pet with its owner.</returns>
        Task<Pet> GetByIdWithOwnerAsync(int id);

        /// <summary>
        /// Gets all pets with their related entities.
        /// </summary>
        /// <returns>A <see cref="Task{TResult}"/> representing the asynchronous operation, containing a collection of pets with related entities.</returns>
        Task<IEnumerable<Pet>> GetAllWithRelation();

        /// <summary>
        /// Gets a pet by its ID with all related entities and their sub-relations.
        /// </summary>
        /// <param name="id">The ID of the pet.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the asynchronous operation, containing the pet with all related entities and sub-relations.</returns>
        Task<Pet> GetByIdWithAllRelationsAndSubRelations(int id);
    }

}
