using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_license_plate__CLP__DB
{
    public class BrandsCfgs : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Cars).WithOne(x => x.Brand).HasForeignKey(x => x.BrandId);

            builder.HasData(new Brand[]
            {
                new Brand() { Id = 1, CountryId = 5, Name = "Audi" },
                new Brand() { Id = 2, CountryId = 5, Name = "Mercedes" },
                new Brand() { Id = 3, CountryId = 5, Name = "Fiat" },
                new Brand() { Id = 4, CountryId = 5, Name = "BMW" },
                new Brand() { Id = 5, CountryId = 11, Name = "Škoda" },
                new Brand() { Id = 6, CountryId = 2, Name = "Jeep" },
                new Brand() { Id = 7, CountryId = 13, Name = "Maseratti" },
                new Brand() { Id = 8, CountryId = 14, Name = "Koenigsegg" },
                new Brand() { Id = 9, CountryId = 13, Name = "Lamborghini" },
                new Brand() { Id = 10, CountryId = 11, Name = "McLaren" },
                new Brand() { Id = 11, CountryId = 2, Name = "Delorean" },
                new Brand() { Id = 12, CountryId = 5, Name = "Siat" },
                new Brand() { Id = 13, CountryId = 7, Name = "Nisan" },
                new Brand() { Id = 14, CountryId = 5, Name = "Opel" },
                new Brand() { Id = 15, CountryId = 2, Name = "Lincoln" },
                new Brand() { Id = 16, CountryId = 7, Name = "Suzuki" },
                new Brand() { Id = 17, CountryId = 4, Name = "Volvo" },
                new Brand() { Id = 18, CountryId = 15, Name = "Scania" },
                new Brand() { Id = 19, CountryId = 16, Name = "DAF" },
                new Brand() { Id = 20, CountryId = 2, Name = "Tesla" },
                new Brand() { Id = 21, CountryId = 5, Name = "Volkswagen" },
                new Brand() { Id = 22, CountryId = 17, Name = "Cupra" },
                new Brand() { Id = 23, CountryId = 7, Name = "Toyota" },
                new Brand() { Id = 24, CountryId = 7, Name = "Subaru" },
            });
        }
    }
}