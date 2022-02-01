using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SaveCars.Domain.Entities;

namespace SaveCars.Data.EntityFramework.EntityMapping
{
    public class FabricatorMapping : IEntityTypeConfiguration<Fabricator>
    {
        public void Configure(EntityTypeBuilder<Fabricator> builder)
        {
            builder.ToTable("Fabricators");
            builder.HasKey(f => f.Id).HasName("Pk_Fabricator");

            builder.Property(f => f.Name).HasColumnType("varchar(50)")
                .HasColumnName("Fabricator_Name").IsUnicode().IsRequired();

            builder.Property(f => f.Nationality).HasColumnType("varchar(70)")
                .HasColumnName("Fabricator_Nationality");

            builder.HasMany(f => f.Vehicles).WithOne(v => v.Fabricator)
                .HasForeignKey(v => v.FabricatorId);
        }
    }
}
