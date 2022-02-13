namespace SaveCars.ApplicationService.Request.Vehicle
{
    public class VehicleSaveRequest
    {
        public string Fabricator { get; set; }
        public string Model { get; set; }
        public string Information { get; set; }
        public string VehiclePlate { get; set; }
        public string Year { get; set; }
        public decimal Price { get; set; }
    }
}
