using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SaveCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveCars.Data.EntityFramework.EntityMapping
{
    public class DocumentMapping : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.ToTable("Documents");
            builder.HasKey(d => d.Id).HasName("Pk_Document");

            builder.HasIndex(d => d.DocumentNumber).IsUnique();
            builder.Property(d => d.DocumentNumber).HasColumnType("varchar(12)")
                .HasColumnName("Document_Number").IsRequired();

            builder.HasIndex(d => d.VehiclePlate).IsUnique();
            builder.Property(d => d.VehiclePlate).HasColumnType("varchar(8)")
                .HasColumnName("Vehicle_Plate").IsRequired();

            builder.Property(d => d.Tax).HasColumnType("numeric")
                .HasColumnName("Document_Tax").HasPrecision(2).IsRequired();

            builder.HasOne(d => d.Vehicle).WithOne(v => v.Document)
                .HasForeignKey<Vehicle>(v => v.DocumentId);
        }
    }
}
