using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_license_plate__CLP__DB
{
    public class ColorsCfgs : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Cars).WithOne(x => x.Color).HasForeignKey(x => x.ColorId);

            builder.HasData(new Color[]
            {
                new Color() { Id = 1, Name = "Red" },
                new Color() { Id = 2, Name = "Orange" },
                new Color() { Id = 3, Name = "Yellow" },
                new Color() { Id = 4, Name = "Lime" },
                new Color() { Id = 5, Name = "Green" },
                new Color() { Id = 6, Name = "Blue" },
                new Color() { Id = 7, Name = "Purple" },
                new Color() { Id = 8, Name = "Silver" },
                new Color() { Id = 9, Name = "Gold" },
                new Color() { Id = 10, Name = "Black" },
                new Color() { Id = 11, Name = "White" },
            });
        }
    }
}