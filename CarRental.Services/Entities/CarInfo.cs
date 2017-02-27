namespace CarRental.Services.Entities
{
    public class CarInfo
    {
        public CarDto Car { get; set; }
        public int Balance { get; set; }
        public int TotalCars { get; set; }
        public double PricePerHour { get; set; }
    }
}
