using Microsoft.AspNetCore.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetCare.Core.Models;
using VirtualPetCare.Core.Repositories;
using VirtualPetCare.Core.Services;

namespace VirtualPetCare.Service.Services
{
    public class LoggerService : ILoggerService
    {
        private readonly ILogRepository _logRepository;

        public LoggerService(ILogRepository logRepository)
        {
            _logRepository = logRepository;
        }

        public async Task AddErrorLog(Exception ex, string url, string action)
        {

            var log = new Log
            {
                Message = ex.Message,
                LogTime = DateTime.UtcNow,
                LogLevel = "Error",
                Source = ex.Source,
                Url = url,
                Action = action
            };

            await _logRepository.AddLog(log);
        }
    }
}
