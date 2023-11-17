﻿// <auto-generated />
using System;
using Garage3._0.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Garage.Persistence.Migrations
{
    [DbContext(typeof(Garage3_0Context))]
    partial class Garage3_0ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Garage.Core.Entities.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Membership")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Driver");
                });

            modelBuilder.Entity("Garage.Core.Entities.Vehicle", b =>
                {
                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleTypesId")
                        .HasColumnType("int");

                    b.HasKey("DriverId", "VehicleTypeId");

                    b.HasIndex("VehicleTypesId");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("Garage.Core.Entities.VehicleTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("VehicleTypes");
                });

            modelBuilder.Entity("Garage.Core.Entities.Vehicle", b =>
                {
                    b.HasOne("Garage.Core.Entities.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Garage.Core.Entities.VehicleTypes", "VehicleTypes")
                        .WithMany("Vehicle")
                        .HasForeignKey("VehicleTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");

                    b.Navigation("VehicleTypes");
                });

            modelBuilder.Entity("Garage.Core.Entities.VehicleTypes", b =>
                {
                    b.Navigation("Vehicle");
                });
#pragma warning restore 612, 618
        }
    }
}
