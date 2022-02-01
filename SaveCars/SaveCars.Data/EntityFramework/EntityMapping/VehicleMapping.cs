using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SaveCars.Domain.Entities;

namespace SaveCars.Data.EntityFramework.EntityMapping
{
    public class VehicleMapping : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.ToTable("Vehicles");
            builder.HasKey(v => v.Id).HasName("Pk_Vehicle");

            builder.HasIndex(v => v.Model).IsUnique();
            builder.Property(v => v.Model).HasColumnType("varchar(50)")
                .HasColumnName("Vehicle_Model").IsUnicode().IsRequired();

            builder.Property(v => v.Information).HasColumnType("varchar(200)")
                .HasColumnName("Vehicle_Information").IsUnicode().IsRequired();

            builder.Property(v => v.Price).HasColumnType("numeric")
                .HasColumnName("Vehicle_Price").HasPrecision(2).IsRequired();

            
        }
    }
}
