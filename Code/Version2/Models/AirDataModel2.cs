namespace Version2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AirDataModel2 : DbContext
    {
        public AirDataModel2()
            : base("name=AirDataModel2")
        {
        }

        public virtual DbSet<Mercury> Mercuries { get; set; }
        public virtual DbSet<Ozone> Ozones { get; set; }
        public virtual DbSet<Precipitation> Precipitations { get; set; }
        public virtual DbSet<StationTemperature> StationTemperatures { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mercury>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<Ozone>()
                .Property(e => e.Unit)
                .IsUnicode(false);
        }
    }
}
