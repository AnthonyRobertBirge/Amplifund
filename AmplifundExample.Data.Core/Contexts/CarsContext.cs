using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AmplifundExample.Data.Core.Contexts
{
    public partial class CarsContext : DbContext
    {
        public DbSet<CarModel> Cars { get; set; }

        public CarsContext(DbSet<CarModel> cars)
        {
            this.Cars = cars;
        }

        public CarsContext()
        {
        }

        public CarsContext(DbContextOptions<CarsContext> options, DbSet<CarModel> cars)
            : base(options)
        {
            this.Cars = cars;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:cardbserver.database.windows.net,1433;Initial Catalog=CarsDb;Persist Security Info=False;User ID=carAdmin;Password=4WDjzw6nd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
