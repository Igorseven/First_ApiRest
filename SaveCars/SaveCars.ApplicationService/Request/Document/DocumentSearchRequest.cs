namespace SaveCars.ApplicationService.Request.Document
{
    public class DocumentSearchRequest
    {
        public string DocumentNumber { get; set; }
        public string VehiclePlate { get; set; }
        public decimal Tax { get; set; }
        public bool Valid { get; set; }
    }
}
