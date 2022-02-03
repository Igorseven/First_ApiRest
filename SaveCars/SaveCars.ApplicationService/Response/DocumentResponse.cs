namespace SaveCars.ApplicationService.Response
{
    public class DocumentResponse
    {
        public int Id { get; set; }
        public string DocumentNumber { get; set; }
        public string VehiclePlate { get; set; }
        public decimal Tax { get; set; }
        public bool Valid { get; set; }

        public VehicleResponse Vehicle { get; set; }
    }
}
