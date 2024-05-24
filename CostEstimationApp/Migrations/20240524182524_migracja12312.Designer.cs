﻿// <auto-generated />
using System;
using CostEstimationApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CostEstimationApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240524182524_migracja12312")]
    partial class migracja12312
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CostEstimationApp.Models.Machine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("CostPerHour")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MachineTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MachineTypeId");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("CostEstimationApp.Models.MachineType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("AdditionalTime")
                        .HasColumnType("float");

                    b.Property<string>("Typeof")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MachineTypes");
                });

            modelBuilder.Entity("CostEstimationApp.Models.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Density")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PricePerKg")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("CostEstimationApp.Models.MRR", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ToolMaterialId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ToolMaterialId");

                    b.HasIndex("MaterialId", "ToolMaterialId")
                        .IsUnique();

                    b.ToTable("MRRs");
                });

            modelBuilder.Entity("CostEstimationApp.Models.Operation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal?>("CuttingDepth")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("CuttingLength")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("CuttingWidth")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("DrillDepth")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("DrillDiameter")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("HeightAfterOperation")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("HeightBeforeOperation")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LengthAfterOperation")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LengthBeforeOperation")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MRRId")
                        .HasColumnType("int");

                    b.Property<int>("MachineId")
                        .HasColumnType("int");

                    b.Property<decimal>("MachiningTime")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("OperationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SemiFinishedProductId")
                        .HasColumnType("int");

                    b.Property<int>("ToolId")
                        .HasColumnType("int");

                    b.Property<decimal>("VolumeToRemove")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("WidthAfterOperation")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("WidthBeforeOperation")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("WorkerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MRRId");

                    b.HasIndex("MachineId");

                    b.HasIndex("SemiFinishedProductId");

                    b.HasIndex("ToolId");

                    b.HasIndex("WorkerId");

                    b.ToTable("Operations");
                });

            modelBuilder.Entity("CostEstimationApp.Models.SemiFinishedProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("DimensionX")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DimensionY")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DimensionZ")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaterialId");

                    b.ToTable("SemiFinishedProducts");
                });

            modelBuilder.Entity("CostEstimationApp.Models.Tool", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("CostPerHour")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ToolMaterialId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ToolMaterialId");

                    b.ToTable("Tools");
                });

            modelBuilder.Entity("CostEstimationApp.Models.ToolMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ToolMaterials");
                });

            modelBuilder.Entity("CostEstimationApp.Models.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("CostPerHour")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("CostEstimationApp.Models.Machine", b =>
                {
                    b.HasOne("CostEstimationApp.Models.MachineType", "MachineType")
                        .WithMany("Machine")
                        .HasForeignKey("MachineTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("MachineType");
                });

            modelBuilder.Entity("CostEstimationApp.Models.MRR", b =>
                {
                    b.HasOne("CostEstimationApp.Models.Material", "Material")
                        .WithMany("MRR")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CostEstimationApp.Models.ToolMaterial", "ToolMaterial")
                        .WithMany("MRR")
                        .HasForeignKey("ToolMaterialId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Material");

                    b.Navigation("ToolMaterial");
                });

            modelBuilder.Entity("CostEstimationApp.Models.Operation", b =>
                {
                    b.HasOne("CostEstimationApp.Models.MRR", "MRR")
                        .WithMany("Operation")
                        .HasForeignKey("MRRId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CostEstimationApp.Models.Machine", "Machine")
                        .WithMany("Operation")
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CostEstimationApp.Models.SemiFinishedProduct", "SemiFinishedProduct")
                        .WithMany("Operation")
                        .HasForeignKey("SemiFinishedProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CostEstimationApp.Models.Tool", "Tool")
                        .WithMany("Operation")
                        .HasForeignKey("ToolId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CostEstimationApp.Models.Worker", "Worker")
                        .WithMany("Operation")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("MRR");

                    b.Navigation("Machine");

                    b.Navigation("SemiFinishedProduct");

                    b.Navigation("Tool");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("CostEstimationApp.Models.SemiFinishedProduct", b =>
                {
                    b.HasOne("CostEstimationApp.Models.Material", "Material")
                        .WithMany("SemiFinishedProduct")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Material");
                });

            modelBuilder.Entity("CostEstimationApp.Models.Tool", b =>
                {
                    b.HasOne("CostEstimationApp.Models.ToolMaterial", "ToolMaterial")
                        .WithMany("Tools")
                        .HasForeignKey("ToolMaterialId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ToolMaterial");
                });

            modelBuilder.Entity("CostEstimationApp.Models.Machine", b =>
                {
                    b.Navigation("Operation");
                });

            modelBuilder.Entity("CostEstimationApp.Models.MachineType", b =>
                {
                    b.Navigation("Machine");
                });

            modelBuilder.Entity("CostEstimationApp.Models.Material", b =>
                {
                    b.Navigation("MRR");

                    b.Navigation("SemiFinishedProduct");
                });

            modelBuilder.Entity("CostEstimationApp.Models.MRR", b =>
                {
                    b.Navigation("Operation");
                });

            modelBuilder.Entity("CostEstimationApp.Models.SemiFinishedProduct", b =>
                {
                    b.Navigation("Operation");
                });

            modelBuilder.Entity("CostEstimationApp.Models.Tool", b =>
                {
                    b.Navigation("Operation");
                });

            modelBuilder.Entity("CostEstimationApp.Models.ToolMaterial", b =>
                {
                    b.Navigation("MRR");

                    b.Navigation("Tools");
                });

            modelBuilder.Entity("CostEstimationApp.Models.Worker", b =>
                {
                    b.Navigation("Operation");
                });
#pragma warning restore 612, 618
        }
    }
}
