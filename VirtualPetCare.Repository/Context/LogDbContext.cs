using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Repository.Context
{
    public class LogDbContext : DbContext
    {
        public DbSet<Log> Logs { get; set; }

        public LogDbContext(DbContextOptions<LogDbContext> options) : base(options)
        {
        }
    }
}
