using SaveCars.ApplicationService.Request.Vehicle;
using System.Collections.Generic;

namespace SaveCars.ApplicationService.Request.Fabricator
{
    public class FabricatorUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }

        public IEnumerable<VehicleUpdateRequest> Vehicles { get; set; }
    }
}
