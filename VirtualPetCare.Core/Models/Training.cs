using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetCare.Core.Models
{
    public class Training : BaseModel
    {
        public string Name { get; set; }

        public List<TrainingHistory> TrainingHistories { get; set; }
    }
}
