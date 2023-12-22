using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetCare.Core.Models
{
    public class Log
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime LogTime { get; set; }
        public string LogLevel { get; set; }
        public string Source { get; set; }   
        public string Url { get; set; }
        public string Action { get; set; }
    }
}
