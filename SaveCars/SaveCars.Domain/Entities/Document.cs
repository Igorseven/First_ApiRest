namespace SaveCars.Domain.Entities
{
    public class Document : BaseEntity
    {
        public string DocumentNumber { get; set; }
        public string VehiclePlate { get; set; }
        public decimal Tax { get; set; }
        public bool Valid { get; set; }

        public Vehicle Vehicle { get; set; }
        public int VehicleId { get; set; }
    }
}
