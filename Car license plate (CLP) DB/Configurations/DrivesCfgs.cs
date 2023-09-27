using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_license_plate__CLP__DB
{
    public class DrivesCfgs : IEntityTypeConfiguration<Drive>
    {
        public void Configure(EntityTypeBuilder<Drive> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Cars).WithOne(x => x.Drive).HasForeignKey(x => x.DriveId);

            builder.HasData(new Drive[]
            {
                new Drive() { Id = 1, Name = "Back" },
                new Drive() { Id = 2, Name = "Front" },
                new Drive() { Id = 3, Name = "Full" }
            });
        }
    }
}
