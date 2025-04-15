﻿// <auto-generated />
using System;
using Meditrans.Shared.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Meditrans.Shared.Migrations
{
    [DbContext(typeof(MediTransContext))]
    [Migration("20250415075403_AddIsActiveToFundingSource")]
    partial class AddIsActiveToFundingSource
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Meditrans.Shared.Entities.BillingItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("APAccount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("APCompany")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("APSubAccount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ARAccount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ARCompany")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ARSubAccount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCopay")
                        .HasColumnType("bit");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UnitId");

                    b.ToTable("BillingItems");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.CapacityDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SpaceTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SpaceTypeId");

                    b.ToTable("CapacityDetails");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.CapacityType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Capacities");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FundingSourceId")
                        .HasColumnType("int");

                    b.Property<string>("MobilePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PolicyNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpaceTypeId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FundingSourceId");

                    b.HasIndex("SpaceTypeId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.FundingSource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("BarcodeScanRequired")
                        .HasColumnType("bit");

                    b.Property<string>("ContactFirst")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactLast")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("DriverSignatureDropoff")
                        .HasColumnType("bit");

                    b.Property<bool?>("DriverSignaturePickup")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FAX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("RequireOdometer")
                        .HasColumnType("bit");

                    b.Property<bool?>("SignatureDropoff")
                        .HasColumnType("bit");

                    b.Property<bool?>("SignaturePickup")
                        .HasColumnType("bit");

                    b.Property<string>("VectorcareFacilityId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FundingSources");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.FundingSourceBillingItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BillingItemId")
                        .HasColumnType("int");

                    b.Property<int>("FreeQty")
                        .HasColumnType("int");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FundingSourceId")
                        .HasColumnType("int");

                    b.Property<int>("GreaterThanMinQty")
                        .HasColumnType("int");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<int>("LessOrEqualMaxQty")
                        .HasColumnType("int");

                    b.Property<decimal>("MaxCharge")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinCharge")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Per")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcedureCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SpaceTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BillingItemId");

                    b.HasIndex("FundingSourceId");

                    b.HasIndex("SpaceTypeId");

                    b.ToTable("FundingSourceBillingItems");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.Provider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Distance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<TimeSpan>("ETA")
                        .HasColumnType("time");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleRouteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TripId");

                    b.HasIndex("VehicleRouteId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.SpaceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CapacityTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<float>("LoadTime")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("UnloadTime")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CapacityTypeId");

                    b.ToTable("SpaceTypes");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DropoffAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DropoffLatitude")
                        .HasColumnType("float");

                    b.Property<double>("DropoffLongitude")
                        .HasColumnType("float");

                    b.Property<TimeSpan>("FromTime")
                        .HasColumnType("time");

                    b.Property<bool>("IsCancelled")
                        .HasColumnType("bit");

                    b.Property<string>("PickupAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PickupLatitude")
                        .HasColumnType("float");

                    b.Property<double>("PickupLongitude")
                        .HasColumnType("float");

                    b.Property<string>("PickupNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpaceTypeId")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("ToTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SpaceTypeId");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DriverLicense")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CapacityTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<bool>("IsInactive")
                        .HasColumnType("bit");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CapacityTypeId");

                    b.HasIndex("GroupId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.VehicleGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VehicleGroups");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.VehicleRoute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<string>("Garage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.HasIndex("VehicleId");

                    b.ToTable("VehicleRoutes");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.BillingItem", b =>
                {
                    b.HasOne("Meditrans.Shared.Entities.Unit", "Unit")
                        .WithMany("BillingItems")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.CapacityDetail", b =>
                {
                    b.HasOne("Meditrans.Shared.Entities.SpaceType", "SpaceType")
                        .WithMany("CapacityDetails")
                        .HasForeignKey("SpaceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SpaceType");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.Customer", b =>
                {
                    b.HasOne("Meditrans.Shared.Entities.FundingSource", "FundingSource")
                        .WithMany("Customers")
                        .HasForeignKey("FundingSourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Meditrans.Shared.Entities.SpaceType", "SpaceType")
                        .WithMany("Customers")
                        .HasForeignKey("SpaceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FundingSource");

                    b.Navigation("SpaceType");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.FundingSourceBillingItem", b =>
                {
                    b.HasOne("Meditrans.Shared.Entities.BillingItem", "BillingItem")
                        .WithMany("FundingSourceBillingItems")
                        .HasForeignKey("BillingItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Meditrans.Shared.Entities.FundingSource", "FundingSource")
                        .WithMany("BillingItems")
                        .HasForeignKey("FundingSourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Meditrans.Shared.Entities.SpaceType", "SpaceType")
                        .WithMany("FundingSourceBillingItems")
                        .HasForeignKey("SpaceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BillingItem");

                    b.Navigation("FundingSource");

                    b.Navigation("SpaceType");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.Schedule", b =>
                {
                    b.HasOne("Meditrans.Shared.Entities.Trip", "Trip")
                        .WithMany("Schedules")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Meditrans.Shared.Entities.VehicleRoute", "VehicleRoute")
                        .WithMany("Schedules")
                        .HasForeignKey("VehicleRouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trip");

                    b.Navigation("VehicleRoute");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.SpaceType", b =>
                {
                    b.HasOne("Meditrans.Shared.Entities.CapacityType", "CapacityType")
                        .WithMany("SpaceTypes")
                        .HasForeignKey("CapacityTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CapacityType");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.Trip", b =>
                {
                    b.HasOne("Meditrans.Shared.Entities.Customer", "Customer")
                        .WithMany("Trips")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Meditrans.Shared.Entities.SpaceType", "SpaceType")
                        .WithMany("Trips")
                        .HasForeignKey("SpaceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("SpaceType");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.User", b =>
                {
                    b.HasOne("Meditrans.Shared.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.Vehicle", b =>
                {
                    b.HasOne("Meditrans.Shared.Entities.CapacityType", "CapacityType")
                        .WithMany("Vehicles")
                        .HasForeignKey("CapacityTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Meditrans.Shared.Entities.VehicleGroup", "VehicleGroup")
                        .WithMany("Vehicles")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CapacityType");

                    b.Navigation("VehicleGroup");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.VehicleRoute", b =>
                {
                    b.HasOne("Meditrans.Shared.Entities.User", "Driver")
                        .WithMany("VehicleRoutes")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Meditrans.Shared.Entities.Vehicle", "Vehicle")
                        .WithMany("VehicleRoutes")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.BillingItem", b =>
                {
                    b.Navigation("FundingSourceBillingItems");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.CapacityType", b =>
                {
                    b.Navigation("SpaceTypes");

                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.Customer", b =>
                {
                    b.Navigation("Trips");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.FundingSource", b =>
                {
                    b.Navigation("BillingItems");

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.SpaceType", b =>
                {
                    b.Navigation("CapacityDetails");

                    b.Navigation("Customers");

                    b.Navigation("FundingSourceBillingItems");

                    b.Navigation("Trips");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.Trip", b =>
                {
                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.Unit", b =>
                {
                    b.Navigation("BillingItems");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.User", b =>
                {
                    b.Navigation("VehicleRoutes");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.Vehicle", b =>
                {
                    b.Navigation("VehicleRoutes");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.VehicleGroup", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Meditrans.Shared.Entities.VehicleRoute", b =>
                {
                    b.Navigation("Schedules");
                });
#pragma warning restore 612, 618
        }
    }
}
