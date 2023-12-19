using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetCare.Core.DTOs.Pet;
using VirtualPetCare.Core.Models;
using VirtualPetCare.Core.Repositories;
using VirtualPetCare.Repository.Context;

namespace VirtualPetCare.Repository.Repositories
{
    /// <summary>
    /// Repository for interacting with the 'Pet' entity.
    /// </summary>
    public class PetRepository : GenericRepository<Pet>, IPetRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PetRepository"/> class.
        /// </summary>
        /// <param name="context">The application database context.</param>
        public PetRepository(AppDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Gets all pets with specified relations.
        /// </summary>
        /// <returns>A collection of pets with related entities included.</returns>
        public async Task<IEnumerable<Pet>> GetAllWithRelation()
        {
            var pets = await GetAll().Include(x => x.Health).Include(x => x.PetSpecies).ToListAsync();
            return pets;
        }

        /// <summary>
        /// Gets a pet by ID with all related entities and sub-relations.
        /// </summary>
        /// <param name="id">The ID of the pet to retrieve.</param>
        /// <returns>The pet entity with all related entities and sub-relations included.</returns>
        public async Task<Pet> GetByIdWithAllRelationsAndSubRelations(int id)
        {
            var pet = await GetAll()
                                    .Include(x => x.Health)
                                    .Include(x => x.PetSpecies)
                                    .Include(x => x.ActivityHistories)
                                    .ThenInclude(x => x.Activity)
                                    .Include(x => x.FoodHistories)
                                    .ThenInclude(x => x.Food)
                                    .Include(x => x.TrainingHistories)
                                    .ThenInclude(x => x.Training)
                                    .OrderBy(x => x.Id)
                                    .FirstOrDefaultAsync(x => x.Id == id);


            return pet;
        }

        /// <summary>
        /// Gets a pet by ID with the owner included.
        /// </summary>
        /// <param name="id">The ID of the pet to retrieve.</param>
        /// <returns>The pet entity with the owner included.</returns>
        public async Task<Pet> GetByIdWithOwnerAsync(int id)
        {
            var pet = await _context.Pets.Include(x => x.Owner).Include(x => x.Health).FirstOrDefaultAsync(x => x.Id == id);

            return pet;
        }
    }

}
