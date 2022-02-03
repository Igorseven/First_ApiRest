using SaveCars.ApplicationService.Request.Vehicle;
using System.Collections.Generic;

namespace SaveCars.ApplicationService.Request.Fabricator
{
    public class FabricatorRequest
    {
        public string Name { get; set; }
        public string Nationality { get; set; }

        public IEnumerable<VehicleRequest> Vehicles { get; set; }
    }
}
