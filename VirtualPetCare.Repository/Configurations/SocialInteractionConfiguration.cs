using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Repository.Configurations
{
    public class SocialInteractionConfiguration : BaseEntityConfiguration<SocialInteraction>
    {
        public void Configure(EntityTypeBuilder<SocialInteraction> builder)
        {

            builder.Property(si => si.Title)
                .IsRequired()
                .HasMaxLength(255); 

            builder.Property(si => si.Description)
                .IsRequired()
                .HasMaxLength(1000); 

            // SocialInteraction ile SocialInteractionParticipant arasındaki ilişkiyi belirtmek
            builder.HasMany(si => si.Participants)
                .WithOne(sip => sip.SocialInteraction)
                .HasForeignKey(sip => sip.SocialInteractionId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
