using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FurnitureFactoryWeb
{
    public partial class FurnitureFactoryContext : DbContext
    {
        public FurnitureFactoryContext()
        {
        }

        public FurnitureFactoryContext(DbContextOptions<FurnitureFactoryContext> options) : base(options)
        {
        }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Furniture> Furnitures { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderRecord> OrderRecords { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<SupplyMaterial> SupplyMaterials { get; set; }
    }
}