using SaveCars.ApplicationService.Request.Document;
using SaveCars.ApplicationService.Request.Fabricator;

namespace SaveCars.ApplicationService.Request.Vehicle
{
    public class VehicleUpdateRequest
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Information { get; set; }
        public string Year { get; set; }
        public decimal Price { get; set; }

        public FabricatorUpdateRequest Fabricator { get; set; }

        public DocumentUpdateRequest Document { get; set; }
    }
}
