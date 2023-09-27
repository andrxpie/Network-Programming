namespace Car_license_plate__CLP__DB
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}