using SaveCars.ApplicationService.Request.Document;
using SaveCars.ApplicationService.Request.Fabricator;

namespace SaveCars.ApplicationService.Request.Vehicle
{
    public class VehicleRequest
    {
        public string Model { get; set; }
        public string Information { get; set; }
        public string Year { get; set; }
        public decimal Price { get; set; }

        public FabricatorRequest Fabricator { get; set; }

        public DocumentRequest Document { get; set; }
    }
}
