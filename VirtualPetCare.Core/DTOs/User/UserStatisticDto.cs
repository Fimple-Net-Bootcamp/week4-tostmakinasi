using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetCare.Core.DTOs.Pet;

namespace VirtualPetCare.Core.DTOs.User
{
    public class UserStatisticDto
    {

        public string UserName { get; set; }
        public string FullName { get; set; }

        public List<PetStatisticsForUserDto> Pets { get; set; }
    }
}
