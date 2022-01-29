namespace SaveCars.Domain.Entities
{
    public class Vehicle : BaseEntity
    {
        public string Model { get; set; }
        public string Information { get; set; }
        public string Year { get; set; }
        public decimal Price { get; set; }

        public Fabricator Fabricator { get; set; }
        public int FabricatorId { get; set; }

        public Document Document { get; set; }
        public int DocumentId { get; set; }
    }
}
