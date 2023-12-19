using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetCare.Core.Models
{
    public class SocialInteraction:BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<SocialInteractionParticipant> Participants { get; set; }
    }
}
