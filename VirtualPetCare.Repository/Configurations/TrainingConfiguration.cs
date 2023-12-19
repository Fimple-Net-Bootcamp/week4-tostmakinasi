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
    public class TrainingConfiguration : BaseEntityConfiguration<Training>
    {
        public void Configure(EntityTypeBuilder<Training> builder)
        {

            builder.Property(t => t.Name).IsRequired().HasMaxLength(100);

            builder.HasMany(t => t.TrainingHistories)
                .WithOne(th => th.Training)
                .HasForeignKey(th => th.TrainingId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
