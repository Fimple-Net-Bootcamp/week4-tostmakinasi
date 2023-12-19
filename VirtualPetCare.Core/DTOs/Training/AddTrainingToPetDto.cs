using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetCare.Core.DTOs.Training
{
    public class AddTrainingToPetDto
    {
        public int TrainingId { get; set; }
        public int PetId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
