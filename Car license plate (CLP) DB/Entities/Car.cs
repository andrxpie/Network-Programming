using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Drawing;

namespace Car_license_plate__CLP__DB
{
    public partial class Car
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public int ColorId { get; set; }
        public Color Color { get; set; }
        public string LicensePlate { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
        public string Owner { get; set; }
        public bool IsWanted { get; set; }
        public int DriveId { get; set; }
        public Drive Drive { get; set; }

        public override string ToString()
        {
            string message = $"DB Id: {Id}\n";

            message += $"Brand: {Brand.Name}\n";
            message += $"Model: {Model}\n";
            message += $"Color: {Color.Name}\n";
            message += $"LP: {LicensePlate}\n";
            message += $"Year: {Year}\n";
            message += $"Mileage: {Mileage} km\n";
            message += $"Owner: {Owner}\n";
            message += $"Is wanted: {IsWanted}\n";
            message += $"Drive: {Drive.Name}";

            return message;
        }
    }
}