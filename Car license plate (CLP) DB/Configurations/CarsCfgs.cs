using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_license_plate__CLP__DB
{
    public class CarsCfgs : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(new Car[]
            {
                new Car() { Id = 1,
                            BrandId = 1,
                            Model = "RS 7",
                            ColorId = 10,
                            LicensePlate = "BK6969TR", 
                            Year = 2023, 
                            Mileage = 0, 
                            Owner = "ANDRII HRITSIUK", 
                            IsWanted = false, 
                            DriveId = 3 },

                new Car() { Id = 2,
                            BrandId = 2,
                            Model = "220",
                            ColorId = 8,
                            LicensePlate = "BK1986CH", 
                            Year = 2015, 
                            Mileage = 1986.04, 
                            Owner = "SVIATOSLAV SAPACH", 
                            IsWanted = false, 
                            DriveId = 2 },
            });
        }
    }
}
