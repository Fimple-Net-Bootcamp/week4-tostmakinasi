using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetCare.Core.Models;
using VirtualPetCare.Core.Repositories;
using VirtualPetCare.Repository.Context;

namespace VirtualPetCare.Repository.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<User> GetByIdWithRelationsAndSubRelations(int id)
        {
            var user = await GetAll()
                .Include(x => x.Pets)
                    .ThenInclude(x => x.Health)
                .Include(x => x.Pets)
                    .ThenInclude(x => x.PetSpecies)
                .Include(x => x.Pets).ThenInclude(x => x.FoodHistories)
                        .ThenInclude(x => x.Food)
                .Include(x => x.Pets)
                .ThenInclude(x => x.FoodHistories)
                        .ThenInclude(x => x.Food)
                .Include(x => x.Pets)
                .ThenInclude(x => x.ActivityHistories)
                        .ThenInclude(x => x.Activity)
                 .Include(x => x.Pets)
                 .ThenInclude(x => x.TrainingHistories)
                        .ThenInclude(x => x.Training)
                .FirstOrDefaultAsync(X => X.Id == id);
            return user;
        }

        async Task<User> IUserRepository.GetByIdWithOwnershipsAsync(int id)
        {
            var user = await _context.Users.Include(x => x.Pets).ThenInclude(x=> x.Health).FirstOrDefaultAsync(x=> x.Id == id);

            return user;
        }
    }
}
