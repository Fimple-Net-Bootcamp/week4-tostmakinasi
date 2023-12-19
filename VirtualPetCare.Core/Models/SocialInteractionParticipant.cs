using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetCare.Core.Models
{
    public class SocialInteractionParticipant : BaseModel
    {
        public int PetId { get; set; }
        public Pet Pet { get; set; }

        public int SocialInteractionId { get; set; }
        public SocialInteraction SocialInteraction { get; set; }
    }
}
