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
    public class TrainingHistoryConfiguration : BaseEntityConfiguration<TrainingHistory>
    {
        public void Configure(EntityTypeBuilder<TrainingHistory> builder)
        {

            builder.Property(th => th.TrainingId).IsRequired();
            builder.Property(th => th.PetId).IsRequired();
            builder.Property(th => th.Date).IsRequired().HasDefaultValue(DateTime.UtcNow);

            builder.HasOne(th => th.Training)
                .WithMany(t => t.TrainingHistories)
                .HasForeignKey(th => th.TrainingId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(th => th.Pet)
                .WithMany(p => p.TrainingHistories)
                .HasForeignKey(th => th.PetId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
