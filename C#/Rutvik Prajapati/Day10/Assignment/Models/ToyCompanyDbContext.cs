using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day10Task.Models
{
    public class ToyCompanyDbContext : DbContext
    {
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Toy> Toys { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ToyCompanyDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Plant
            modelBuilder.Entity<Plant>()
                 .Property(p => p.Id)
                 .UseIdentityColumn()
                 .IsRequired();

            modelBuilder.Entity<Plant>()
                .Property(b => b.Name)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Plant>()
                .Property(b => b.Location)
                .HasMaxLength(50);
               

            //Toy
            modelBuilder.Entity<Toy>()
                .Property(t => t.Id)
                .UseIdentityColumn()
                .IsRequired();

            modelBuilder.Entity<Toy>()
                .Property(b => b.Name)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Toy>()
                .Property(b => b.Price)
                .IsRequired();

            modelBuilder.Entity<Toy>()
                .HasOne<Plant>(e=>e.Plant)
                .WithMany(a => a.Toys)
                .HasForeignKey(b => b.PlantId);

            //Customer
            modelBuilder.Entity<Customer>()
                .Property(t => t.Id)
                .UseIdentityColumn()
                .IsRequired();

            modelBuilder.Entity<Customer>()
                .Property(b => b.Name)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Customer>()
                .HasOne<Address>(e=>e.Address)
                .WithMany(x => x.Customers)
                .HasForeignKey(z => z.AddressId)
                .IsRequired();

            //Address
            modelBuilder.Entity<Address>()
                .Property(t => t.Id)
                .UseIdentityColumn()
                .IsRequired();

            modelBuilder.Entity<Address>()
                .Property(b => b.City)
                .HasMaxLength(35)
                .IsRequired();

            modelBuilder.Entity<Address>()
                .Property(b => b.District)
                .HasMaxLength(40)
                .IsRequired();

            modelBuilder.Entity<Address>()
                .Property(b => b.State)
                .HasMaxLength(40)
                .IsRequired();

            //OrderItem
            modelBuilder.Entity<OrderItem>()
                .Property(t => t.Id)
                .UseIdentityColumn()
                .IsRequired();

            modelBuilder.Entity<OrderItem>()
                .HasOne<Customer>(e=>e.Customer)
                .WithMany(x => x.OrderItems)
                .HasForeignKey(s => s.CustomerId)
                .IsRequired();

            modelBuilder.Entity<OrderItem>()
                .HasOne<Toy>(e=>e.Toy)
                .WithMany(x => x.OrderItems)
                .HasForeignKey(s => s.ToyId)
                .IsRequired();

            modelBuilder.Entity<OrderItem>()
                .Property(b => b.Quantity)
                .HasMaxLength(20)
                .IsRequired();

            modelBuilder.Entity<OrderItem>()
                .Property(b => b.Date)
                .IsRequired();

            modelBuilder.Entity<OrderItem>()
                .Property(b => b.TotalPrice)
                .IsRequired();
            modelBuilder.Entity<OrderItem>()
                .Property(b => b.TotalPrice)
                .IsRequired();

            //Order
            modelBuilder.Entity<Order>()
                .Property(t => t.Id)
                .UseIdentityColumn()
                .IsRequired();

            modelBuilder.Entity<Order>()
                .HasOne<Customer>(e=>e.Customer)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.CustomerId)
                .IsRequired();

            modelBuilder.Entity<Order>()
                .Property(x => x.GrandTotal)
                .IsRequired();

            modelBuilder.Entity<Order>()
                .Property(x => x.Status)
                .IsRequired();

            //Payment
            modelBuilder.Entity<Payment>()
                .Property(t => t.Id)
                .UseIdentityColumn()
                .IsRequired();

            modelBuilder.Entity<Payment>()
                .HasOne<Order>(e=>e.Order)
                .WithMany(x => x.Payments)
                .HasForeignKey(x => x.OrderId)
                .IsRequired();

            modelBuilder.Entity<Payment>()
                .Property(x => x.Status)
                .IsRequired();

            //Stock
            modelBuilder.Entity<Stock>()
                .Property(t => t.Id)
                .UseIdentityColumn()
                .IsRequired();

            modelBuilder.Entity<Stock>()
                .HasOne<Plant>(e=>e.Plant)
                .WithMany(x => x.Stocks)
                .HasForeignKey(x => x.PlantId)
                .IsRequired();

            modelBuilder.Entity<Stock>()
                .HasOne<Toy>(e=>e.Toy)
                .WithMany(x => x.Stocks)
                .HasForeignKey(x => x.ToyId);


            modelBuilder.Entity<Stock>()
                .Property(x => x.Quantity)
                .IsRequired();
        }
    }
}
