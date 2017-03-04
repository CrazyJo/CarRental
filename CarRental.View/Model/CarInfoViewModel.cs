namespace CarRental.View.Model
{
    public class CarInfoViewModel
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Balance { get; set; }
        public int TotalCars { get; set; }
        public double PricePerHour { get; set; }
        public bool IsInOrder { get; set; }
    }
}
