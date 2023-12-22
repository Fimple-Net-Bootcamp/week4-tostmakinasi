using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Core.Repositories
{
    public interface ILogRepository
    {
        Task AddLog(Log log);
    }
}
