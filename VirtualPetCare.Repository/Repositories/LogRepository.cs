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
    public class LogRepository : ILogRepository
    {
        private readonly LogDbContext _context;
        public LogRepository(LogDbContext context)
        {
            _context = context;
        }
        public async Task AddLog(Log log)
        {
            await _context.Logs.AddAsync(log);
            await _context.SaveChangesAsync();
        }
    }
}
