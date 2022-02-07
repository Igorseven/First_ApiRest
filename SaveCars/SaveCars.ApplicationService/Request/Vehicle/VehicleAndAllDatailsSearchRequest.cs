namespace SaveCars.ApplicationService.Request.Vehicle
{
    public class VehicleAndAllDatailsSearchRequest
    {
        public string Model { get; set; }
        public string Information { get; set; }
        public string Year { get; set; }
        public decimal Price { get; set; }

        public int FabricatorId { get; set; }
        public int DocumentId { get; set; }
    }
}
