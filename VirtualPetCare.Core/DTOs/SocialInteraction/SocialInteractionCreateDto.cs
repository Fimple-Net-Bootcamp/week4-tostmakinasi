using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetCare.Core.DTOs.SocialInteraction
{
    public class SocialInteractionCreateDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<int> PaticipantPetIds{ get; set; }
    }
}
