using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveCars.ApplicationService.Response
{
    public class VehicleResponse
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Information { get; set; }
        public string Year { get; set; }
        public decimal Price { get; set; }

        public FabricatorResponse Fabricator { get; set; }

        public DocumentResponse Document { get; set; }

    }
}
