using SaveCars.ApplicationService.Request.Vehicle;

namespace SaveCars.ApplicationService.Request.Document
{
    public class DocumentUpdateRequest
    {
        public int Id { get; set; }
        public string DocumentNumber { get; set; }
        public string VehiclePlate { get; set; }
        public decimal Tax { get; set; }
        public bool Valid { get; set; }

        public VehicleUpdateRequest Vehicle { get; set; }
    }
}
