﻿using System.Collections.Generic;

namespace SaveCars.Domain.Entities
{
    public class Fabricator : BaseEntity
    {
        public string Name { get; set; }
        public string Nationality { get; set; }

        IEnumerable<Vehicle> Vehicles { get; set; }
    }
}