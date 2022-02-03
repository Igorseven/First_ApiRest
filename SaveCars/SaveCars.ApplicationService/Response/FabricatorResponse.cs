using System.Collections.Generic;

namespace SaveCars.ApplicationService.Response
{
    public class FabricatorResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }

        public IEnumerable<VehicleResponse> Vehicles { get; set; }
    }
}
