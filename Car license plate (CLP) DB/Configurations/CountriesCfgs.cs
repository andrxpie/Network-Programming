using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace Car_license_plate__CLP__DB
{
    public class CountriesCfgs : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Brands).WithOne(x => x.Country).HasForeignKey(x => x.CountryId);

            builder.HasData(new[]
            {
                new Country() { Id = 1, Name = "Ukraine" },
                new Country() { Id = 2, Name = "USA" },
                new Country() { Id = 3, Name = "Poland" },
                new Country() { Id = 4, Name = "Sweden" },
                new Country() { Id = 5, Name = "German" },
                new Country() { Id = 6, Name = "Turkey" },
                new Country() { Id = 7, Name = "Japan" },
                new Country() { Id = 8, Name = "China" },
                new Country() { Id = 9, Name = "Greenland" },
                new Country() { Id = 10, Name = "Iceland" },
                new Country() { Id = 11, Name = "UK" },
                new Country() { Id = 12, Name = "Czech" },
                new Country() { Id = 13, Name = "Italy" },
                new Country() { Id = 14, Name = "Canada" },
                new Country() { Id = 15, Name = "Belgium" },
                new Country() { Id = 16, Name = "Netherlands" },
                new Country() { Id = 17, Name = "Spain" },
            });
        }
    }
}
