﻿using Microsoft.EntityFrameworkCore;
using CostEstimationApp.Models;

namespace CostEstimationApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Material> Materials { get; set; } = null!;
        public DbSet<Machine> Machines { get; set; }
        public DbSet<Tool> Tools { get; set; } = null!;
        public DbSet<Worker> Workers { get; set; }
        public DbSet<SemiFinishedProduct> SemiFinishedProducts { get; set; }
        public DbSet<MRR> MRRs { get; set; } = null!;
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Result> Results { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Material>()
                .Property(m => m.PricePerKg)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Material>()
                .Property(m => m.Density)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Machine>()
                .Property(m => m.CostPerHour)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Tool>()
                .Property(t => t.CostPerHour)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Worker>()
                .Property(w => w.CostPerHour)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<MRR>()
                .Property(m => m.Rate)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Order>()
                .Property(o => o.PreLength)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Order>()
                .Property(o => o.PreWidth)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Order>()
                .Property(o => o.PreHeight)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Order>()
                .Property(o => o.PostLength)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Order>()
                .Property(o => o.PostWidth)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Order>()
                .Property(o => o.PostHeight)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Operation>()
                .Property(op => op.Duration)
                .HasColumnType("decimal(18, 2)");

            // Konfiguracja relacji dla tabeli Operations
            modelBuilder.Entity<Material>()
                .HasMany(m => m.MRR)
                .WithOne(a => a.Material)
                .HasForeignKey(o => o.MaterialId)
                .OnDelete(DeleteBehavior.Restrict);
            // Konfiguracja relacji dla tabeli Operations
            modelBuilder.Entity<Tool>()
                .HasMany(t => t.MRR)
                .WithOne(o => o.Tool)
                .HasForeignKey(o => o.ToolId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Operation>()
                .HasOne(o => o.Machine)
                .WithMany()
                .HasForeignKey(o => o.MachineId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Operation>()
                .HasOne(o => o.Tool)
                .WithMany()
                .HasForeignKey(o => o.ToolId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Operation>()
                .HasOne(o => o.Worker)
                .WithMany()
                .HasForeignKey(o => o.WorkerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Operation>()
                .HasOne(o => o.MRR)
                .WithMany()
                .HasForeignKey(o => o.MRRId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Operation>()
                .HasOne(o => o.Order)
                .WithMany()
                .HasForeignKey(o => o.OrderId)
                .OnDelete(DeleteBehavior.Restrict);
            
           
        }
    }
}
