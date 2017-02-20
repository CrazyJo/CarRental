namespace CarRental.Services.Entities
{
    public class CarDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public CarDTO()
        {
        }

        public CarDTO(int id)
        {
            Id = id;
        }
    }
}
