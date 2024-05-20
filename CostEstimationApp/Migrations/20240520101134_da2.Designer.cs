﻿// <auto-generated />
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
    [Migration("20240520101134_da2")]
    partial class da2
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Machines");
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

                    b.Property<int>("ToolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaterialId");

                    b.HasIndex("ToolId");

                    b.ToTable("MRRs");
                });

            modelBuilder.Entity("CostEstimationApp.Models.Operation", b =>
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

                    b.Property<decimal>("Duration")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MRRId")
                        .HasColumnType("int");

                    b.Property<int>("MachineId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ToolId")
                        .HasColumnType("int");

                    b.Property<int>("WorkerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MRRId");

                    b.HasIndex("MachineId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ToolId");

                    b.HasIndex("WorkerId");

                    b.ToTable("Operations");
                });

            modelBuilder.Entity("CostEstimationApp.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PostHeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PostLength")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PostWidth")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PreHeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PreLength")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PreWidth")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SemiFinishedProductId")
                        .HasColumnType("int");

                    b.Property<string>("Series")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SemiFinishedProductId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CostEstimationApp.Models.Result", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("MaterialCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OperationCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Results");
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

                    b.HasKey("Id");

                    b.ToTable("Tools");
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

            modelBuilder.Entity("CostEstimationApp.Models.MRR", b =>
                {
                    b.HasOne("CostEstimationApp.Models.Material", "Material")
                        .WithMany("MRR")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CostEstimationApp.Models.Tool", "Tool")
                        .WithMany("MRR")
                        .HasForeignKey("ToolId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Material");

                    b.Navigation("Tool");
                });

            modelBuilder.Entity("CostEstimationApp.Models.Operation", b =>
                {
                    b.HasOne("CostEstimationApp.Models.MRR", "MRR")
                        .WithMany()
                        .HasForeignKey("MRRId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CostEstimationApp.Models.Machine", "Machine")
                        .WithMany()
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CostEstimationApp.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CostEstimationApp.Models.Tool", "Tool")
                        .WithMany()
                        .HasForeignKey("ToolId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CostEstimationApp.Models.Worker", "Worker")
                        .WithMany()
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("MRR");

                    b.Navigation("Machine");

                    b.Navigation("Order");

                    b.Navigation("Tool");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("CostEstimationApp.Models.Order", b =>
                {
                    b.HasOne("CostEstimationApp.Models.SemiFinishedProduct", "SemiFinishedProduct")
                        .WithMany()
                        .HasForeignKey("SemiFinishedProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SemiFinishedProduct");
                });

            modelBuilder.Entity("CostEstimationApp.Models.Result", b =>
                {
                    b.HasOne("CostEstimationApp.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("CostEstimationApp.Models.SemiFinishedProduct", b =>
                {
                    b.HasOne("CostEstimationApp.Models.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Material");
                });

            modelBuilder.Entity("CostEstimationApp.Models.Material", b =>
                {
                    b.Navigation("MRR");
                });

            modelBuilder.Entity("CostEstimationApp.Models.Tool", b =>
                {
                    b.Navigation("MRR");
                });
#pragma warning restore 612, 618
        }
    }
}
