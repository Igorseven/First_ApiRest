namespace SaveCars.ApplicationService.Request.Vehicle
{
    public class VehicleSearchRequest : PageRequest
    {
        public string Model { get; set; }
        public string Information { get; set; }
        public string Year { get; set; }
        public decimal Price { get; set; }
    }
}
