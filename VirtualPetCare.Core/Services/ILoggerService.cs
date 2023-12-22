using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetCare.Core.Services
{
    public interface ILoggerService
    {
        Task AddErrorLog(Exception exception,string url, string action);
    }
}
