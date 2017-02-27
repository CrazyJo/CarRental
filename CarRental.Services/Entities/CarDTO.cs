namespace CarRental.Services.Entities
{
    public class CarDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public CarDto()
        {
        }

        public CarDto(int id)
        {
            Id = id;
        }
    }
}
