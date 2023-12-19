using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetCare.Core.DTOs.ActivityHisroty;
using VirtualPetCare.Core.DTOs.FoodHistory;
using VirtualPetCare.Core.DTOs.Health;
using VirtualPetCare.Core.DTOs.TrainingHistory;

namespace VirtualPetCare.Core.DTOs.Pet
{
    public class PetStatisticsForUserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Age { get; set; }

        public HealthStatisticDto Health { get; set; }
        public List<FoodHistoryStatisticDto> FoodHistories { get; set; }
        public List<ActivityHistoryStatisticDto> ActivityHistories { get; set; }

        public List<TrainingHistoryForPetStatisticDto> TrainingHistories { get; set; }
    }
}
