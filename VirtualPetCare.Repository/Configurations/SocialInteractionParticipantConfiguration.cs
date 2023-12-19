using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Repository.Configurations
{
    public class SocialInteractionParticipantConfiguration : BaseEntityConfiguration<SocialInteractionParticipant>
    {
        public void Configure(EntityTypeBuilder<SocialInteractionParticipant> builder)
        {

            builder.HasOne(sip => sip.Pet)
                .WithMany(pet => pet.SocialInteractionParticipants)
                .HasForeignKey(sip => sip.PetId)
                .OnDelete(DeleteBehavior.Cascade);

            // SocialInteractionParticipant ile SocialInteraction arasındaki ilişkiyi belirtmek
            builder.HasOne(sip => sip.SocialInteraction)
                .WithMany(si => si.Participants)
                .HasForeignKey(sip => sip.SocialInteractionId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
