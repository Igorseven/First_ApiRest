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

            builder.Property(v => v.Fabricator).HasColumnType("varchar(50)")
                .HasColumnName("Fabricator_Name").IsUnicode().IsRequired();

            builder.HasIndex(v => v.Model).IsUnique();
            builder.Property(v => v.Model).HasColumnType("varchar(50)")
                .HasColumnName("Vehicle_Model").IsUnicode().IsRequired();

            builder.Property(v => v.Year).HasColumnType("varchar(9)")
                .HasColumnName("Vehicle_Year").IsUnicode().IsRequired();

            builder.Property(v => v.Information).HasColumnType("varchar(200)")
                .HasColumnName("Vehicle_Information").IsUnicode().IsRequired();

            builder.HasIndex(v => v.VehiclePlate).IsUnique();
            builder.Property(v => v.VehiclePlate).HasColumnType("varchar(8)")
                .HasColumnName("Vehicle_Plate").IsRequired();

            builder.Property(v => v.Price).HasColumnType("numeric")
                .HasColumnName("Vehicle_Price").HasPrecision(12,2).IsRequired();

            
        }
    }
}
