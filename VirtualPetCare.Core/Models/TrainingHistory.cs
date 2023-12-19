using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetCare.Core.Models
{
    public class TrainingHistory : BaseModel
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int TrainingId { get; set; }
        public Training Training { get; set; }


        public int PetId { get; set; }
        public Pet Pet { get; set; }
    }
}
