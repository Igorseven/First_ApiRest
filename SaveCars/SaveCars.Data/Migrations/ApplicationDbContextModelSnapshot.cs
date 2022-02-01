﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SaveCars.Data.EntityFramework.Context;

namespace SaveCars.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SaveCars.Domain.Entities.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasColumnType("varchar(12)")
                        .HasColumnName("Document_Number");

                    b.Property<decimal>("Tax")
                        .HasPrecision(2)
                        .HasColumnType("numeric(2)")
                        .HasColumnName("Document_Tax");

                    b.Property<bool>("Valid")
                        .HasColumnType("bit");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.Property<string>("VehiclePlate")
                        .IsRequired()
                        .HasColumnType("varchar(8)")
                        .HasColumnName("Vehicle_Plate");

                    b.HasKey("Id")
                        .HasName("Pk_Document");

                    b.HasIndex("DocumentNumber")
                        .IsUnique();

                    b.HasIndex("VehiclePlate")
                        .IsUnique();

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("SaveCars.Domain.Entities.Fabricator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Fabricator_Name");

                    b.Property<string>("Nationality")
                        .HasColumnType("varchar(70)")
                        .HasColumnName("Fabricator_Nationality");

                    b.HasKey("Id")
                        .HasName("Pk_Fabricator");

                    b.ToTable("Fabricators");
                });

            modelBuilder.Entity("SaveCars.Domain.Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DocumentId")
                        .HasColumnType("int");

                    b.Property<int>("FabricatorId")
                        .HasColumnType("int");

                    b.Property<string>("Information")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("Vehicle_Information");

                    b.Property<string>("Model")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Vehicle_Model");

                    b.Property<decimal>("Price")
                        .HasPrecision(2)
                        .HasColumnType("numeric(2)")
                        .HasColumnName("Vehicle_Price");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("Pk_Vehicle");

                    b.HasIndex("DocumentId")
                        .IsUnique();

                    b.HasIndex("FabricatorId");

                    b.HasIndex("Model")
                        .IsUnique();

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("SaveCars.Domain.Entities.Vehicle", b =>
                {
                    b.HasOne("SaveCars.Domain.Entities.Document", "Document")
                        .WithOne("Vehicle")
                        .HasForeignKey("SaveCars.Domain.Entities.Vehicle", "DocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SaveCars.Domain.Entities.Fabricator", "Fabricator")
                        .WithMany("Vehicles")
                        .HasForeignKey("FabricatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Document");

                    b.Navigation("Fabricator");
                });

            modelBuilder.Entity("SaveCars.Domain.Entities.Document", b =>
                {
                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("SaveCars.Domain.Entities.Fabricator", b =>
                {
                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
